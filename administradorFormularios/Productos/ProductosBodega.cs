
using AdministradorBL;
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

namespace administradorFormularios.Productos
{
    public partial class ProductosBodega : Form
    {
        private ProductoBodegaBL productosBL = new ProductoBodegaBL();
        private int paginaSeleccionada = 0;
        private decimal totalPaginas = 0;
        public ProductosBodega()
        {
            InitializeComponent();
            RellenarGrid(new ProductoBodega { CodigoProducto = "", NombreProducto = ""}, ref dgvProductosBodega);
        }       

        private void FiltroBuscar()
        {
            RellenarGrid(new ProductoBodega { NombreProducto = txtNombreProducto.Text, CodigoProducto = txtCodigoProducto.Text}, ref dgvProductosBodega);
        }

        private void RellenarGrid(ProductoBodega filtro, ref DataGridView vista, int paginaSeleccionada = 0)
        {
            int CantidadRegistros = 25;

            List<ProductoBodega> lista = productosBL.ObtenerProductos().ObjetoRespuesta;

            lista = lista.Where(x => (filtro.CodigoProducto.Equals("") || x.CodigoProducto.Equals(filtro.CodigoProducto))
                                    && (filtro.NombreProducto.Equals("") || x.NombreProducto.ToLower().Contains(filtro.NombreProducto.ToLower()))
            ).ToList();

            decimal totalRegistro = lista.Count();
            totalPaginas = Math.Ceiling(totalRegistro / (decimal)CantidadRegistros);


            vista.Rows.Clear();
            vista.ColumnCount = 3;
            vista.Columns[0].Name = "Codigo producto";
            vista.Columns[1].Name = "Nombre producto";
            vista.Columns[2].Name = "Cantidad en bodega";

            foreach (var item in lista.OrderBy(x => x.IdProducto).Skip((paginaSeleccionada * CantidadRegistros)).Take(CantidadRegistros).ToList())
            {
                string[] row =
                {    $"{item.CodigoProducto}",
                     $"{item.NombreProducto}",
                     $"{item.CantidadProducto}"                    
                };
                vista.Rows.Add(row);
            }
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
           FiltroBuscar();
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            FiltroBuscar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaSeleccionada += 1;

            if (paginaSeleccionada >= totalPaginas)
            {
                paginaSeleccionada -= 1;
                return;
            }

            RellenarGrid(new ProductoBodega { CodigoProducto = "", NombreProducto = "" }, ref dgvProductosBodega, paginaSeleccionada);
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
            RellenarGrid(new ProductoBodega { CodigoProducto = "", NombreProducto = "" },ref dgvProductosBodega, paginaSeleccionada);
            lblPaginaGasto.Text = (int.Parse(lblPaginaGasto.Text) - 1).ToString();
        }
    }
}
