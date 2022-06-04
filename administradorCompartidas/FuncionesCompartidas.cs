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
        public void RellenarComboboxEstados(ref ComboBox combobox, List<Estado> items)
        {
            combobox.DataSource = items;
            combobox.ValueMember = "EstadoCodigo";
            combobox.DisplayMember = "EstadoDescripcion";
        }

        public void RellenarComboboxProveedor(ref ComboBox combobox, List<Proveedor> items)
        {
            combobox.DataSource = items;
            combobox.ValueMember = "ProveedorCodigo";
            combobox.DisplayMember = "ProveedorNombre";
        }

        public void TextBoxNumeros(ref KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void TextBoxNumerosDecimales(ref KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }       
        
    }    
}
