namespace administradorFormularios.NotasCambioReport
{
    partial class NotasCambioRV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.pnlReporte = new System.Windows.Forms.Panel();
            this.pnlReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "administradorFormularios.NotasCambioReport.NotasCambioRpt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(694, 470);
            this.reportViewer1.TabIndex = 0;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Location = new System.Drawing.Point(12, 12);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(679, 125);
            this.pnlFiltros.TabIndex = 1;
            // 
            // pnlReporte
            // 
            this.pnlReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlReporte.Controls.Add(this.reportViewer1);
            this.pnlReporte.Location = new System.Drawing.Point(1, 144);
            this.pnlReporte.Name = "pnlReporte";
            this.pnlReporte.Size = new System.Drawing.Size(700, 476);
            this.pnlReporte.TabIndex = 2;
            // 
            // NotasCambioRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 632);
            this.Controls.Add(this.pnlReporte);
            this.Controls.Add(this.pnlFiltros);
            this.Name = "NotasCambioRV";
            this.Text = "NotasCambioRV";
            this.Load += new System.EventHandler(this.NotasCambioRV_Load);
            this.pnlReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Panel pnlReporte;
    }
}