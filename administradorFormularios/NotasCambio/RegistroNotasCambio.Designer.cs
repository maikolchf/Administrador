namespace administradorFormularios.NotasCambio
{
    partial class RegistroNotasCambio
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
            this.pnlFormularioRegistroNC = new System.Windows.Forms.Panel();
            this.btnProductosNC = new FontAwesome.Sharp.IconButton();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new MaterialSkin.Controls.MaterialLabel();
            this.cbxFacturaAplicada = new System.Windows.Forms.ComboBox();
            this.lblFacturaAplicada = new MaterialSkin.Controls.MaterialLabel();
            this.btnLimpiarNC = new FontAwesome.Sharp.IconButton();
            this.btnGuardarNC = new FontAwesome.Sharp.IconButton();
            this.dtFechaEmisionNC = new System.Windows.Forms.DateTimePicker();
            this.cbxProveedorNC = new System.Windows.Forms.ComboBox();
            this.txtMontoNC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtConsecutivoNC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblMontoNC = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaEmisionNC = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.lblConsecutivoNC = new MaterialSkin.Controls.MaterialLabel();
            this.pnGridNC = new System.Windows.Forms.Panel();
            this.dtNotasCambio = new System.Windows.Forms.DataGridView();
            this.lblIdNC = new System.Windows.Forms.Label();
            this.pnlFormularioRegistroNC.SuspendLayout();
            this.pnGridNC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNotasCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormularioRegistroNC
            // 
            this.pnlFormularioRegistroNC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFormularioRegistroNC.Controls.Add(this.lblIdNC);
            this.pnlFormularioRegistroNC.Controls.Add(this.btnProductosNC);
            this.pnlFormularioRegistroNC.Controls.Add(this.cbxEstado);
            this.pnlFormularioRegistroNC.Controls.Add(this.lblEstado);
            this.pnlFormularioRegistroNC.Controls.Add(this.cbxFacturaAplicada);
            this.pnlFormularioRegistroNC.Controls.Add(this.lblFacturaAplicada);
            this.pnlFormularioRegistroNC.Controls.Add(this.btnLimpiarNC);
            this.pnlFormularioRegistroNC.Controls.Add(this.btnGuardarNC);
            this.pnlFormularioRegistroNC.Controls.Add(this.dtFechaEmisionNC);
            this.pnlFormularioRegistroNC.Controls.Add(this.cbxProveedorNC);
            this.pnlFormularioRegistroNC.Controls.Add(this.txtMontoNC);
            this.pnlFormularioRegistroNC.Controls.Add(this.txtConsecutivoNC);
            this.pnlFormularioRegistroNC.Controls.Add(this.lblMontoNC);
            this.pnlFormularioRegistroNC.Controls.Add(this.lblFechaEmisionNC);
            this.pnlFormularioRegistroNC.Controls.Add(this.lblNombreProveedor);
            this.pnlFormularioRegistroNC.Controls.Add(this.lblConsecutivoNC);
            this.pnlFormularioRegistroNC.Location = new System.Drawing.Point(12, 12);
            this.pnlFormularioRegistroNC.Name = "pnlFormularioRegistroNC";
            this.pnlFormularioRegistroNC.Size = new System.Drawing.Size(679, 235);
            this.pnlFormularioRegistroNC.TabIndex = 0;
            // 
            // btnProductosNC
            // 
            this.btnProductosNC.FlatAppearance.BorderSize = 0;
            this.btnProductosNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosNC.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnProductosNC.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosNC.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnProductosNC.IconColor = System.Drawing.Color.Black;
            this.btnProductosNC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductosNC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosNC.Location = new System.Drawing.Point(23, 173);
            this.btnProductosNC.Name = "btnProductosNC";
            this.btnProductosNC.Size = new System.Drawing.Size(201, 49);
            this.btnProductosNC.TabIndex = 11;
            this.btnProductosNC.Text = "Registrar productos";
            this.btnProductosNC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductosNC.UseVisualStyleBackColor = true;
            this.btnProductosNC.Click += new System.EventHandler(this.btnProductosNC_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(127, 127);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(197, 21);
            this.cbxEstado.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Depth = 0;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstado.Location = new System.Drawing.Point(19, 126);
            this.lblEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 19);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // cbxFacturaAplicada
            // 
            this.cbxFacturaAplicada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFacturaAplicada.FormattingEnabled = true;
            this.cbxFacturaAplicada.Location = new System.Drawing.Point(466, 126);
            this.cbxFacturaAplicada.Name = "cbxFacturaAplicada";
            this.cbxFacturaAplicada.Size = new System.Drawing.Size(204, 21);
            this.cbxFacturaAplicada.TabIndex = 6;
            // 
            // lblFacturaAplicada
            // 
            this.lblFacturaAplicada.AutoSize = true;
            this.lblFacturaAplicada.Depth = 0;
            this.lblFacturaAplicada.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFacturaAplicada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFacturaAplicada.Location = new System.Drawing.Point(337, 125);
            this.lblFacturaAplicada.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFacturaAplicada.Name = "lblFacturaAplicada";
            this.lblFacturaAplicada.Size = new System.Drawing.Size(123, 19);
            this.lblFacturaAplicada.TabIndex = 7;
            this.lblFacturaAplicada.Text = "Factura aplicada:";
            // 
            // btnLimpiarNC
            // 
            this.btnLimpiarNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarNC.FlatAppearance.BorderSize = 0;
            this.btnLimpiarNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarNC.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarNC.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarNC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarNC.IconSize = 50;
            this.btnLimpiarNC.Location = new System.Drawing.Point(595, 173);
            this.btnLimpiarNC.Name = "btnLimpiarNC";
            this.btnLimpiarNC.Size = new System.Drawing.Size(75, 59);
            this.btnLimpiarNC.TabIndex = 8;
            this.btnLimpiarNC.UseVisualStyleBackColor = true;
            this.btnLimpiarNC.Click += new System.EventHandler(this.btnLimpiarNC_Click);
            // 
            // btnGuardarNC
            // 
            this.btnGuardarNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarNC.FlatAppearance.BorderSize = 0;
            this.btnGuardarNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNC.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarNC.IconColor = System.Drawing.Color.Black;
            this.btnGuardarNC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarNC.IconSize = 50;
            this.btnGuardarNC.Location = new System.Drawing.Point(514, 173);
            this.btnGuardarNC.Name = "btnGuardarNC";
            this.btnGuardarNC.Size = new System.Drawing.Size(75, 59);
            this.btnGuardarNC.TabIndex = 7;
            this.btnGuardarNC.UseVisualStyleBackColor = true;
            this.btnGuardarNC.Click += new System.EventHandler(this.btnGuardarNC_Click);
            // 
            // dtFechaEmisionNC
            // 
            this.dtFechaEmisionNC.Location = new System.Drawing.Point(520, 17);
            this.dtFechaEmisionNC.Name = "dtFechaEmisionNC";
            this.dtFechaEmisionNC.Size = new System.Drawing.Size(150, 20);
            this.dtFechaEmisionNC.TabIndex = 3;
            // 
            // cbxProveedorNC
            // 
            this.cbxProveedorNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxProveedorNC.FormattingEnabled = true;
            this.cbxProveedorNC.Location = new System.Drawing.Point(127, 68);
            this.cbxProveedorNC.Name = "cbxProveedorNC";
            this.cbxProveedorNC.Size = new System.Drawing.Size(204, 21);
            this.cbxProveedorNC.TabIndex = 2;
            // 
            // txtMontoNC
            // 
            this.txtMontoNC.Depth = 0;
            this.txtMontoNC.Hint = "";
            this.txtMontoNC.Location = new System.Drawing.Point(520, 67);
            this.txtMontoNC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMontoNC.Name = "txtMontoNC";
            this.txtMontoNC.PasswordChar = '\0';
            this.txtMontoNC.SelectedText = "";
            this.txtMontoNC.SelectionLength = 0;
            this.txtMontoNC.SelectionStart = 0;
            this.txtMontoNC.Size = new System.Drawing.Size(150, 23);
            this.txtMontoNC.TabIndex = 4;
            this.txtMontoNC.UseSystemPasswordChar = false;
            this.txtMontoNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoNC_KeyPress);
            this.txtMontoNC.Leave += new System.EventHandler(this.txtMontoNC_Leave);
            // 
            // txtConsecutivoNC
            // 
            this.txtConsecutivoNC.Depth = 0;
            this.txtConsecutivoNC.Hint = "";
            this.txtConsecutivoNC.Location = new System.Drawing.Point(127, 14);
            this.txtConsecutivoNC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConsecutivoNC.Name = "txtConsecutivoNC";
            this.txtConsecutivoNC.PasswordChar = '\0';
            this.txtConsecutivoNC.SelectedText = "";
            this.txtConsecutivoNC.SelectionLength = 0;
            this.txtConsecutivoNC.SelectionStart = 0;
            this.txtConsecutivoNC.Size = new System.Drawing.Size(204, 23);
            this.txtConsecutivoNC.TabIndex = 1;
            this.txtConsecutivoNC.UseSystemPasswordChar = false;
            // 
            // lblMontoNC
            // 
            this.lblMontoNC.AutoSize = true;
            this.lblMontoNC.Depth = 0;
            this.lblMontoNC.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMontoNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMontoNC.Location = new System.Drawing.Point(349, 71);
            this.lblMontoNC.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMontoNC.Name = "lblMontoNC";
            this.lblMontoNC.Size = new System.Drawing.Size(165, 19);
            this.lblMontoNC.TabIndex = 3;
            this.lblMontoNC.Text = "Monto de nota cambio:";
            // 
            // lblFechaEmisionNC
            // 
            this.lblFechaEmisionNC.AutoSize = true;
            this.lblFechaEmisionNC.Depth = 0;
            this.lblFechaEmisionNC.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaEmisionNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaEmisionNC.Location = new System.Drawing.Point(349, 19);
            this.lblFechaEmisionNC.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaEmisionNC.Name = "lblFechaEmisionNC";
            this.lblFechaEmisionNC.Size = new System.Drawing.Size(131, 19);
            this.lblFechaEmisionNC.TabIndex = 2;
            this.lblFechaEmisionNC.Text = "Fecha de emisión:";
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Depth = 0;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombreProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreProveedor.Location = new System.Drawing.Point(19, 71);
            this.lblNombreProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(81, 19);
            this.lblNombreProveedor.TabIndex = 1;
            this.lblNombreProveedor.Text = "Proveedor:";
            // 
            // lblConsecutivoNC
            // 
            this.lblConsecutivoNC.AutoSize = true;
            this.lblConsecutivoNC.Depth = 0;
            this.lblConsecutivoNC.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblConsecutivoNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConsecutivoNC.Location = new System.Drawing.Point(19, 19);
            this.lblConsecutivoNC.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConsecutivoNC.Name = "lblConsecutivoNC";
            this.lblConsecutivoNC.Size = new System.Drawing.Size(101, 19);
            this.lblConsecutivoNC.TabIndex = 0;
            this.lblConsecutivoNC.Text = "Consecutivo: ";
            // 
            // pnGridNC
            // 
            this.pnGridNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnGridNC.Controls.Add(this.dtNotasCambio);
            this.pnGridNC.Location = new System.Drawing.Point(12, 253);
            this.pnGridNC.Name = "pnGridNC";
            this.pnGridNC.Size = new System.Drawing.Size(679, 367);
            this.pnGridNC.TabIndex = 1;
            // 
            // dtNotasCambio
            // 
            this.dtNotasCambio.AllowUserToAddRows = false;
            this.dtNotasCambio.AllowUserToDeleteRows = false;
            this.dtNotasCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNotasCambio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtNotasCambio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtNotasCambio.BackgroundColor = System.Drawing.Color.White;
            this.dtNotasCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtNotasCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNotasCambio.GridColor = System.Drawing.Color.White;
            this.dtNotasCambio.Location = new System.Drawing.Point(3, 3);
            this.dtNotasCambio.Name = "dtNotasCambio";
            this.dtNotasCambio.Size = new System.Drawing.Size(673, 361);
            this.dtNotasCambio.TabIndex = 0;
            this.dtNotasCambio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeleccionarRegistro);
            // 
            // lblIdNC
            // 
            this.lblIdNC.AutoSize = true;
            this.lblIdNC.Location = new System.Drawing.Point(387, 173);
            this.lblIdNC.Name = "lblIdNC";
            this.lblIdNC.Size = new System.Drawing.Size(0, 13);
            this.lblIdNC.TabIndex = 12;
            this.lblIdNC.Visible = false;
            // 
            // RegistroNotasCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 632);
            this.Controls.Add(this.pnGridNC);
            this.Controls.Add(this.pnlFormularioRegistroNC);
            this.Name = "RegistroNotasCambio";
            this.Text = "RegistroNotasCambio";
            this.pnlFormularioRegistroNC.ResumeLayout(false);
            this.pnlFormularioRegistroNC.PerformLayout();
            this.pnGridNC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtNotasCambio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormularioRegistroNC;
        private System.Windows.Forms.DateTimePicker dtFechaEmisionNC;
        private System.Windows.Forms.ComboBox cbxProveedorNC;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMontoNC;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConsecutivoNC;
        private MaterialSkin.Controls.MaterialLabel lblMontoNC;
        private MaterialSkin.Controls.MaterialLabel lblFechaEmisionNC;
        private MaterialSkin.Controls.MaterialLabel lblNombreProveedor;
        private MaterialSkin.Controls.MaterialLabel lblConsecutivoNC;
        private FontAwesome.Sharp.IconButton btnLimpiarNC;
        private FontAwesome.Sharp.IconButton btnGuardarNC;
        private System.Windows.Forms.Panel pnGridNC;
        private System.Windows.Forms.ComboBox cbxEstado;
        private MaterialSkin.Controls.MaterialLabel lblEstado;
        private System.Windows.Forms.ComboBox cbxFacturaAplicada;
        private MaterialSkin.Controls.MaterialLabel lblFacturaAplicada;
        private FontAwesome.Sharp.IconButton btnProductosNC;
        private System.Windows.Forms.DataGridView dtNotasCambio;
        private System.Windows.Forms.Label lblIdNC;
    }
}