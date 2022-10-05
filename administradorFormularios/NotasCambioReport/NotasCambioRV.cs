using AdministradorBL;
using administradorCompartidas;
using AdministradorEntidades.Entidades.Reportes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administradorFormularios.NotasCambioReport
{
    public partial class NotasCambioRV : Form
    {
        FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        public NotasCambioRV()
        {
            InitializeComponent();
            funcionesCompartidas.RellenarComboboxEstados(ref cbxEstado, VariablesGlobales.estados.Where(x =>
                                                           x.EstadoCodigo == Constantes.EstadosNC.No_Aplicada ||
                                                           x.EstadoCodigo == Constantes.EstadosNC.Aplicada).ToList());
        }

        private readonly NotasCambioBL notasCambioBL = new NotasCambioBL();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

            if (cbxEstado.SelectedValue != null)
            {
                string estado = cbxEstado.SelectedValue.ToString();
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFinal = dtpFechaFinal.Value;
                var datos = notasCambioBL.DatosReporte(estado, fechaInicio, fechaFinal);
                List<NotasCambioReporte> notasCambioReporte = new List<NotasCambioReporte>();
                List<ReportParameter> reportParameters = new List<ReportParameter>();
                ReportDataSource reportDataSource = new ReportDataSource
                {
                    Value = datos.ObjetoRespuesta,
                    Name = "NotasCambioDS"
                };

                reportParameters.Add(new ReportParameter("fechaInicio", fechaInicio.ToString("dd/MM/yyyy")));
                reportParameters.Add(new ReportParameter("fechaFinal", fechaFinal.ToString("dd/MM/yyyy")));
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.SetParameters(reportParameters);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un estado.");
            }
            
        }
    }
}
