using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administradorCompartidas
{
    public class LlamadosFormularios
    {
        private Form activeForm = null;
        public void abrirFormularioHijo( Form hijo, ref Panel panelFormularios)
        {
            if (activeForm != null)            
                activeForm.Close();

            activeForm = hijo;

            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;

            panelFormularios.Controls.Add(hijo);
            panelFormularios.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }
    }
}
