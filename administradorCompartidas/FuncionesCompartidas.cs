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
            combobox.SelectedValue = "";
        }

        public void RellenarComboboxProveedor(ref ComboBox combobox, List<Proveedor> items)
        {
            combobox.DataSource = items;
            combobox.ValueMember = "ProveedorCodigo";
            combobox.DisplayMember = "ProveedorNombre";
            combobox.SelectedValue = "";
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }       

        public string FormatoMontoMoneda(string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                valor = valor.Trim().Replace("₡", "").Replace("$", "");
                return string.Format("{0:C}", Convert.ToDecimal(valor));
            }

            return "";
        }

        public decimal FomatoMonedaMonto(string valor )
        {
            if (string.IsNullOrEmpty(valor))
                return 0m;
            
            decimal monto = Convert.ToDecimal(valor.Trim().Replace("₡","").Replace("$", ""));

            return monto;
        }

        public int ConvertirStringAInt(string valor)
        {
            return string.IsNullOrEmpty(valor) ? 0 : Convert.ToInt32(valor);
        }

        public bool ValidarNull (object valor)
        {
            return valor == null ? true : false;
        }
    }    
}
