using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using administradorCompartidas;

namespace administradorFormularios
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            diseñoInterfaz();
        }
        private void diseñoInterfaz()
        {
            panelSubMenuProveedores.Visible = false;
            panelSubMenuGastos.Visible = false;
            panelSubMenuNotas.Visible = false;
            panelSubMenuUsuarios.Visible = false;
        }
        administradorCompartidas.LlamadosFormularios llamadosFormularios = new LlamadosFormularios();
        private void ocultarSubMenu()
        {
            if (panelSubMenuProveedores.Visible == true)
                panelSubMenuProveedores.Visible = false;

            if (panelSubMenuGastos.Visible == true)
                panelSubMenuGastos.Visible = false;

            if (panelSubMenuNotas.Visible == true)
                panelSubMenuNotas.Visible = false;

            if (panelSubMenuUsuarios.Visible == true)
                panelSubMenuUsuarios.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuProveedores);
        }

        private void btnListarProveedores_Click(object sender, EventArgs e)
        {
           
            llamadosFormularios.abrirFormularioHijo(new Proveedores.ListarProveedores(), ref panelFomularios);            
        }

        private void btnRegistrarProveedores_Click(object sender, EventArgs e)
        {
            llamadosFormularios.abrirFormularioHijo(new Proveedores.RegistrarProveedor(), ref panelFomularios);            
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuGastos);
        }

        private void btnListarGastos_Click(object sender, EventArgs e)
        {
            /*
            * Codigo para visualizar los formularios
            * */
        }

        private void btnRegistrarGasto_Click(object sender, EventArgs e)
        {
            /*
            * Codigo para visualizar los formularios
            * */
        }

        private void btnNotasCambio_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuNotas);
        }

        private void btnListarNotas_Click(object sender, EventArgs e)
        {
            /*
            * Codigo para visualizar los formularios
            * */
        }

        private void btnRegistrarNotas_Click(object sender, EventArgs e)
        {
            /*
            * Codigo para visualizar los formularios
            * */
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuUsuarios);
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            /*
            * Codigo para visualizar los formularios
            * */
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            /*
            * Codigo para visualizar los formularios
            * */

        }
    }
}
