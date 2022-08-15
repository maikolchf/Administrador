using AdministradorBL;
using administradorCompartidas;
using AdministradorEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administradorFormularios.Perfiles
{
    public partial class Perfiles : Form
    {
        private RolBL rolBL = new RolBL();
        private FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        private List<Rol> ltsRoles = new List<Rol>();
        private int paginaSeleccionada = 0;
        private decimal totalPaginas = 0;
        public Perfiles()
        {
            InitializeComponent();
            funcionesCompartidas.RellenarComboboxEstados(ref cbxEstadoPerfil, VariablesGlobales.estados.Where(x =>
                                                           x.EstadoCodigo == Constantes.EstadosDefaul.Activo ||
                                                           x.EstadoCodigo == Constantes.EstadosDefaul.Eliminado).ToList());
            RellenarGrid(ref dgvPerfiles);
        }

        private void btnGuardarPerfil_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                int rolId = lblRolId.Text.Equals("") ? 0 : Convert.ToInt32(lblRolId.Text);
                Rol rol = new Rol
                {
                    RolId = rolId, //crear un lbl para almacenar este id al editar
                    NombreRol = txtNombrePerfil.Text,
                    EstadoRol = cbxEstadoPerfil.SelectedValue.ToString(),
                    Permisos = new Permiso
                    {
                        Facturas = chxFacturas.Checked,
                        Gastos = chxGastos.Checked,
                        Inicio = chxInicio.Checked,
                        NotasCambio = chxNotasCambio.Checked,
                        Perfiles = chxPerfiles.Checked,
                        Proveedores = chxProveedores.Checked,
                        Usuarios = chxUsuarios.Checked,
                        ProductosBodega = chxProductosBodega.Checked,
                        PermisoId = ltsRoles?.Find(x => x.RolId.Equals(rolId))?.Permisos?.PermisoId ?? 0, 
                        RolId = rolId 
                    }
                };

                var respuesta = rolBL.InsertarModificar(rol);
                if (!respuesta.HayError)
                {
                    MessageBox.Show(respuesta.Mensaje);
                    LimpiarCampos();
                    RellenarGrid(ref dgvPerfiles);
                }
                else
                {
                    LimpiarCampos();
                    MessageBox.Show(respuesta.Mensaje);
                }
            }
            else
            {
                MessageBox.Show("Debe de rellenar los campos de nombre y estado");
            }
        }

        private void LimpiarCampos()
        {
            txtNombrePerfil.Text = string.Empty;
            lblRolId.Text = string.Empty;
            cbxEstadoPerfil.SelectedValue = -1;
            chxFacturas.Checked = false;
            chxGastos.Checked = false;
            chxInicio.Checked = false;
            chxNotasCambio.Checked = false;
            chxPerfiles.Checked = false;
            chxProveedores.Checked = false;
            chxUsuarios.Checked = false;
            chxProductosBodega.Checked = false;
        }

        private bool ValidarCamposVacios()
        {
            if (txtNombrePerfil.Text.Trim() != "" &&
               cbxEstadoPerfil.SelectedValue != null
               )
            {
                return true;
            }
            return false;
        }

        private void RellenarGrid(ref DataGridView vista, int paginaSeleccionada = 0)
        {

            int CantidadRegistros = 25;
            List<Rol> lista = rolBL.Obtener(new Rol()).ObjetoRespuesta;

            ltsRoles = lista;
            decimal totalRegistro = lista.Count();
            totalPaginas = Math.Ceiling(totalRegistro / (decimal)CantidadRegistros);

            vista.Rows.Clear();
            vista.ColumnCount = 5;
            vista.Columns[0].Name = "Nombre";
            vista.Columns[1].Name = "Estado";

            vista.Columns[2].Visible = false;
            vista.Columns[3].Visible = false;

            foreach (var item in lista.OrderBy(x => x. RolId).Skip((paginaSeleccionada * CantidadRegistros)).Take(CantidadRegistros).ToList())
            {
                string[] row =
                {    $"{item.NombreRol}",
                     $"{item.Estado.EstadoDescripcion}",
                     $"{item.RolId}",
                     $"{item.EstadoRol}",
                };
                vista.Rows.Add(row);
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaSeleccionada += 1;

            if (paginaSeleccionada >= totalPaginas)
            {
                paginaSeleccionada -= 1;
                return;
            }


            RellenarGrid(ref dgvPerfiles, paginaSeleccionada);
            lblPaginaPerfil.Text = (int.Parse(lblPaginaPerfil.Text) + 1).ToString();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            paginaSeleccionada -= 1;

            if (paginaSeleccionada < 0)
            {
                paginaSeleccionada += 1;
                return;
            }
            RellenarGrid(ref dgvPerfiles, paginaSeleccionada);
            lblPaginaPerfil.Text = (int.Parse(lblPaginaPerfil.Text) - 1).ToString();
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {            
            txtNombrePerfil.Text = dgvPerfiles.CurrentRow.Cells[0].Value.ToString();
            cbxEstadoPerfil.SelectedValue = dgvPerfiles.CurrentRow.Cells[3].Value.ToString();
            lblRolId.Text = dgvPerfiles.CurrentRow.Cells[2].Value.ToString();

            Permiso permisos = ltsRoles.Find(item => item.RolId.Equals(int.Parse(dgvPerfiles.CurrentRow.Cells[2].Value.ToString())))?.Permisos;
            if (permisos != null)
            {
                chxFacturas.Checked = permisos.Facturas ? true : false;
                chxGastos.Checked = permisos.Gastos ? true : false;
                chxInicio.Checked = permisos.Inicio ? true : false;
                chxNotasCambio.Checked = permisos.NotasCambio ? true : false;
                chxPerfiles.Checked = permisos.Perfiles ? true : false;
                chxProveedores.Checked = permisos.Proveedores ? true : false;
                chxUsuarios.Checked = permisos.Usuarios ? true : false;
            }
           

        }

        private void btnLimpiarPerfil_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
