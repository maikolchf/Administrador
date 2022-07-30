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
        public Perfiles()
        {
            InitializeComponent();
            funcionesCompartidas.RellenarComboboxEstados(ref cbxEstadoPerfil, VariablesGlobales.estados.Where(x =>
                                                           x.EstadoCodigo == Constantes.EstadosDefaul.Activo ||
                                                           x.EstadoCodigo == Constantes.EstadosDefaul.Eliminado).ToList());
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
                        PermisoId = ltsRoles?.Find(x => x.RolId.Equals(rolId))?.Permisos?.PermisoId ?? 0, 
                        RolId = rolId 
                    }
                };

                var respuesta = rolBL.InsertarModificar(rol);
                if (!respuesta.HayError)
                {
                    MessageBox.Show(respuesta.Mensaje);
                    LimpiarCampos();
                    //RellenarGrid(ref dtProveedores);
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
            cbxEstadoPerfil.SelectedValue = -1;
            chxFacturas.Checked.Equals(false);
            chxGastos.Checked.Equals(false);
            chxInicio.Checked.Equals(false);
            chxNotasCambio.Checked.Equals(false);
            chxPerfiles.Checked.Equals(false);
            chxProveedores.Checked.Equals(false);
            chxUsuarios.Checked.Equals(false);
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

    }
}
