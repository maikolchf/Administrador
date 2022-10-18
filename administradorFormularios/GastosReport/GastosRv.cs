using AdministradorBL;
using administradorCompartidas;
using AdministradorEntidades.Entidades.Reportes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace administradorFormularios.GastosReport
{
    public partial class GastosRv : Form
    {
        FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        GastosBL gastosBL = new GastosBL();
        public GastosRv()
        {
            InitializeComponent();
            funcionesCompartidas.RellenarComboboxEstados(ref cbxEstado, VariablesGlobales.estados.Where(x =>
                                                            x.EstadoCodigo == Constantes.EstadosGastos.Pendiente ||
                                                            x.EstadoCodigo == Constantes.EstadosGastos.Cancelado).ToList());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxEstado.SelectedValue != null)
                {
                    string estado = cbxEstado.SelectedValue.ToString();
                    DateTime fechaInicio = dtpFechaInicio.Value;
                    DateTime fechaFinal = dtpFechaFinal.Value;
                    var datos = gastosBL.ObtenerDatosReporte(estado, fechaInicio, fechaFinal);
                    List<ReportParameter> reportParameters = new List<ReportParameter>();
                    ReportDataSource reportDataSource = new ReportDataSource
                    {
                        Value = datos.ObjetoRespuesta,
                        Name = "GastosDS"
                    };

                    reportParameters.Add(new ReportParameter("fechaInicio", fechaInicio.ToString("dd/MM/yyyy")));
                    reportParameters.Add(new ReportParameter("fechaFinal", fechaFinal.ToString("dd/MM/yyyy")));
                    this.rptGastos.LocalReport.DataSources.Clear();
                    this.rptGastos.LocalReport.SetParameters(reportParameters);
                    this.rptGastos.LocalReport.DataSources.Add(reportDataSource);
                    this.rptGastos.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un estado.");
                }
            }
            catch(Exception oex)
            {

            }
            
        }

        private void GastosRv_Load(object sender, EventArgs e)
        {

        }
    }
}
