using AdministradorBL;
using System;
using System.Windows.Forms;
using AdministradorEntidades.Entidades;
using administradorCompartidas;
using System.Collections.Generic;
using System.Linq;

namespace administradorFormularios.Proveedores
{
    public partial class RegistrarProveedor : Form
    {
        private ProveedoresBL proveedoresBL = new ProveedoresBL();
        private EstadosBL estadosBL = new EstadosBL();
        private FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        private List<Proveedor> lstProveedores = new List<Proveedor>();
        private int paginaSeleccionada = 0;
        private decimal totalPaginas = 0;
        public RegistrarProveedor()
        {
            InitializeComponent();            
            funcionesCompartidas.RellenarComboboxEstados(ref cbxEstadoProveedor, VariablesGlobales.estados.Where(x => 
                                                            x.EstadoCodigo == Constantes.EstadosDefaul.Activo ||
                                                            x.EstadoCodigo == Constantes.EstadosDefaul.Eliminado).ToList());           
            RellenarGrid(ref dtProveedores);
            
        }       

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                Proveedor proveedor = new Proveedor()
                {
                    ProveedorId = Convert.ToInt32((lblProveedorId.Text == "" ? "0" : lblProveedorId.Text)),
                    ProveedorNombre = txtNombreProveedor.Text,
                    ProveedorCedula = txtCedulaProveedor.Text,
                    ProveedorTelefono = txtTelefonoProveedor.Text,
                    ProveedorGastoFijo = chkGastosFijo.Checked,
                    ProveedorEstado = cbxEstadoProveedor.SelectedValue.ToString(),
                    ProveedorCodigo = lstProveedores.Find(x => x.ProveedorId == Convert.ToInt32(lblProveedorId.Text == "" ? "0" : lblProveedorId.Text))?.ProveedorCodigo 
                                        ?? txtProveedorCodigo.Text
                };                

                var respuesta = proveedoresBL.Insertar(proveedor);
                if (!respuesta.HayError)
                {
                    MessageBox.Show(respuesta.Mensaje);
                    LimpiarCampos();
                    RellenarGrid(ref dtProveedores);
                }
                else
                {
                    LimpiarCampos();
                    MessageBox.Show(respuesta.Mensaje);
                }
            }
            else
            {
                MessageBox.Show("Debe de rellenar todos los campos");
            }
            
        }        

        private void RellenarGrid(ref DataGridView vista, int paginaSeleccionada = 0)
        {

            int CantidadRegistros = 25;
            List<Proveedor> lista = proveedoresBL.Obtener().ObjetoRespuesta;

            lstProveedores = lista;
            decimal totalRegistro = lista.Count();
            totalPaginas = Math.Ceiling(totalRegistro / (decimal)CantidadRegistros);

            vista.Rows.Clear();
            vista.ColumnCount = 7;            
            vista.Columns[0].Name = "Nombre";
            vista.Columns[1].Name = "Telefono";
            vista.Columns[2].Name = "Cedula";
            vista.Columns[3].Name = "Gasto Fijo";
            vista.Columns[4].Name = "Estado";
            vista.Columns[5].Name = "Id";

            vista.Columns[5].Visible = false;
            vista.Columns[6].Visible = false;

            foreach (var item in lista.OrderBy(x => x.ProveedorId).Skip((paginaSeleccionada * CantidadRegistros)).Take(CantidadRegistros).ToList())
            {
                string[] row = 
                {    $"{item.ProveedorNombre}", 
                     $"{item.ProveedorTelefono}", 
                     $"{item.ProveedorCedula}",
                     $"{(item.ProveedorGastoFijo == true ? Constantes.valores.Si : Constantes.valores.No)}",
                     $"{item.Estado.EstadoDescripcion}",
                     $"{item.ProveedorId}",
                     $"{item.ProveedorCodigo}",
                };
                vista.Rows.Add(row);
            }            
        }

        private void LimpiarCampos()
        {
            lblProveedorId.Text = "0";
            txtNombreProveedor.Text = String.Empty;
            txtCedulaProveedor.Text = String.Empty;
            txtTelefonoProveedor.Text = String.Empty;
            chkGastosFijo.Checked = false;
            cbxEstadoProveedor.SelectedIndex = -1;
            txtProveedorCodigo.Text = String.Empty;

            txtProveedorCodigo.Enabled = true;
        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            txtProveedorCodigo.Enabled = false;
            txtNombreProveedor.Text = dtProveedores.CurrentRow.Cells[0].Value.ToString();
            txtTelefonoProveedor.Text = dtProveedores.CurrentRow.Cells[1].Value.ToString();
            txtCedulaProveedor.Text = dtProveedores.CurrentRow.Cells[2].Value.ToString();
            chkGastosFijo.Checked = dtProveedores.CurrentRow.Cells[3].Value.ToString() == Constantes.valores.Si ? true : false;
            cbxEstadoProveedor.Text = dtProveedores.CurrentRow.Cells[4].Value.ToString();
            lblProveedorId.Text = dtProveedores.CurrentRow.Cells[5].Value.ToString();
            txtProveedorCodigo.Text = dtProveedores.CurrentRow.Cells[6].Value.ToString();
        }

        private bool ValidarCamposVacios()
        {
            if (txtNombreProveedor.Text.Trim() != "" &&
                txtCedulaProveedor.Text.Trim() != "" &&
                txtTelefonoProveedor.Text.Trim() != "" &&
                cbxEstadoProveedor.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }

        private void txtCedulaProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesCompartidas.TextBoxNumeros(ref e);
        }

        private void txtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesCompartidas.TextBoxNumeros(ref e);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaSeleccionada += 1;

            if (paginaSeleccionada >= totalPaginas)
            {
                paginaSeleccionada -= 1;
                return;
            }


            RellenarGrid(ref dtProveedores, paginaSeleccionada);
            lblPaginaProveedor.Text = (int.Parse(lblPaginaProveedor.Text) + 1).ToString();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            paginaSeleccionada -= 1;

            if (paginaSeleccionada < 0)
            {
                paginaSeleccionada += 1;
                return;
            }
            RellenarGrid(ref dtProveedores, paginaSeleccionada);
            lblPaginaProveedor.Text = (int.Parse(lblPaginaProveedor.Text) - 1).ToString();
        }
    }
}
