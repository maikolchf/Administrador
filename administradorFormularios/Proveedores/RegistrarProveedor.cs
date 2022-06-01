using AdministradorBL;
using System;
using System.Windows.Forms;
using AdministradorEntidades.Entidades;
using administradorCompartidas;
using System.Collections.Generic;

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
            funcionesCompartidas.RellenarComboboxEstados(ref cbxEstadoProveedor, VariablesGlobales.estados);
            List<Proveedor> proveedores = proveedoresBL.Obtener().ObjetoRespuesta;
            RellenarGrid(ref dtProveedores, proveedores);
            
        }       

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                Proveedor proveedor = new Proveedor()
                {
                    ProveedorId = Convert.ToInt32((lblProveedorId.Text == "" ? "0" : lblProveedorId.Text)),
                    ProveedorNombre = txtNombreProveedor.Text,
                    ProveedorCedula = txtCedulaProveedor.Text,
                    ProveedorTelefono = txtTelefonoProveedor.Text,
                    ProveedorGastoFijo = chkGastosFijo.Checked,
                    ProveedorEstado = cbxEstadoProveedor.Text == "Activo" ? "A" : "E"
                };

                var respuesta = proveedoresBL.Insertar(proveedor);
                if (!respuesta.HayError)
                {
                    MessageBox.Show(respuesta.Mensaje);
                    LimpiarCampos();
                    List<Proveedor> proveedores = proveedoresBL.Obtener().ObjetoRespuesta;
                    RellenarGrid(ref dtProveedores, proveedores);
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

        private void RellenarGrid(ref DataGridView vista, List<Proveedor> lista)
        {
            vista.Rows.Clear();
            vista.ColumnCount = 6;            
            vista.Columns[0].Name = "Nombre";
            vista.Columns[1].Name = "Telefono";
            vista.Columns[2].Name = "Cedula";
            vista.Columns[3].Name = "Gasto Fijo";
            vista.Columns[4].Name = "Estado";
            vista.Columns[5].Name = "Id";

            vista.Columns[5].Visible = false;

            foreach (var item in lista)
            {
                string[] row = 
                {    $"{item.ProveedorNombre}", 
                     $"{item.ProveedorTelefono}", 
                     $"{item.ProveedorCedula}",
                     $"{(item.ProveedorGastoFijo == true ? Constantes.valores.Si : Constantes.valores.No)}",
                     $"{item.Estado.EstadoDescripcion}",
                     $"{item.ProveedorId}"
                };
                vista.Rows.Add(row);
            }            
        }

        private void LimpiarCampos()
        {
            lblProveedorId.Text = "0";
            txtNombreProveedor.Text = String.Empty;
            txtCedulaProveedor.Text = String.Empty;
            txtTelefonoProveedor.Text = String.Empty;
            chkGastosFijo.Checked = false;
            cbxEstadoProveedor.SelectedIndex = -1;
        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {            
            txtNombreProveedor.Text = dtProveedores.CurrentRow.Cells[0].Value.ToString();
            txtTelefonoProveedor.Text = dtProveedores.CurrentRow.Cells[1].Value.ToString();
            txtCedulaProveedor.Text = dtProveedores.CurrentRow.Cells[2].Value.ToString();
            chkGastosFijo.Checked = dtProveedores.CurrentRow.Cells[3].Value.ToString() == Constantes.valores.Si ? true : false;
            cbxEstadoProveedor.Text = dtProveedores.CurrentRow.Cells[4].Value.ToString();
            lblProveedorId.Text = dtProveedores.CurrentRow.Cells[5].Value.ToString();
        }

        private bool ValidarCamposVacios()
        {
            if (txtNombreProveedor.Text.Trim() != "" &&
                txtCedulaProveedor.Text.Trim() != "" &&
                txtTelefonoProveedor.Text.Trim() != "" &&
                cbxEstadoProveedor.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }

        private void txtCedulaProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesCompartidas.TextBoxNumeros(ref e);
        }

        private void txtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesCompartidas.TextBoxNumeros(ref e);
        }        
    }
}
