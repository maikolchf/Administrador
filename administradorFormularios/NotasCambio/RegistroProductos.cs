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
    public partial class RegistroProductos : Form
    {
        private List<Producto> lstProductos;
        private ProductoBodegaBL productoBodegaBL;
        private FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        private int paginaSeleccionada = 0;
        private decimal totalPaginas = 0;
        public RegistroProductos(ref List<Producto> _lstProductos)
        {
            lstProductos = _lstProductos;
            InitializeComponent();
            RellenarGrid(ref dtProductos);
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

            if (ValidarCamposVacios())
            {
                Producto producto = new Producto
                {
                    idProductoNC = funcionesCompartidas.ConvertirStringAInt(lblIdProductoNC.Text),
                    IdNC = funcionesCompartidas.ConvertirStringAInt(lblIdProductosNC.Text),
                    Codigo = txtCodigoProducto.Text,
                    Cantidad = funcionesCompartidas.ConvertirStringAInt(txtCantidadProductos.Text),
                    Destalle = txtDescripcionProducto.Text,
                    Nombre = txtNombreProducto.Text,
                    Precio = funcionesCompartidas.FomatoMonedaMonto(txtPrecioProductos.Text),
                    idProducto = funcionesCompartidas.ConvertirStringAInt(lblIdProducto.Text)
                };

                if (lstProductos.Exists(x => x.Codigo == producto.Codigo))
                {
                    var prodEliminar = lstProductos.Find(x => x.Codigo == producto.Codigo);
                    lstProductos.Remove(prodEliminar);

                }

                lstProductos.Add(producto);
                LimpiarCampos();

                if (lstProductos.Count > 0)
                {
                    RellenarGrid(ref dtProductos);
                }
            }
            else
            {
                MessageBox.Show("Debe de rellenar todos los campos");
            }            
        }

        private bool ValidarCamposVacios()
        {
            if (txtCantidadProductos.Text.Trim() != string.Empty &&
               txtCodigoProducto.Text.Trim() != string.Empty &&
               txtNombreProducto.Text.Trim() != string.Empty &&
               txtPrecioProductos.Text.Trim() != string.Empty)
            {
                return true;
            }
            return false;
        }

        private void RellenarGrid(ref DataGridView vista, int paginaSeleccionada = 0)
        {
            int CantidadRegistros = 25;

            List<Producto> lista = lstProductos;

            decimal totalRegistro = lista.Count();
            totalPaginas = Math.Ceiling(totalRegistro / (decimal)CantidadRegistros);

            //lstGasto = lista;

            vista.Rows.Clear();
            vista.ColumnCount = 8;
            vista.Columns[0].Name = "Codigo";
            vista.Columns[1].Name = "Nombre producto";
            vista.Columns[2].Name = "Precio";
            vista.Columns[3].Name = "Cantidad";
            vista.Columns[4].Name = "Detalle";
            vista.Columns[5].Visible = false;
            vista.Columns[6].Visible = false;
            vista.Columns[7].Visible = false;

            foreach (var item in lista.OrderBy(x => x.IdNC).Skip((paginaSeleccionada * CantidadRegistros)).Take(CantidadRegistros).ToList())
            {
                string[] row =
                {    $"{item.Codigo}",
                     $"{item.Nombre}",
                     $"{funcionesCompartidas.FormatoMontoMoneda(item.Precio.ToString())}",
                     $"{item.Cantidad}",
                     $"{item.Destalle}",
                     $"{item.IdNC}",
                     $"{item.idProductoNC}",
                     $"{item.idProducto}"
                };
                vista.Rows.Add(row);
            }
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                txtCodigoProducto.Text = dtProductos.CurrentRow.Cells[0].Value.ToString();
                txtNombreProducto.Text = dtProductos.CurrentRow.Cells[1].Value.ToString();
                txtPrecioProductos.Text = dtProductos.CurrentRow.Cells[2].Value.ToString();
                txtCantidadProductos.Text = dtProductos.CurrentRow.Cells[3].Value.ToString();
                txtDescripcionProducto.Text = dtProductos.CurrentRow.Cells[4].Value.ToString();
                lblIdProductosNC.Text = dtProductos.CurrentRow.Cells[5].Value.ToString();
                lblIdProductoNC.Text = dtProductos.CurrentRow.Cells[6].Value.ToString();
                lblIdProducto.Text = dtProductos.CurrentRow.Cells[7].Value.ToString();
            }           
        }

        private void txtPrecioProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesCompartidas.TextBoxNumerosDecimales(ref e);
        }

        private void txtCantidadProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesCompartidas.TextBoxNumeros(ref e);
        }

        private void txtPrecioProductos_Leave(object sender, EventArgs e)
        {
            txtPrecioProductos.Text = funcionesCompartidas.FormatoMontoMoneda(txtPrecioProductos.Text);
        }

        private void BuscarProducto(object sender, EventArgs e)
        {
            string codigo = txtCodigoProducto.Text;
            productoBodegaBL = new ProductoBodegaBL();
            Respuesta<ProductoBodega> respuesta = new Respuesta<ProductoBodega>();

            respuesta = productoBodegaBL.obtener(new ProductoBodega { CodigoProducto = codigo });

            if (!respuesta.HayError && respuesta.ObjetoRespuesta != null)
            {
                txtNombreProducto.Text = respuesta.ObjetoRespuesta.NombreProducto;
                lblIdProducto.Text = respuesta.ObjetoRespuesta.IdProducto.ToString();
            }
            else
            {
                txtNombreProducto.Text = string.Empty;
                lblIdProducto.Text = string.Empty;
            }

        }

        private void LimpiarCampos()
        {
            lblIdProductoNC.Text = string.Empty;
            txtCodigoProducto.Text = string.Empty;
            txtCantidadProductos.Text = string.Empty;
            txtDescripcionProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecioProductos.Text = string.Empty;
            lblIdProducto.Text = string.Empty;
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaSeleccionada += 1;

            if (paginaSeleccionada >= totalPaginas)
            {
                paginaSeleccionada -= 1;
                return;
            }

            RellenarGrid(ref dtProductos, paginaSeleccionada);
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
            RellenarGrid(ref dtProductos, paginaSeleccionada);
            lblPaginaGasto.Text = (int.Parse(lblPaginaGasto.Text) - 1).ToString();
        }

        private void btnRegresarNC_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RegistroProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Productos guardados correctamente.");
        }
    }
}
