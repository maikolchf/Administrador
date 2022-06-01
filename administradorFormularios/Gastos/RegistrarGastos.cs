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
using AdministradorBL;
using AdministradorEntidades.Entidades;

namespace administradorFormularios.Gastos
{
    public partial class RegistrarGastos : Form
    {
        private FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        private ProveedoresBL proveedoresBL = new ProveedoresBL();
        public RegistrarGastos()
        {
            InitializeComponent();
            funcionesCompartidas.RellenarComboboxEstados(ref cbxGastoEstado, VariablesGlobales.estados);
            rellenarComboboxProveedores();


        }                   

        private void rellenarComboboxProveedores()
        {           
            try
            {
                var respuesta = proveedoresBL.Obtener();
                if (!respuesta.HayError && respuesta.ObjetoRespuesta != null && respuesta.ObjetoRespuesta.Count > 0)
                {
                    List<Proveedor> listProveGastos = respuesta.ObjetoRespuesta.Where(x => x.ProveedorGastoFijo == true).ToList();
                    funcionesCompartidas.RellenarComboboxProveedor(ref cbxProveedorGasto, listProveGastos.Count > 0 ? listProveGastos : new List<Proveedor>());
                }
            }
            catch (Exception oEx)
            {
                throw oEx;
            }

        }

        private void txtMontoGasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesCompartidas.TextBoxNumerosDecimales(ref e);
        }
    }
}
