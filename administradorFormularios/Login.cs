using AdministradorBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administradorFormularios
{
    public partial class Login : Form
    {
        LoginBL loginBL = new LoginBL();
        public Login()
        {
            InitializeComponent();
        }

        private void btnMostrarContrasenna_Click(object sender, EventArgs e)
        {
            if (txtContrasenna.UseSystemPasswordChar)
            {
                txtContrasenna.UseSystemPasswordChar = false;
                btnMostrarContrasenna.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                txtContrasenna.UseSystemPasswordChar = true;
                btnMostrarContrasenna.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    this.usuarioSesion = null;

                    AdministradorEntidades.Entidades.Login login = new AdministradorEntidades.Entidades.Login
                    {
                        Usuario = txtUsuario.Text,
                        Contrasenna = txtContrasenna.Text
                    };

                    var respuesta = loginBL.Login(login);

                    if (!respuesta.HayError && respuesta.ObjetoRespuesta != null)
                    {
                        MessageBox.Show(String.Format("Bienvenido {0} ", respuesta.ObjetoRespuesta.NombreUsuario));

                        this.DialogResult = DialogResult.OK;
                        this.usuarioSesion = respuesta.ObjetoRespuesta;
                    }
                    else
                    {
                        MessageBox.Show("Dados no coinciden con ningún usuario");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }

            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message);
            }
        }

        private bool ValidarCampos()
        {
            if (!txtContrasenna.Text.Equals(string.Empty) || !txtUsuario.Text.Equals(string.Empty))
                return true;

            return false;
        }        

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
