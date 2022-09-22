using AdministradorBL;
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
        public NotasCambioRV()
        {
            InitializeComponent();
        }

        private readonly NotasCambioBL notasCambioBL = new NotasCambioBL();
        private void NotasCambioRV_Load(object sender, EventArgs e)
        {
            string estado = "NP";
            DateTime fechaInicio = new DateTime(2022,09,01);
            DateTime fechaFinal = new DateTime(2022,09,30);

            var datos = notasCambioBL.DatosReporte(estado, fechaInicio, fechaFinal);
            List<NotasCambioReporte> notasCambioReporte = new List<NotasCambioReporte>();           
            List<ReportParameter> reportParameters = new List<ReportParameter>();
            ReportDataSource reportDataSource = new ReportDataSource
            {
                Value = datos.ObjetoRespuesta,
                Name = "NotasCambioDS"
            };

            reportParameters.Add(new ReportParameter("fechaInicio", fechaInicio.ToString("dd/mm/yyyy")));
            reportParameters.Add(new ReportParameter("fechaFinal", fechaFinal.ToString("dd/mm/yyyy")));


            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
