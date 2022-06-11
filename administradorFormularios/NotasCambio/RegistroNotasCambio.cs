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

namespace administradorFormularios.NotasCambio
{
    public partial class RegistroNotasCambio : Form
    {
        private ProveedoresBL proveedoresBL = new ProveedoresBL();
        private FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        private NotasCambioBL notasCambioBL = new NotasCambioBL();
        public RegistroNotasCambio()
        {
            InitializeComponent();
            rellenarComboboxProveedores();
        }

        private void btnGuardarNC_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                //logica para registrar o modificar
                NotaCambio notaCambio = new NotaCambio
                {
                    IdNC = 0,
                    ConsecutivoNC = txtConsecutivoNC.Text,
                    CodProveedorNC = cbxProveedorNC.SelectedValue.ToString(),
                    MontoNC = funcionesCompartidas.FomatoMonedaMonto(txtMontoNC.Text),
                    FechaEmisionNC = dtFechaEmisionNC.Value,
                    EstadoNC = ""
                };

                var respuesta = notasCambioBL.Insertar(notaCambio);
                if (!respuesta.HayError)
                {
                    MessageBox.Show(respuesta.Mensaje);
                    LimpiarCampos();
                    //RellenarGrid(ref dtGastos, 0);
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

        private void LimpiarCampos()
        {
            txtConsecutivoNC.Text = string.Empty;
            txtMontoNC.Text = string.Empty;
            cbxProveedorNC.SelectedValue = string.Empty;
            dtFechaEmisionNC.Value = DateTime.Now;
        }

        private void rellenarComboboxProveedores()
        {
            try
            {
                var respuesta = proveedoresBL.Obtener();
                if (!respuesta.HayError && respuesta.ObjetoRespuesta != null && respuesta.ObjetoRespuesta.Count > 0)
                {
                    List<Proveedor> listProveGastos = respuesta.ObjetoRespuesta.Where(x => x.ProveedorGastoFijo == false).ToList();
                    funcionesCompartidas.RellenarComboboxProveedor(ref cbxProveedorNC, listProveGastos.Count > 0 ? listProveGastos : new List<Proveedor>());
                }
            }
            catch (Exception oEx)
            {
                throw oEx;
            }

        }

        private void txtMontoNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesCompartidas.TextBoxNumerosDecimales(ref e);
        }

        private bool ValidarCamposVacios()
        {
            if (txtConsecutivoNC.Text.Trim() != "" &&
               txtMontoNC.Text.Trim() != "" &&
               cbxProveedorNC.SelectedValue != null)
            {
                return true;
            }
            return false;
        }

        private void txtMontoNC_Leave(object sender, EventArgs e)
        {
            txtMontoNC.Text = funcionesCompartidas.FormatoMontoMoneda(txtMontoNC.Text);
        }

        private void btnProductosNC_Click(object sender, EventArgs e)
        {
            RegistroProductos registroProductos = new RegistroProductos();
            registroProductos.Show();
        }
    }
}
