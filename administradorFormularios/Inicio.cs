using System;

using System.Windows.Forms;
using AdministradorBL;
using administradorCompartidas;
using AdministradorEntidades.Entidades;
using FontAwesome.Sharp;

namespace administradorFormularios
{
    public partial class Inicio : Form
    {
        IconButton btnActivo; 

        private EstadosBL estadosBL = new EstadosBL();
        public Inicio(Usuario usuario)
        {
            InitializeComponent();
            Permisos(usuario);
            VariablesGlobales.estados = estadosBL.Obtener().ObjetoRespuesta;
        }       
        administradorCompartidas.LlamadosFormularios llamadosFormularios = new LlamadosFormularios();       

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            btnFocus(btnProveedores);
            llamadosFormularios.abrirFormularioHijo(new Proveedores.RegistrarProveedor(), ref panelFomularios);
        }
       
        private void btnGastos_Click(object sender, EventArgs e)
        {
            btnFocus(btnGastos);
            llamadosFormularios.abrirFormularioHijo(new Gastos.RegistrarGastos(), ref panelFomularios);
        }
        
        private void btnNotasCambio_Click(object sender, EventArgs e)
        {
            btnFocus(btnNotasCambio);
            llamadosFormularios.abrirFormularioHijo(new NotasCambio.RegistroNotasCambio(), ref panelFomularios);
        }             

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            btnFocus(btnFacturas);
            llamadosFormularios.abrirFormularioHijo(new Facturas.RegistroFacturas(), ref panelFomularios);
        }

        private void btnProductosBodega_Click(object sender, EventArgs e)
        {
            btnFocus(btnProductosBodega);
            llamadosFormularios.abrirFormularioHijo(new Productos.ProductosBodega(), ref panelFomularios);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            btnFocus(btnInicio);
            llamadosFormularios.abrirFormularioHijo(new Principal.Principal(), ref panelFomularios);
        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            btnFocus(btnPerfiles);
            llamadosFormularios.abrirFormularioHijo(new Perfiles.Perfiles(), ref panelFomularios);
        }

        private void btlUsuarios_Click(object sender, EventArgs e)
        {
            btnFocus(btnUsuarios);
            llamadosFormularios.abrirFormularioHijo(new Usuarios.Usuarios(), ref panelFomularios);
        }

        private void Permisos(Usuario usuario)
        {
            if (usuario != null && usuario.Rol != null && usuario.Rol.Permisos != null)
            {
                btnProveedores.Enabled = usuario.Rol.Permisos.Proveedores;
                btnGastos.Enabled = usuario.Rol.Permisos.Gastos;
                btnNotasCambio.Enabled = usuario.Rol.Permisos.NotasCambio;
                btnFacturas.Enabled = usuario.Rol.Permisos.Facturas;
                btnProductosBodega.Enabled = usuario.Rol.Permisos.ProductosBodega;
                btnUsuarios.Enabled = usuario.Rol.Permisos.Usuarios;
                btnPerfiles.Enabled = usuario.Rol.Permisos.Perfiles;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFocus(FontAwesome.Sharp.IconButton btnActual)
        {
            btnActual.BackColor = System.Drawing.Color.FromArgb(45,84,111);
            if (btnActual != btnActivo)
                btnActivo.BackColor = System.Drawing.Color.FromArgb(27,97,147);
            
            btnActivo = btnActual;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnActivo = btnInicio;
        }
    }
}
