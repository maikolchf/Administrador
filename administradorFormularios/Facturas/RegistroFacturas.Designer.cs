namespace administradorFormularios.Facturas
{
    partial class RegistroFacturas
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
            this.pnFormularioFactura = new System.Windows.Forms.Panel();
            this.lblCOnsecutivoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblProveedorFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblMontoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.txtConsecutivoFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMontoFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbxEstadoFactura = new System.Windows.Forms.ComboBox();
            this.cbxProveedorFactura = new System.Windows.Forms.ComboBox();
            this.btnLimpiarGasto = new FontAwesome.Sharp.IconButton();
            this.btnGuardarGasto = new FontAwesome.Sharp.IconButton();
            this.lblIdFactura = new System.Windows.Forms.Label();
            this.pnGridFacturas = new System.Windows.Forms.Panel();
            this.pnFormularioFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFormularioFactura
            // 
            this.pnFormularioFactura.Controls.Add(this.lblIdFactura);
            this.pnFormularioFactura.Controls.Add(this.btnLimpiarGasto);
            this.pnFormularioFactura.Controls.Add(this.btnGuardarGasto);
            this.pnFormularioFactura.Controls.Add(this.cbxProveedorFactura);
            this.pnFormularioFactura.Controls.Add(this.cbxEstadoFactura);
            this.pnFormularioFactura.Controls.Add(this.txtMontoFactura);
            this.pnFormularioFactura.Controls.Add(this.txtConsecutivoFactura);
            this.pnFormularioFactura.Controls.Add(this.lblEstadoFactura);
            this.pnFormularioFactura.Controls.Add(this.lblMontoFactura);
            this.pnFormularioFactura.Controls.Add(this.lblProveedorFactura);
            this.pnFormularioFactura.Controls.Add(this.lblCOnsecutivoFactura);
            this.pnFormularioFactura.Location = new System.Drawing.Point(12, 12);
            this.pnFormularioFactura.Name = "pnFormularioFactura";
            this.pnFormularioFactura.Size = new System.Drawing.Size(679, 186);
            this.pnFormularioFactura.TabIndex = 0;
            // 
            // lblCOnsecutivoFactura
            // 
            this.lblCOnsecutivoFactura.AutoSize = true;
            this.lblCOnsecutivoFactura.Depth = 0;
            this.lblCOnsecutivoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCOnsecutivoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCOnsecutivoFactura.Location = new System.Drawing.Point(32, 26);
            this.lblCOnsecutivoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCOnsecutivoFactura.Name = "lblCOnsecutivoFactura";
            this.lblCOnsecutivoFactura.Size = new System.Drawing.Size(97, 19);
            this.lblCOnsecutivoFactura.TabIndex = 0;
            this.lblCOnsecutivoFactura.Text = "Consecutivo:";
            // 
            // lblProveedorFactura
            // 
            this.lblProveedorFactura.AutoSize = true;
            this.lblProveedorFactura.Depth = 0;
            this.lblProveedorFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProveedorFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProveedorFactura.Location = new System.Drawing.Point(32, 77);
            this.lblProveedorFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProveedorFactura.Name = "lblProveedorFactura";
            this.lblProveedorFactura.Size = new System.Drawing.Size(81, 19);
            this.lblProveedorFactura.TabIndex = 1;
            this.lblProveedorFactura.Text = "Proveedor:";
            // 
            // lblMontoFactura
            // 
            this.lblMontoFactura.AutoSize = true;
            this.lblMontoFactura.Depth = 0;
            this.lblMontoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMontoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMontoFactura.Location = new System.Drawing.Point(376, 26);
            this.lblMontoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMontoFactura.Name = "lblMontoFactura";
            this.lblMontoFactura.Size = new System.Drawing.Size(57, 19);
            this.lblMontoFactura.TabIndex = 2;
            this.lblMontoFactura.Text = "Monto:";
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Depth = 0;
            this.lblEstadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoFactura.Location = new System.Drawing.Point(376, 77);
            this.lblEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(60, 19);
            this.lblEstadoFactura.TabIndex = 3;
            this.lblEstadoFactura.Text = "Estado:";
            // 
            // txtConsecutivoFactura
            // 
            this.txtConsecutivoFactura.Depth = 0;
            this.txtConsecutivoFactura.Hint = "";
            this.txtConsecutivoFactura.Location = new System.Drawing.Point(135, 22);
            this.txtConsecutivoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConsecutivoFactura.Name = "txtConsecutivoFactura";
            this.txtConsecutivoFactura.PasswordChar = '\0';
            this.txtConsecutivoFactura.SelectedText = "";
            this.txtConsecutivoFactura.SelectionLength = 0;
            this.txtConsecutivoFactura.SelectionStart = 0;
            this.txtConsecutivoFactura.Size = new System.Drawing.Size(206, 23);
            this.txtConsecutivoFactura.TabIndex = 1;
            this.txtConsecutivoFactura.UseSystemPasswordChar = false;
            // 
            // txtMontoFactura
            // 
            this.txtMontoFactura.Depth = 0;
            this.txtMontoFactura.Hint = "";
            this.txtMontoFactura.Location = new System.Drawing.Point(439, 22);
            this.txtMontoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMontoFactura.Name = "txtMontoFactura";
            this.txtMontoFactura.PasswordChar = '\0';
            this.txtMontoFactura.SelectedText = "";
            this.txtMontoFactura.SelectionLength = 0;
            this.txtMontoFactura.SelectionStart = 0;
            this.txtMontoFactura.Size = new System.Drawing.Size(206, 23);
            this.txtMontoFactura.TabIndex = 2;
            this.txtMontoFactura.UseSystemPasswordChar = false;
            // 
            // cbxEstadoFactura
            // 
            this.cbxEstadoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEstadoFactura.FormattingEnabled = true;
            this.cbxEstadoFactura.Location = new System.Drawing.Point(439, 78);
            this.cbxEstadoFactura.Name = "cbxEstadoFactura";
            this.cbxEstadoFactura.Size = new System.Drawing.Size(206, 21);
            this.cbxEstadoFactura.TabIndex = 4;
            // 
            // cbxProveedorFactura
            // 
            this.cbxProveedorFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxProveedorFactura.FormattingEnabled = true;
            this.cbxProveedorFactura.Location = new System.Drawing.Point(135, 75);
            this.cbxProveedorFactura.Name = "cbxProveedorFactura";
            this.cbxProveedorFactura.Size = new System.Drawing.Size(206, 21);
            this.cbxProveedorFactura.TabIndex = 3;
            // 
            // btnLimpiarGasto
            // 
            this.btnLimpiarGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarGasto.FlatAppearance.BorderSize = 0;
            this.btnLimpiarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarGasto.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarGasto.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarGasto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarGasto.IconSize = 50;
            this.btnLimpiarGasto.Location = new System.Drawing.Point(570, 120);
            this.btnLimpiarGasto.Name = "btnLimpiarGasto";
            this.btnLimpiarGasto.Size = new System.Drawing.Size(75, 59);
            this.btnLimpiarGasto.TabIndex = 10;
            this.btnLimpiarGasto.UseVisualStyleBackColor = true;
            // 
            // btnGuardarGasto
            // 
            this.btnGuardarGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarGasto.FlatAppearance.BorderSize = 0;
            this.btnGuardarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarGasto.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarGasto.IconColor = System.Drawing.Color.Black;
            this.btnGuardarGasto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarGasto.IconSize = 50;
            this.btnGuardarGasto.Location = new System.Drawing.Point(489, 120);
            this.btnGuardarGasto.Name = "btnGuardarGasto";
            this.btnGuardarGasto.Size = new System.Drawing.Size(75, 59);
            this.btnGuardarGasto.TabIndex = 9;
            this.btnGuardarGasto.UseVisualStyleBackColor = true;
            // 
            // lblIdFactura
            // 
            this.lblIdFactura.AutoSize = true;
            this.lblIdFactura.Location = new System.Drawing.Point(36, 120);
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(0, 13);
            this.lblIdFactura.TabIndex = 0;
            this.lblIdFactura.Visible = false;
            // 
            // pnGridFacturas
            // 
            this.pnGridFacturas.Location = new System.Drawing.Point(13, 205);
            this.pnGridFacturas.Name = "pnGridFacturas";
            this.pnGridFacturas.Size = new System.Drawing.Size(678, 415);
            this.pnGridFacturas.TabIndex = 1;
            // 
            // RegistroFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 632);
            this.Controls.Add(this.pnGridFacturas);
            this.Controls.Add(this.pnFormularioFactura);
            this.Name = "RegistroFacturas";
            this.Text = "RegistroFacturas";
            this.pnFormularioFactura.ResumeLayout(false);
            this.pnFormularioFactura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFormularioFactura;
        private MaterialSkin.Controls.MaterialLabel lblCOnsecutivoFactura;
        private MaterialSkin.Controls.MaterialLabel lblProveedorFactura;
        private MaterialSkin.Controls.MaterialLabel lblMontoFactura;
        private System.Windows.Forms.ComboBox cbxEstadoFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMontoFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConsecutivoFactura;
        private MaterialSkin.Controls.MaterialLabel lblEstadoFactura;
        private System.Windows.Forms.ComboBox cbxProveedorFactura;
        private System.Windows.Forms.Label lblIdFactura;
        private FontAwesome.Sharp.IconButton btnLimpiarGasto;
        private FontAwesome.Sharp.IconButton btnGuardarGasto;
        private System.Windows.Forms.Panel pnGridFacturas;
    }
}