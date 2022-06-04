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
        private GastosBL gastosBL = new GastosBL();
        private ProveedoresBL proveedoresBL = new ProveedoresBL();
        private List<Gasto> lstGastos = new List<Gasto>();
        public RegistrarGastos()
        {
            InitializeComponent();
            funcionesCompartidas.RellenarComboboxEstados(ref cbxGastoEstado, VariablesGlobales.estados);
            rellenarComboboxProveedores();
            List<Gasto> gastos = gastosBL.Obtener().ObjetoRespuesta;
            RellenarGrid(ref dtGastos, gastos);

        }                          

        private void txtMontoGasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesCompartidas.TextBoxNumerosDecimales(ref e);
        }

        private void btnGuardarGasto_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {                
                Gasto gasto = new Gasto()
                {
                    GastoId = Convert.ToInt32((lblIdGasto.Text == "" ? "0" : lblIdGasto.Text)),
                    Consecutivo = txtConsecutivoGasto.Text,
                    Detalle = txtDetalleGasto.Text,
                    Monto = Convert.ToDecimal(txtMontoGasto.Text),
                    CodigoEstado = cbxGastoEstado.SelectedValue.ToString(),
                    CodigoProveedor = cbxProveedorGasto.SelectedValue.ToString(),
                    FechaVencimiento = dtpFechaVenciGasto.Value
                    
                };

                if (gasto.GastoId != 0)
                {
                    if (lstGastos.Exists(x => x.Consecutivo == gasto.Consecutivo) && 
                        lstGastos.Exists(x => x.CodigoProveedor == gasto.CodigoProveedor))
                    {
                        MessageBox.Show("Este consecutivo ya se encuentra registrado");
                        return;
                    }
                }

                var respuesta = gastosBL.Insertar(gasto);
                if (!respuesta.HayError)
                {
                    MessageBox.Show(respuesta.Mensaje);
                    LimpiarCampos();
                    List<Gasto> gastos = gastosBL.Obtener().ObjetoRespuesta;
                    RellenarGrid(ref dtGastos, gastos);
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
        private void btnLimpiarGasto_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool ValidarCamposVacios()
        {
            if (txtConsecutivoGasto.Text.Trim() != "" &&
               txtDetalleGasto.Text.Trim() != "" &&
               txtMontoGasto.Text.Trim() != "" &&
               cbxGastoEstado.SelectedIndex != -1 &&
               cbxProveedorGasto.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }
        private void LimpiarCampos()
        {
            lblIdGasto.Text = "0";
            txtConsecutivoGasto.Text = String.Empty;
            txtMontoGasto.Text = String.Empty;
            txtDetalleGasto.Text = String.Empty;
            cbxProveedorGasto.SelectedIndex = 0;
            cbxGastoEstado.SelectedIndex = 0;
            dtpFechaVenciGasto.Value = DateTime.Now;
        }
        private void RellenarGrid(ref DataGridView vista, List<Gasto> lista)
        {
            lstGastos = lista;
            vista.Rows.Clear();
            vista.ColumnCount = 9;
            vista.Columns[0].Name = "Consecutivo";
            vista.Columns[1].Name = "Proveedor";
            vista.Columns[2].Name = "Fecha vencimiento";
            vista.Columns[3].Name = "Monto";
            vista.Columns[4].Name = "Detalle";
            vista.Columns[5].Name = "Estado";

            vista.Columns[6].Visible = false;
            vista.Columns[7].Visible = false;
            vista.Columns[8].Visible = false;

            foreach (var item in lista)
            {
                string[] row =
                {    $"{item.Consecutivo}",
                     $"{item.Proveedor.ProveedorNombre}",
                     $"{item.FechaVencimiento}",
                     $"{item.Monto}",
                     $"{item.Detalle}",
                     $"{item.Estado.EstadoDescripcion}",
                     $"{item.GastoId}",
                     $"{item.CodigoProveedor}",
                     $"{item.CodigoEstado}"
                };
                vista.Rows.Add(row);
            }
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

        private void SeleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {            
            txtConsecutivoGasto.Text = dtGastos.CurrentRow.Cells[0].Value.ToString();
            //dtpFechaVenciGasto.Value = (DateTime)dtGastos.CurrentRow.Cells[2].Value;
            txtMontoGasto.Text = dtGastos.CurrentRow.Cells[3].Value.ToString();
            txtDetalleGasto.Text = dtGastos.CurrentRow.Cells[4].Value.ToString();
            lblIdGasto.Text = dtGastos.CurrentRow.Cells[6].Value.ToString();
            cbxProveedorGasto.SelectedValue = dtGastos.CurrentRow.Cells[7].Value.ToString();
            cbxGastoEstado.SelectedValue = dtGastos.CurrentRow.Cells[8].Value.ToString();
        }


    }
}
