using AdministradorEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administradorCompartidas
{
    public class FuncionesCompartidas
    {
        public void RellenarCombobox(ref ComboBox combobox, List<Combobox> items)
        {
            combobox.Items.Clear();
            foreach (var item in items)
            {
                combobox.Items.Add(item.texto);
            }
        }

        public void TextBoxNumeros(ref KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }    
}
