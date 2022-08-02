using administradorCompartidas;
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
        public Usuarios()
        {
            InitializeComponent();
            funcionesCompartidas.RellenarComboboxEstados(ref cbxEstadoUsuario, VariablesGlobales.estados.Where(x =>
                                                           x.EstadoCodigo == Constantes.EstadosDefaul.Eliminado ||
                                                           x.EstadoCodigo == Constantes.EstadosDefaul.Activo).ToList());
            RellenarComboboxRoles();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesCompartidas.TextBoxNumeros(ref e);
        }

        private void RellenarComboboxRoles()
        {
            try
            {
               
            }
            catch (Exception oEx)
            {
                throw oEx;
            }

        }

    }
}
