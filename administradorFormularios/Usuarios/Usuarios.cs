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

namespace administradorFormularios.Usuarios
{
    public partial class Usuarios : Form
    {
        FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        private RolBL rolesBL = new RolBL();
        private UsuarioBL usuarioBL = new UsuarioBL();
        private int paginaSeleccionada = 0;
        private decimal totalPaginas = 0;
        public Usuarios()
        {
            InitializeComponent();
            funcionesCompartidas.RellenarComboboxEstados(ref cbxEstadoUsuario, VariablesGlobales.estados.Where(x =>
                                                           x.EstadoCodigo == Constantes.EstadosDefaul.Eliminado ||
                                                           x.EstadoCodigo == Constantes.EstadosDefaul.Activo).ToList());
            RellenarComboboxRoles();

            RellenarGrid(ref dgvUsuarios);
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                Usuario usuario = new Usuario
                {
                    NombreUsuario = txtNombreUsuario.Text,
                    PrimerApellido = txtApellidoUno.Text,
                    SegundoApellido = txtApellidoDos.Text,
                    Correo = txtCorreoUsuario.Text,
                    Telefono = txtTelefonoUsuario.Text,
                    UsuarioLogin = txtUsuario.Text,
                    Contrasenna = txtContrasennaUsuario.Text,
                    EstadoUsuario = cbxEstadoUsuario.SelectedValue.ToString(),
                    RolId = (int)cbxRolUsuario.SelectedValue
                };

                Respuesta<Usuario> respuesta = usuarioBL.InsertarModificar(usuario); // insertar o actualizar neuvo usuario

                if (!respuesta.HayError)
                {
                    MessageBox.Show(respuesta.Mensaje);
                    LimpiarCampos();
                    RellenarGrid(ref dgvUsuarios);
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

        private void txtTelefonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesCompartidas.TextBoxNumeros(ref e);
        }

        private void RellenarComboboxRoles()
        {
            try
            {
                Respuesta<List<Rol>> respuesta = rolesBL.Obtener(new Rol());
                if (!respuesta.HayError)
                {
                    funcionesCompartidas.RellenarComboboxRoles(ref cbxRolUsuario, respuesta.ObjetoRespuesta ?? new List<Rol>());
                }
            }
            catch (Exception oEx)
            {
                throw oEx;
            }

        }

        private bool ValidarCamposVacios()
        {
            if (!txtNombreUsuario.Text.Trim().Equals(string.Empty) &&
                !txtApellidoUno.Text.Trim().Equals(string.Empty) &&
                !txtApellidoDos.Text.Trim().Equals(string.Empty) &&
                !txtCorreoUsuario.Text.Trim().Equals(string.Empty) &&
                !txtTelefonoUsuario.Text.Trim().Equals(string.Empty) &&
                !txtUsuario.Text.Trim().Equals(string.Empty) &&
                !txtContrasennaUsuario.Text.Trim().Equals(string.Empty) &&
                !cbxEstadoUsuario.SelectedIndex.Equals(-1) &&
                !cbxRolUsuario.SelectedIndex.Equals(-1)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LimpiarCampos()
        {
            txtNombreUsuario.Text = string.Empty;
            txtApellidoUno.Text = string.Empty;
            txtApellidoDos.Text = string.Empty;
            txtCorreoUsuario.Text = string.Empty;
            txtTelefonoUsuario.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContrasennaUsuario.Text = string.Empty;
            cbxEstadoUsuario.SelectedIndex = -1;
            cbxRolUsuario.SelectedIndex = -1;
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void RellenarGrid(ref DataGridView vista, int paginaSeleccionada = 0)
        {

            int CantidadRegistros = 25;
            List<Usuario> lista = usuarioBL.Obtener(new Usuario()).ObjetoRespuesta;

            //lstUsuarios = lista;
            decimal totalRegistro = lista.Count();
            totalPaginas = Math.Ceiling(totalRegistro / (decimal)CantidadRegistros);

            vista.Rows.Clear();
            vista.ColumnCount = 7;
            vista.Columns[0].Name = "Nombre";
            vista.Columns[1].Name = "Apellido";
            vista.Columns[2].Name = "Correo";
            vista.Columns[3].Name = "Telefono";
            vista.Columns[4].Name = "Usuario";
            vista.Columns[5].Name = "Estado";

            vista.Columns[6].Visible = false;

            foreach (var item in lista.OrderBy(x => x.UsuarioId).Skip((paginaSeleccionada * CantidadRegistros)).Take(CantidadRegistros).ToList())
            {
                string[] row =
                {    $"{item.NombreUsuario}",
                     $"{string.Format("{0} {1}",  item.PrimerApellido, item.SegundoApellido)}",
                     $"{item.Correo}",
                     $"{item.Telefono}",
                     $"{item.UsuarioLogin}",
                     $"{item.Estado.EstadoDescripcion}",
                     $"{item.UsuarioId}"
                };
                vista.Rows.Add(row);
            }
        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {


            if (txtContrasennaUsuario.UseSystemPasswordChar)
            {
                txtContrasennaUsuario.UseSystemPasswordChar = false;
                btnMostrarContraseña.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;                
            }
            else
            {
                txtContrasennaUsuario.UseSystemPasswordChar = true;
                btnMostrarContraseña.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }

        }
    }
}
