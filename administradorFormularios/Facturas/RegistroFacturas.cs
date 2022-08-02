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

namespace administradorFormularios.Facturas
{
    public partial class RegistroFacturas : Form
    {
        FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        ProveedoresBL proveedoresBL = new ProveedoresBL();
        FacturasBL facturasBL = new FacturasBL();
        private int paginaSeleccionada = 0;
        private decimal totalPaginas = 0;

        public RegistroFacturas()
        {
            InitializeComponent();
            rellenarComboboxProveedores();
            funcionesCompartidas.RellenarComboboxEstados(ref cbxEstadoFactura, VariablesGlobales.estados.Where(x =>
                                                            x.EstadoCodigo == Constantes.EstadosDefaul.Activo ||
                                                            x.EstadoCodigo == Constantes.EstadosDefaul.Eliminado).ToList());
            RellenarGrid(ref dgvFacturas);
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                Factura factura = new Factura
                {
                    FacturaId = Convert.ToInt32(lblIdFactura.Text.Equals(string.Empty) ? "0" : lblIdFactura.Text),
                    ConsecutivoFactura = txtConsecutivoFactura.Text,
                    MontoFactura = funcionesCompartidas.FomatoMonedaMonto(txtMontoFactura.Text),
                    EstadoFactura = cbxEstadoFactura.SelectedValue.ToString(),
                    FechaRegistro = DateTime.Now,
                    ProveedorFactura = cbxProveedorFactura.SelectedValue.ToString()
                };

                Respuesta<Factura> respuesta = facturasBL.InsertarModificar(factura);
                if (!respuesta.HayError)
                {
                    MessageBox.Show(respuesta.Mensaje);
                    LimpiarCampos();
                    RellenarGrid(ref dgvFacturas);
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

        private void txtMontoFactura_Leave(object sender, EventArgs e)
        {
            txtMontoFactura.Text = funcionesCompartidas.FormatoMontoMoneda(txtMontoFactura.Text);
        }

        private void rellenarComboboxProveedores()
        {
            try
            {
                var respuesta = proveedoresBL.Obtener();
                if (!respuesta.HayError && respuesta.ObjetoRespuesta != null && respuesta.ObjetoRespuesta.Count > 0)
                {
                    List<Proveedor> listProveGastos = respuesta.ObjetoRespuesta.Where(x => x.ProveedorGastoFijo == false).ToList();
                    funcionesCompartidas.RellenarComboboxProveedor(ref cbxProveedorFactura, listProveGastos.Count > 0 ? listProveGastos : new List<Proveedor>());
                }
            }
            catch (Exception oEx)
            {
                throw oEx;
            }

        }

        private bool ValidarCamposVacios()
        {
            if (txtConsecutivoFactura.Text.Trim() != string.Empty &&
               txtMontoFactura.Text.Trim() != string.Empty &&
               cbxEstadoFactura.SelectedValue != null &&
               cbxProveedorFactura.SelectedValue != null
               )
            {
                return true;
            }
            return false;
        }

        private void LimpiarCampos()
        {
            lblIdFactura.Text = string.Empty;
            txtConsecutivoFactura.Text = string.Empty;
            txtMontoFactura.Text = string.Empty;
            cbxEstadoFactura.SelectedValue = string.Empty;
            cbxProveedorFactura.SelectedValue = string.Empty;
        }
        private void RellenarGrid(ref DataGridView vista, int paginaSeleccionada = 0)
        {
            int CantidadRegistros = 25;

            List<Factura> lista = facturasBL.Obtener(new Factura()).ObjetoRespuesta;

            decimal totalRegistro = lista.Count();
            totalPaginas = Math.Ceiling(totalRegistro / (decimal)CantidadRegistros);


            vista.Rows.Clear();
            vista.ColumnCount = 8;
            vista.Columns[0].Name = "Consecutivo";
            vista.Columns[1].Name = "Proveedor";
            vista.Columns[2].Name = "Fecha registro";
            vista.Columns[3].Name = "Monto";
            vista.Columns[4].Name = "Estado";

            vista.Columns[5].Visible = false;
            vista.Columns[6].Visible = false;
            vista.Columns[7].Visible = false;

            foreach (var item in lista.OrderBy(x => x.FacturaId).Skip((paginaSeleccionada * CantidadRegistros)).Take(CantidadRegistros).ToList())
            {
                string[] row =
                {    $"{item.ConsecutivoFactura}",
                     $"{item.Proveedor.ProveedorNombre}",
                     $"{item.FechaRegistro.ToString("dd/MM/yyyy")}",
                     $"{funcionesCompartidas.FormatoMontoMoneda(item.MontoFactura.ToString())}",
                     $"{item.Estado.EstadoDescripcion}",
                     $"{item.FacturaId}",
                     $"{item.ProveedorFactura}",
                     $"{item.EstadoFactura}",
                };
                vista.Rows.Add(row);
            }
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            txtConsecutivoFactura.Text = dgvFacturas.CurrentRow.Cells[0].Value.ToString();
            cbxProveedorFactura.SelectedValue = dgvFacturas.CurrentRow.Cells[6].Value.ToString();            
            txtMontoFactura.Text = dgvFacturas.CurrentRow.Cells[3].Value.ToString();
            cbxEstadoFactura.SelectedValue = dgvFacturas.CurrentRow.Cells[7].Value.ToString();
            lblIdFactura.Text = dgvFacturas.CurrentRow.Cells[5].Value.ToString();           
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaSeleccionada += 1;

            if (paginaSeleccionada >= totalPaginas)
            {
                paginaSeleccionada -= 1;
                return;
            }

            RellenarGrid(ref dgvFacturas, paginaSeleccionada);
            lblPaginaGasto.Text = (int.Parse(lblPaginaGasto.Text) + 1).ToString();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            paginaSeleccionada -= 1;

            if (paginaSeleccionada < 0)
            {
                paginaSeleccionada += 1;
                return;
            }
            RellenarGrid(ref dgvFacturas, paginaSeleccionada);
            lblPaginaGasto.Text = (int.Parse(lblPaginaGasto.Text) - 1).ToString();
        }

        private void btnLimpiarFactura_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
