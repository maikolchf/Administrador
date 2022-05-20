using AdministradorBL;
using System;
using System.Windows.Forms;
using AdministradorEntidades.Entidades;
using administradorCompartidas;
using System.Collections.Generic;
using administradorCompartidas;

namespace administradorFormularios.Proveedores
{
    public partial class RegistrarProveedor : Form
    {
        private ProveedoresBL proveedoresBL = new ProveedoresBL();
        private EstadosBL estadosBL = new EstadosBL();
        private FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();        
        public RegistrarProveedor()
        {
            InitializeComponent();
            List<Combobox> estados = estadosBL.Obtener().ObjetoRespuesta;
            funcionesCompartidas.RellenarCombobox(ref cbxEstadoProveedor, estados);

            List<Proveedor> proveedores = proveedoresBL.Obtener().ObjetoRespuesta;
            RellenarGrid(ref dtProveedores, proveedores);
        }       

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor()
            {
                ProveedorNombre = btnNombreProveedor.Text,
                ProveedorCedula = btnCedulaProveedor.Text,
                ProveedorTelefono = btnTelefonoProveedor.Text,
                ProveedorGastoFijo = chkGastosFijo.Checked,
                ProveedorEstado = cbxEstadoProveedor.Text == "Activo" ? "A" : "E"
            };

            var respuesta = proveedoresBL.Insertar(proveedor);
            if (!respuesta.HayError)
            {
                MessageBox.Show(respuesta.Mensaje);
                List<Proveedor> proveedores = proveedoresBL.Obtener().ObjetoRespuesta;
                RellenarGrid(ref dtProveedores, proveedores);
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
        }

        private void RellenarGrid(ref DataGridView vista, List<Proveedor> lista)
        {
            vista.Rows.Clear();
            vista.ColumnCount = 5;
            vista.Columns[0].Name = "Nombre";
            vista.Columns[1].Name = "Telefono";
            vista.Columns[2].Name = "Cedula";
            vista.Columns[3].Name = "Gasto Fijo";
            vista.Columns[4].Name = "Estado";            

            foreach (var item in lista)
            {
                string[] row = 
                {    $"{item.ProveedorNombre}", 
                     $"{item.ProveedorTelefono}", 
                     $"{item.ProveedorCedula}",
                     $"{(item.ProveedorGastoFijo == true ? Constantes.valores.Si : Constantes.valores.No)}",
                     $"{item.Estado.EstadoDescripcion}" 
                };
                vista.Rows.Add(row);
            }            
        }
    }
}
