﻿namespace administradorFormularios.Gastos
{
    partial class RegistrarGastos
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
            this.pnlFormularioGasto = new System.Windows.Forms.Panel();
            this.txtMontoGasto = new System.Windows.Forms.TextBox();
            this.btnLimpiarGastos = new FontAwesome.Sharp.IconButton();
            this.btnGuardaGasto = new FontAwesome.Sharp.IconButton();
            this.txtDetalleGasto = new System.Windows.Forms.TextBox();
            this.lblDetalleGasto = new MaterialSkin.Controls.MaterialLabel();
            this.lblNontoGasto = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaVenciGasto = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenciGasto = new MaterialSkin.Controls.MaterialLabel();
            this.cbxProveedorGasto = new System.Windows.Forms.ComboBox();
            this.lblNombreProvGasto = new MaterialSkin.Controls.MaterialLabel();
            this.pnlGridgastos = new System.Windows.Forms.Panel();
            this.dtGastos = new System.Windows.Forms.DataGridView();
            this.lblEstadoGasto = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlFormularioGasto.SuspendLayout();
            this.pnlGridgastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormularioGasto
            // 
            this.pnlFormularioGasto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFormularioGasto.Controls.Add(this.comboBox1);
            this.pnlFormularioGasto.Controls.Add(this.lblEstadoGasto);
            this.pnlFormularioGasto.Controls.Add(this.txtMontoGasto);
            this.pnlFormularioGasto.Controls.Add(this.btnLimpiarGastos);
            this.pnlFormularioGasto.Controls.Add(this.btnGuardaGasto);
            this.pnlFormularioGasto.Controls.Add(this.txtDetalleGasto);
            this.pnlFormularioGasto.Controls.Add(this.lblDetalleGasto);
            this.pnlFormularioGasto.Controls.Add(this.lblNontoGasto);
            this.pnlFormularioGasto.Controls.Add(this.dtpFechaVenciGasto);
            this.pnlFormularioGasto.Controls.Add(this.lblFechaVenciGasto);
            this.pnlFormularioGasto.Controls.Add(this.cbxProveedorGasto);
            this.pnlFormularioGasto.Controls.Add(this.lblNombreProvGasto);
            this.pnlFormularioGasto.Location = new System.Drawing.Point(12, 12);
            this.pnlFormularioGasto.Name = "pnlFormularioGasto";
            this.pnlFormularioGasto.Size = new System.Drawing.Size(679, 242);
            this.pnlFormularioGasto.TabIndex = 0;
            // 
            // txtMontoGasto
            // 
            this.txtMontoGasto.Location = new System.Drawing.Point(181, 111);
            this.txtMontoGasto.MaxLength = 30;
            this.txtMontoGasto.Multiline = true;
            this.txtMontoGasto.Name = "txtMontoGasto";
            this.txtMontoGasto.Size = new System.Drawing.Size(200, 23);
            this.txtMontoGasto.TabIndex = 9;
            // 
            // btnLimpiarGastos
            // 
            this.btnLimpiarGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarGastos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarGastos.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarGastos.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarGastos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarGastos.IconSize = 50;
            this.btnLimpiarGastos.Location = new System.Drawing.Point(572, 173);
            this.btnLimpiarGastos.Name = "btnLimpiarGastos";
            this.btnLimpiarGastos.Size = new System.Drawing.Size(95, 57);
            this.btnLimpiarGastos.TabIndex = 8;
            this.btnLimpiarGastos.UseVisualStyleBackColor = true;
            // 
            // btnGuardaGasto
            // 
            this.btnGuardaGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardaGasto.FlatAppearance.BorderSize = 0;
            this.btnGuardaGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaGasto.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardaGasto.IconColor = System.Drawing.Color.Black;
            this.btnGuardaGasto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardaGasto.IconSize = 50;
            this.btnGuardaGasto.Location = new System.Drawing.Point(471, 173);
            this.btnGuardaGasto.Name = "btnGuardaGasto";
            this.btnGuardaGasto.Size = new System.Drawing.Size(95, 57);
            this.btnGuardaGasto.TabIndex = 7;
            this.btnGuardaGasto.UseVisualStyleBackColor = true;
            // 
            // txtDetalleGasto
            // 
            this.txtDetalleGasto.BackColor = System.Drawing.Color.White;
            this.txtDetalleGasto.Location = new System.Drawing.Point(419, 44);
            this.txtDetalleGasto.Multiline = true;
            this.txtDetalleGasto.Name = "txtDetalleGasto";
            this.txtDetalleGasto.Size = new System.Drawing.Size(248, 88);
            this.txtDetalleGasto.TabIndex = 6;
            this.txtDetalleGasto.TextChanged += new System.EventHandler(this.txtDetalleGasto_TextChanged);
            // 
            // lblDetalleGasto
            // 
            this.lblDetalleGasto.AutoSize = true;
            this.lblDetalleGasto.Depth = 0;
            this.lblDetalleGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalleGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalleGasto.Location = new System.Drawing.Point(415, 22);
            this.lblDetalleGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalleGasto.Name = "lblDetalleGasto";
            this.lblDetalleGasto.Size = new System.Drawing.Size(60, 19);
            this.lblDetalleGasto.TabIndex = 5;
            this.lblDetalleGasto.Text = "Detalle:";
            // 
            // lblNontoGasto
            // 
            this.lblNontoGasto.AutoSize = true;
            this.lblNontoGasto.Depth = 0;
            this.lblNontoGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNontoGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNontoGasto.Location = new System.Drawing.Point(19, 113);
            this.lblNontoGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNontoGasto.Name = "lblNontoGasto";
            this.lblNontoGasto.Size = new System.Drawing.Size(57, 19);
            this.lblNontoGasto.TabIndex = 3;
            this.lblNontoGasto.Text = "Monto:";
            this.lblNontoGasto.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // dtpFechaVenciGasto
            // 
            this.dtpFechaVenciGasto.Location = new System.Drawing.Point(181, 64);
            this.dtpFechaVenciGasto.Name = "dtpFechaVenciGasto";
            this.dtpFechaVenciGasto.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenciGasto.TabIndex = 2;
            this.dtpFechaVenciGasto.ValueChanged += new System.EventHandler(this.dtpFechaVenciGasto_ValueChanged);
            // 
            // lblFechaVenciGasto
            // 
            this.lblFechaVenciGasto.AutoSize = true;
            this.lblFechaVenciGasto.Depth = 0;
            this.lblFechaVenciGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaVenciGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaVenciGasto.Location = new System.Drawing.Point(15, 66);
            this.lblFechaVenciGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaVenciGasto.Name = "lblFechaVenciGasto";
            this.lblFechaVenciGasto.Size = new System.Drawing.Size(159, 19);
            this.lblFechaVenciGasto.TabIndex = 2;
            this.lblFechaVenciGasto.Text = "Fecha de vencimiento:";
            // 
            // cbxProveedorGasto
            // 
            this.cbxProveedorGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxProveedorGasto.FormattingEnabled = true;
            this.cbxProveedorGasto.Location = new System.Drawing.Point(181, 22);
            this.cbxProveedorGasto.Name = "cbxProveedorGasto";
            this.cbxProveedorGasto.Size = new System.Drawing.Size(200, 21);
            this.cbxProveedorGasto.TabIndex = 1;
            // 
            // lblNombreProvGasto
            // 
            this.lblNombreProvGasto.AutoSize = true;
            this.lblNombreProvGasto.Depth = 0;
            this.lblNombreProvGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombreProvGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreProvGasto.Location = new System.Drawing.Point(15, 24);
            this.lblNombreProvGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreProvGasto.Name = "lblNombreProvGasto";
            this.lblNombreProvGasto.Size = new System.Drawing.Size(138, 19);
            this.lblNombreProvGasto.TabIndex = 0;
            this.lblNombreProvGasto.Text = "Nombre proveedor:";
            // 
            // pnlGridgastos
            // 
            this.pnlGridgastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlGridgastos.Controls.Add(this.dtGastos);
            this.pnlGridgastos.Location = new System.Drawing.Point(13, 260);
            this.pnlGridgastos.Name = "pnlGridgastos";
            this.pnlGridgastos.Size = new System.Drawing.Size(678, 360);
            this.pnlGridgastos.TabIndex = 1;
            // 
            // dtGastos
            // 
            this.dtGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGastos.Location = new System.Drawing.Point(3, 3);
            this.dtGastos.Name = "dtGastos";
            this.dtGastos.Size = new System.Drawing.Size(672, 354);
            this.dtGastos.TabIndex = 0;
            // 
            // lblEstadoGasto
            // 
            this.lblEstadoGasto.AutoSize = true;
            this.lblEstadoGasto.Depth = 0;
            this.lblEstadoGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoGasto.Location = new System.Drawing.Point(23, 157);
            this.lblEstadoGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoGasto.Name = "lblEstadoGasto";
            this.lblEstadoGasto.Size = new System.Drawing.Size(60, 19);
            this.lblEstadoGasto.TabIndex = 10;
            this.lblEstadoGasto.Text = "Estado:";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // RegistrarGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 632);
            this.Controls.Add(this.pnlGridgastos);
            this.Controls.Add(this.pnlFormularioGasto);
            this.Name = "RegistrarGastos";
            this.Text = "RegistrarGastos";
            this.pnlFormularioGasto.ResumeLayout(false);
            this.pnlFormularioGasto.PerformLayout();
            this.pnlGridgastos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormularioGasto;
        private System.Windows.Forms.Panel pnlGridgastos;
        private System.Windows.Forms.ComboBox cbxProveedorGasto;
        private MaterialSkin.Controls.MaterialLabel lblNombreProvGasto;
        private System.Windows.Forms.DateTimePicker dtpFechaVenciGasto;
        private MaterialSkin.Controls.MaterialLabel lblFechaVenciGasto;
        private MaterialSkin.Controls.MaterialLabel lblNontoGasto;
        private System.Windows.Forms.TextBox txtDetalleGasto;
        private MaterialSkin.Controls.MaterialLabel lblDetalleGasto;
        private FontAwesome.Sharp.IconButton btnGuardaGasto;
        private FontAwesome.Sharp.IconButton btnLimpiarGastos;
        private System.Windows.Forms.DataGridView dtGastos;
        private System.Windows.Forms.TextBox txtMontoGasto;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel lblEstadoGasto;
    }
}