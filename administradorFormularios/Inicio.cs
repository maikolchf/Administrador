﻿using System;
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
        }       
        administradorCompartidas.LlamadosFormularios llamadosFormularios = new LlamadosFormularios();       

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            llamadosFormularios.abrirFormularioHijo(new Proveedores.RegistrarProveedor(), ref panelFomularios);
        }
       
        private void btnGastos_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnNotasCambio_Click(object sender, EventArgs e)
        {
            
        }
       

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            
        }
       
    }
}
