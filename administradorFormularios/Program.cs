using AdministradorEntidades.Entidades;
using administradorFormularios.NotasCambioReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administradorFormularios
{
    public class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InicioSistema();
        }

        public static void InicioSistema()
        {
            //bool salir = false;
            //while (!salir)
            //{
            //    Login login = new Login();
            //    login.ShowDialog();

            //    if (login.DialogResult.Equals(DialogResult.OK))
            //    {
            //        Application.Run(new Inicio(login.usuarioSesion));
            //    }
            //    else if (login.DialogResult.Equals(DialogResult.Abort) || login.DialogResult.Equals(DialogResult.Cancel))
            //    {
            //        salir = true;
            //    }
            //}
            Application.Run(new NotasCambioRV());
        }
    }
}
