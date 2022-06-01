using System;

using System.Windows.Forms;
using AdministradorBL;
using administradorCompartidas;

namespace administradorFormularios
{
    public partial class Inicio : Form
    {
        private VariablesGlobales variablesGlobales = new VariablesGlobales();
        private EstadosBL estadosBL = new EstadosBL();
        public Inicio()
        {
            InitializeComponent();
            variablesGlobales.estados = estadosBL.Obtener().ObjetoRespuesta;
        }       
        administradorCompartidas.LlamadosFormularios llamadosFormularios = new LlamadosFormularios();       

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            llamadosFormularios.abrirFormularioHijo(new Proveedores.RegistrarProveedor(), ref panelFomularios);
        }
       
        private void btnGastos_Click(object sender, EventArgs e)
        {
            llamadosFormularios.abrirFormularioHijo(new Gastos.RegistrarGastos(), ref panelFomularios);
        }
        
        private void btnNotasCambio_Click(object sender, EventArgs e)
        {
            llamadosFormularios.abrirFormularioHijo(new NotasCambio.RegistroNotasCambio(), ref panelFomularios);
        }
       

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void panelFomularios_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
