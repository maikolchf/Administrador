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
            this.lblIdFactura = new System.Windows.Forms.Label();
            this.btnLimpiarFactura = new FontAwesome.Sharp.IconButton();
            this.btnGuardarFactura = new FontAwesome.Sharp.IconButton();
            this.cbxProveedorFactura = new System.Windows.Forms.ComboBox();
            this.cbxEstadoFactura = new System.Windows.Forms.ComboBox();
            this.txtMontoFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtConsecutivoFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblMontoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblProveedorFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblCOnsecutivoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.pnGridFacturas = new System.Windows.Forms.Panel();
            this.pnlPaginado = new System.Windows.Forms.Panel();
            this.lblPaginaGasto = new System.Windows.Forms.Label();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.pnFormularioFactura.SuspendLayout();
            this.pnGridFacturas.SuspendLayout();
            this.pnlPaginado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFormularioFactura
            // 
            this.pnFormularioFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnFormularioFactura.Controls.Add(this.lblIdFactura);
            this.pnFormularioFactura.Controls.Add(this.btnLimpiarFactura);
            this.pnFormularioFactura.Controls.Add(this.btnGuardarFactura);
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
            // lblIdFactura
            // 
            this.lblIdFactura.AutoSize = true;
            this.lblIdFactura.Location = new System.Drawing.Point(36, 120);
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(0, 13);
            this.lblIdFactura.TabIndex = 0;
            this.lblIdFactura.Visible = false;
            // 
            // btnLimpiarFactura
            // 
            this.btnLimpiarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarFactura.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFactura.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarFactura.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarFactura.IconSize = 50;
            this.btnLimpiarFactura.Location = new System.Drawing.Point(570, 120);
            this.btnLimpiarFactura.Name = "btnLimpiarFactura";
            this.btnLimpiarFactura.Size = new System.Drawing.Size(75, 59);
            this.btnLimpiarFactura.TabIndex = 10;
            this.btnLimpiarFactura.UseVisualStyleBackColor = true;
            this.btnLimpiarFactura.Click += new System.EventHandler(this.btnLimpiarFactura_Click);
            // 
            // btnGuardarFactura
            // 
            this.btnGuardarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarFactura.FlatAppearance.BorderSize = 0;
            this.btnGuardarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarFactura.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarFactura.IconColor = System.Drawing.Color.Black;
            this.btnGuardarFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarFactura.IconSize = 50;
            this.btnGuardarFactura.Location = new System.Drawing.Point(489, 120);
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.Size = new System.Drawing.Size(75, 59);
            this.btnGuardarFactura.TabIndex = 9;
            this.btnGuardarFactura.UseVisualStyleBackColor = true;
            this.btnGuardarFactura.Click += new System.EventHandler(this.btnGuardarFactura_Click);
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
            // cbxEstadoFactura
            // 
            this.cbxEstadoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEstadoFactura.FormattingEnabled = true;
            this.cbxEstadoFactura.Location = new System.Drawing.Point(439, 78);
            this.cbxEstadoFactura.Name = "cbxEstadoFactura";
            this.cbxEstadoFactura.Size = new System.Drawing.Size(206, 21);
            this.cbxEstadoFactura.TabIndex = 4;
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
            this.txtMontoFactura.Leave += new System.EventHandler(this.txtMontoFactura_Leave);
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
            // pnGridFacturas
            // 
            this.pnGridFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnGridFacturas.Controls.Add(this.dgvFacturas);
            this.pnGridFacturas.Controls.Add(this.pnlPaginado);
            this.pnGridFacturas.Location = new System.Drawing.Point(13, 205);
            this.pnGridFacturas.Name = "pnGridFacturas";
            this.pnGridFacturas.Size = new System.Drawing.Size(678, 415);
            this.pnGridFacturas.TabIndex = 1;
            // 
            // pnlPaginado
            // 
            this.pnlPaginado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaginado.Controls.Add(this.lblPaginaGasto);
            this.pnlPaginado.Controls.Add(this.btnSiguiente);
            this.pnlPaginado.Controls.Add(this.btnAtras);
            this.pnlPaginado.Location = new System.Drawing.Point(3, 379);
            this.pnlPaginado.Name = "pnlPaginado";
            this.pnlPaginado.Size = new System.Drawing.Size(672, 33);
            this.pnlPaginado.TabIndex = 3;
            // 
            // lblPaginaGasto
            // 
            this.lblPaginaGasto.AutoSize = true;
            this.lblPaginaGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaGasto.Location = new System.Drawing.Point(323, 5);
            this.lblPaginaGasto.Name = "lblPaginaGasto";
            this.lblPaginaGasto.Size = new System.Drawing.Size(24, 25);
            this.lblPaginaGasto.TabIndex = 0;
            this.lblPaginaGasto.Text = "1";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnSiguiente.IconColor = System.Drawing.Color.Black;
            this.btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente.IconSize = 25;
            this.btnSiguiente.Location = new System.Drawing.Point(604, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(65, 27);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnAtras.IconColor = System.Drawing.Color.Black;
            this.btnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtras.IconSize = 25;
            this.btnAtras.Location = new System.Drawing.Point(3, 3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(65, 27);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(3, 3);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(672, 370);
            this.dgvFacturas.TabIndex = 4;
            this.dgvFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeleccionarRegistro);
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
            this.pnGridFacturas.ResumeLayout(false);
            this.pnlPaginado.ResumeLayout(false);
            this.pnlPaginado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
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
        private FontAwesome.Sharp.IconButton btnLimpiarFactura;
        private FontAwesome.Sharp.IconButton btnGuardarFactura;
        private System.Windows.Forms.Panel pnGridFacturas;
        private System.Windows.Forms.Panel pnlPaginado;
        private System.Windows.Forms.Label lblPaginaGasto;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnAtras;
        private System.Windows.Forms.DataGridView dgvFacturas;
    }
}