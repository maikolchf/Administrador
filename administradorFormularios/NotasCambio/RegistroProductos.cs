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
        private List<ProductoNC> lstProductoNCs;
        private FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
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
                    IdNC = Convert.ToInt32(lblIdProductosNC.Text),
                    Codigo = txtCodigoProducto.Text,
                    Cantidad = Convert.ToInt32(txtCantidadProductos.Text),
                    Destalle = txtDescripcionProducto.Text,
                    Nombre = txtNombreProducto.Text,
                    Precio = funcionesCompartidas.FomatoMonedaMonto(txtPrecioProductos.Text)
                };

                if (lstProductos.Exists(x => x.IdNC == producto.IdNC))
                {
                    var prodEliminar = lstProductos.Find(x => x.IdNC == producto.IdNC);
                    lstProductos.Remove(prodEliminar);

                }

                lstProductos.Add(producto);

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

            //decimal totalRegistro = lista.Count();
            //totalPaginas = Math.Ceiling(totalRegistro / (decimal)CantidadRegistros);

            //lstGasto = lista;

            vista.Rows.Clear();
            vista.ColumnCount = 6;
            vista.Columns[0].Name = "Codigo";
            vista.Columns[1].Name = "Nombre producto";
            vista.Columns[2].Name = "Precio";
            vista.Columns[3].Name = "Cantidad";
            vista.Columns[4].Name = "Detalle";
            vista.Columns[5].Visible = false;

            foreach (var item in lista)
            {
                string[] row =
                {    $"{item.Codigo}",
                     $"{item.Nombre}",
                     $"{funcionesCompartidas.FormatoMontoMoneda(item.Precio.ToString())}",
                     $"{item.Cantidad}",
                     $"{item.Destalle}",
                     $"{item.IdNC}"
                };
                vista.Rows.Add(row);
            }
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoProducto.Text = dtProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombreProducto.Text = dtProductos.CurrentRow.Cells[1].Value.ToString();
            txtPrecioProductos.Text = dtProductos.CurrentRow.Cells[2].Value.ToString();
            txtCantidadProductos.Text = dtProductos.CurrentRow.Cells[3].Value.ToString();
            txtDescripcionProducto.Text = dtProductos.CurrentRow.Cells[4].Value.ToString();
            lblIdProductosNC.Text = dtProductos.CurrentRow.Cells[5].Value.ToString();
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

        
    }
}
