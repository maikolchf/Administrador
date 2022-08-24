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
        private FacturasBL facturasBL = new FacturasBL();
        private List<NotaCambio> lstNotacambios = new List<NotaCambio>();
        private List<Producto> ltsProductos = new List<Producto>();
        private int paginaSeleccionada = 0;
        private decimal totalPaginas = 0;
        public RegistroNotasCambio()
        {
            InitializeComponent();
            RellenarComboboxProveedores();
            RellemarComboboxFacturas();
            RellenarGrid(ref dtNotasCambio);
            funcionesCompartidas.RellenarComboboxEstados(ref cbxEstado, VariablesGlobales.estados.Where(x =>
                                                           x.EstadoCodigo == Constantes.EstadosNC.No_Aplicada ||
                                                           x.EstadoCodigo == Constantes.EstadosNC.Aplicada).ToList());
        }

        private void btnGuardarNC_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                //Validar factura aplicada                
                int facturaAplicadaId = cbxFacturaAplicada.SelectedValue == null || cbxFacturaAplicada.SelectedValue.ToString() == "" ? 0: Convert.ToInt32(cbxFacturaAplicada.SelectedValue.ToString());
                //logica para registrar o modificar
               NotaCambio notaCambio = new NotaCambio
                {
                    IdNC = Convert.ToInt32((lblIdNC.Text == "" ? "0" : lblIdNC.Text)),
                    ConsecutivoNC = txtConsecutivoNC.Text,
                    CodProveedorNC = cbxProveedorNC.SelectedValue.ToString(),
                    MontoNC = funcionesCompartidas.FomatoMonedaMonto(txtMontoNC.Text),
                    FechaEmisionNC = dtFechaEmisionNC.Value,
                    EstadoNC = cbxEstado.SelectedValue.ToString(),
                    IdFacturaAplicada = facturaAplicadaId,
                    ltsProductos = ltsProductos
                };

                if (!notaCambio.EstadoNC.Equals(Constantes.EstadosNC.Aplicada))
                {
                    notaCambio.IdFacturaAplicada = 0;
                }

                if (lstNotacambios.Exists(x => x.IdNC == notaCambio.IdNC))
                {
                    var notaCambioOld = lstNotacambios.Find(x => x.IdNC == notaCambio.IdNC);
                    notaCambio.ltsProductoNC = notaCambioOld.ltsProductoNC;                    
                }

                var respuesta = notasCambioBL.Insertar(notaCambio);
                if (!respuesta.HayError)
                {
                    MessageBox.Show(respuesta.Mensaje);
                    LimpiarCampos();
                    RellenarGrid(ref dtNotasCambio);
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

        private void btnProductosNC_Click(object sender, EventArgs e)
         {
            RegistroProductos registroProductos = new RegistroProductos(ref ltsProductos);
            registroProductos.Show();
        }
        private void LimpiarCampos()
        {
            lblIdNC.Text = string.Empty;
            txtConsecutivoNC.Text = string.Empty;
            txtMontoNC.Text = string.Empty;
            cbxProveedorNC.SelectedValue = string.Empty;
            dtFechaEmisionNC.Value = dtFechaEmisionNC.MaxDate;
            cbxEstado.SelectedValue = string.Empty;
            cbxFacturaAplicada.SelectedValue = string.Empty;
            ltsProductos = new List<Producto>();
        }

        private void RellenarComboboxProveedores()
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

        private void RellemarComboboxFacturas()
        {
            try
            {
                var respuesta = facturasBL.Obtener(new Factura { EstadoFactura = "A"});
                if (!respuesta.HayError && respuesta.ObjetoRespuesta != null && respuesta.ObjetoRespuesta.Count > 0)
                {                    
                    funcionesCompartidas.RellenarComboboxFactura(ref cbxFacturaAplicada, respuesta.ObjetoRespuesta);
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
               cbxProveedorNC.SelectedValue != null
               )
            {
                return true;
            }
            return false;
        }

        private void txtMontoNC_Leave(object sender, EventArgs e)
        {
            txtMontoNC.Text = funcionesCompartidas.FormatoMontoMoneda(txtMontoNC.Text);
        }        

        private void btnLimpiarNC_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void RellenarGrid(ref DataGridView vista, int paginaSeleccionada = 0)
        {
            int CantidadRegistros = 25;

            List<NotaCambio> lista = notasCambioBL.Obtener().ObjetoRespuesta;

            decimal totalRegistro = lista.Count();
            totalPaginas = Math.Ceiling(totalRegistro / (decimal)CantidadRegistros);

            lstNotacambios = lista;

            vista.Rows.Clear();
            vista.ColumnCount = 10;
            vista.Columns[0].Name = "Consecutivo";
            vista.Columns[1].Name = "Proveedor";
            vista.Columns[2].Name = "Fecha emisión";
            vista.Columns[3].Name = "Monto";
            vista.Columns[4].Name = "Estado";
            vista.Columns[5].Name = "Factura aplicada";

            vista.Columns[6].Visible = false;
            vista.Columns[7].Visible = false;
            vista.Columns[8].Visible = false;
            vista.Columns[9].Visible = false;

            foreach (var item in lista.OrderBy(x => x.IdNC).Skip((paginaSeleccionada * CantidadRegistros)).Take(CantidadRegistros).ToList())
            {
                string[] row =
                {    $"{item.ConsecutivoNC}",
                     $"{item.Proveedor.ProveedorNombre}",
                     $"{item.FechaEmisionNC.ToString("dd/MM/yyyy")}",
                     $"{funcionesCompartidas.FormatoMontoMoneda(item.MontoNC.ToString())}",
                     $"{item.Estado.EstadoDescripcion}",
                     $"{item.Factura?.ConsecutivoFactura ?? string.Empty}",

                     $"{item.CodProveedorNC}",
                     $"{item.EstadoNC}",
                     $"{item.IdFacturaAplicada}",
                     $"{item.IdNC}",
                };
                vista.Rows.Add(row);
            }
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                txtConsecutivoNC.Text = dtNotasCambio.CurrentRow.Cells[0].Value.ToString();
                cbxProveedorNC.SelectedValue = dtNotasCambio.CurrentRow.Cells[6].Value.ToString();
                dtFechaEmisionNC.Value = Convert.ToDateTime(dtNotasCambio.CurrentRow.Cells[2].Value.ToString());
                txtMontoNC.Text = dtNotasCambio.CurrentRow.Cells[3].Value.ToString();
                cbxEstado.SelectedValue = dtNotasCambio.CurrentRow.Cells[7].Value.ToString();
                cbxFacturaAplicada.SelectedValue = Convert.ToInt32(dtNotasCambio.CurrentRow.Cells[8].Value);
                lblIdNC.Text = dtNotasCambio.CurrentRow.Cells[9].Value.ToString();

                if (!string.IsNullOrEmpty(lblIdNC.Text))
                {
                    List<ProductoNC> productoNCs = lstNotacambios.Find(item => item.IdNC == Convert.ToInt32(lblIdNC.Text)).ltsProductoNC;
                    ltsProductos.Clear();
                    productoNCs.ForEach(item => {
                        Producto producto = new Producto
                        {
                            idProductoNC = item.IdProductoNC,
                            idProducto = item.IdProducto,
                            Cantidad = item.CantidadProdNC,
                            Codigo = item.ProductoBodega.CodigoProducto,
                            Destalle = item.DescripcionProdNC,
                            Nombre = item.ProductoBodega.NombreProducto,
                            IdNC = item.IdNC,
                            Precio = item.PrecioProdNC
                        };
                        ltsProductos.Add(producto);
                    });
                }
            }            
        }

        private void AplicarNotaCambio(object sender, EventArgs e)
        {
            string vEstado =  funcionesCompartidas.ValidarNull(cbxEstado.SelectedValue)   ? "" : cbxEstado.SelectedValue.ToString();

            if (vEstado == Constantes.EstadosNC.Aplicada)
            {
                lblFacturaAplicada.Visible = true;
                cbxFacturaAplicada.Visible = true;
            }
            else
            {
                lblFacturaAplicada.Visible = false;
                cbxFacturaAplicada.Visible = false;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaSeleccionada += 1;

            if (paginaSeleccionada >= totalPaginas)
            {
                paginaSeleccionada -= 1;
                return;
            }

            RellenarGrid(ref dtNotasCambio, paginaSeleccionada);
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
            RellenarGrid(ref dtNotasCambio, paginaSeleccionada);
            lblPaginaGasto.Text = (int.Parse(lblPaginaGasto.Text) - 1).ToString();
        }
    }
}
