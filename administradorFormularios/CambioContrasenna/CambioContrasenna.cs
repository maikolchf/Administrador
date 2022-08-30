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
    public partial class CambioContrasenna : Form
    {
        UsuarioBL usuariosBL = new UsuarioBL();
        FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        public CambioContrasenna()
        {
            InitializeComponent();
        }

        private void btnValidarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                var correoBuscar = txtCorreoValidar.Text;
                if (funcionesCompartidas.CorreoValido(correoBuscar))
                {
                    var usuario = usuariosBL.Obtener(new AdministradorEntidades.Entidades.Usuario { Correo = correoBuscar });

                    if (usuario.ObjetoRespuesta.Count() == 0)
                    {
                        MessageBox.Show("El correo ingresado no corresponde a ningun usuario");
                    }
                    else
                    {
                        string subject = "Token de cambio de contraseña";

                        string format = "El token generado para el cambio de contraseña al usuario {0}, es el siguiente: {1}";
                        string token = funcionesCompartidas.GenerarRandom(100000, 999999);
                        StringBuilder body = new StringBuilder();
                        body.AppendFormat(format, usuario.ObjetoRespuesta.FirstOrDefault().NombreUsuario, token);

                        bool enviado = Correo.enviarCorreo(correoBuscar, subject, body.ToString());

                        if (enviado)
                        {
                            var respuesta = usuariosBL.InsertarModificar(new Usuario
                            {
                                Correo = usuario.ObjetoRespuesta.FirstOrDefault().Correo,
                                Contrasenna = null,
                                EstadoUsuario = usuario.ObjetoRespuesta.FirstOrDefault().EstadoUsuario,
                                FechaGeneraToken = DateTime.Now,
                                NombreUsuario = usuario.ObjetoRespuesta.FirstOrDefault().NombreUsuario,
                                PrimerApellido = usuario.ObjetoRespuesta.FirstOrDefault().PrimerApellido,
                                SegundoApellido = usuario.ObjetoRespuesta.FirstOrDefault().SegundoApellido,
                                Telefono = usuario.ObjetoRespuesta.FirstOrDefault().Telefono,
                                UsuarioId = usuario.ObjetoRespuesta.FirstOrDefault().UsuarioId,
                                RolId = usuario.ObjetoRespuesta.FirstOrDefault().RolId,
                                Token = token,
                                UsuarioLogin = usuario.ObjetoRespuesta.FirstOrDefault().UsuarioLogin 
                                
                            });

                            if (!respuesta.HayError)
                            {
                                // abrimos form de cambiar contraseña
                            }
                            else
                            {
                                MessageBox.Show("Ah ocurrido un al realizar el cambio de contraseña.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ah ocurrido un error al enviar el correo electronico con el token para el cambio de contraseña.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El correo ingresado no cumple con el formato adecuado.");
                }
            }
            catch (Exception oEx)
            {

            }
        }
    }
}
