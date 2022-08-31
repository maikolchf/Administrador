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

namespace administradorFormularios.CambioContrasenna
{
    public partial class NuevaContrasenna : Form
    {
        FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        private Usuario _Usuario;
        private UsuarioBL usuarioBL = new UsuarioBL();
        public NuevaContrasenna(Usuario usuario)
        {
            _Usuario = usuario;
            InitializeComponent();
        }

        private void btnGuardarNuevaContrasenna_Click(object sender, EventArgs e)
        {
            try
            {
                _Usuario.Contrasenna = txtNuevaContrasenna.Text;
                _Usuario.Token = string.Empty;
                _Usuario.FechaGeneraToken = DateTime.Now;
                var respuest = usuarioBL.InsertarModificar(_Usuario);

                if (!respuest.HayError)
                {
                    MessageBox.Show("La contraseña se actualizó con exito");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show(respuest.Mensaje);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message);
            }
        }

        private void btnMostrarContrasenna_Click(object sender, EventArgs e)
        {
            if (txtNuevaContrasenna.UseSystemPasswordChar)
            {
                txtNuevaContrasenna.UseSystemPasswordChar = false;
                btnMostrarContrasenna.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                txtNuevaContrasenna.UseSystemPasswordChar = true;
                btnMostrarContrasenna.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }
    }
}
