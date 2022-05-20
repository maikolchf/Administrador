namespace administradorFormularios.Proveedores
{
    partial class RegistrarProveedor
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
            this.pnlFormularioProveedores = new System.Windows.Forms.Panel();
            this.btnLimpiarProveedor = new FontAwesome.Sharp.IconButton();
            this.btnGuardarProveedor = new FontAwesome.Sharp.IconButton();
            this.cbxEstadoProveedor = new System.Windows.Forms.ComboBox();
            this.lblEstadoProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.chkGastosFijo = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblProveedorGasto = new MaterialSkin.Controls.MaterialLabel();
            this.txtCedulaProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCedulaProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefonoProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTelefonoProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pnlGridProveedores = new System.Windows.Forms.Panel();
            this.dtProveedores = new System.Windows.Forms.DataGridView();
            this.lblProveedorId = new MaterialSkin.Controls.MaterialLabel();
            this.pnlFormularioProveedores.SuspendLayout();
            this.pnlGridProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormularioProveedores
            // 
            this.pnlFormularioProveedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFormularioProveedores.BackColor = System.Drawing.Color.White;
            this.pnlFormularioProveedores.Controls.Add(this.lblProveedorId);
            this.pnlFormularioProveedores.Controls.Add(this.btnLimpiarProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.btnGuardarProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.cbxEstadoProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.lblEstadoProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.chkGastosFijo);
            this.pnlFormularioProveedores.Controls.Add(this.lblProveedorGasto);
            this.pnlFormularioProveedores.Controls.Add(this.txtCedulaProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.lblCedulaProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.txtTelefonoProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.lblTelefonoProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.txtNombreProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.materialLabel1);
            this.pnlFormularioProveedores.Location = new System.Drawing.Point(12, 12);
            this.pnlFormularioProveedores.Name = "pnlFormularioProveedores";
            this.pnlFormularioProveedores.Size = new System.Drawing.Size(679, 243);
            this.pnlFormularioProveedores.TabIndex = 0;
            // 
            // btnLimpiarProveedor
            // 
            this.btnLimpiarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarProveedor.FlatAppearance.BorderSize = 0;
            this.btnLimpiarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProveedor.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarProveedor.IconSize = 50;
            this.btnLimpiarProveedor.Location = new System.Drawing.Point(582, 172);
            this.btnLimpiarProveedor.Name = "btnLimpiarProveedor";
            this.btnLimpiarProveedor.Size = new System.Drawing.Size(75, 59);
            this.btnLimpiarProveedor.TabIndex = 14;
            this.btnLimpiarProveedor.UseVisualStyleBackColor = true;
            this.btnLimpiarProveedor.Click += new System.EventHandler(this.btnLimpiarProveedor_Click);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarProveedor.FlatAppearance.BorderSize = 0;
            this.btnGuardarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProveedor.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnGuardarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarProveedor.IconSize = 50;
            this.btnGuardarProveedor.Location = new System.Drawing.Point(501, 172);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(75, 59);
            this.btnGuardarProveedor.TabIndex = 13;
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // cbxEstadoProveedor
            // 
            this.cbxEstadoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEstadoProveedor.FormattingEnabled = true;
            this.cbxEstadoProveedor.Location = new System.Drawing.Point(101, 127);
            this.cbxEstadoProveedor.Name = "cbxEstadoProveedor";
            this.cbxEstadoProveedor.Size = new System.Drawing.Size(216, 21);
            this.cbxEstadoProveedor.TabIndex = 12;
            // 
            // lblEstadoProveedor
            // 
            this.lblEstadoProveedor.AutoSize = true;
            this.lblEstadoProveedor.Depth = 0;
            this.lblEstadoProveedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoProveedor.Location = new System.Drawing.Point(18, 129);
            this.lblEstadoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoProveedor.Name = "lblEstadoProveedor";
            this.lblEstadoProveedor.Size = new System.Drawing.Size(60, 19);
            this.lblEstadoProveedor.TabIndex = 11;
            this.lblEstadoProveedor.Text = "Estado:";
            // 
            // chkGastosFijo
            // 
            this.chkGastosFijo.AutoSize = true;
            this.chkGastosFijo.Depth = 0;
            this.chkGastosFijo.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkGastosFijo.Location = new System.Drawing.Point(459, 71);
            this.chkGastosFijo.Margin = new System.Windows.Forms.Padding(0);
            this.chkGastosFijo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkGastosFijo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkGastosFijo.Name = "chkGastosFijo";
            this.chkGastosFijo.Ripple = true;
            this.chkGastosFijo.Size = new System.Drawing.Size(30, 30);
            this.chkGastosFijo.TabIndex = 10;
            this.chkGastosFijo.Text = " ";
            this.chkGastosFijo.UseVisualStyleBackColor = true;
            // 
            // lblProveedorGasto
            // 
            this.lblProveedorGasto.AutoSize = true;
            this.lblProveedorGasto.Depth = 0;
            this.lblProveedorGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProveedorGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProveedorGasto.Location = new System.Drawing.Point(358, 79);
            this.lblProveedorGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProveedorGasto.Name = "lblProveedorGasto";
            this.lblProveedorGasto.Size = new System.Drawing.Size(98, 19);
            this.lblProveedorGasto.TabIndex = 9;
            this.lblProveedorGasto.Text = "Es gasto fijo:";
            // 
            // txtCedulaProveedor
            // 
            this.txtCedulaProveedor.Depth = 0;
            this.txtCedulaProveedor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtCedulaProveedor.Hint = "";
            this.txtCedulaProveedor.Location = new System.Drawing.Point(441, 25);
            this.txtCedulaProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCedulaProveedor.Name = "txtCedulaProveedor";
            this.txtCedulaProveedor.PasswordChar = '\0';
            this.txtCedulaProveedor.SelectedText = "";
            this.txtCedulaProveedor.SelectionLength = 0;
            this.txtCedulaProveedor.SelectionStart = 0;
            this.txtCedulaProveedor.Size = new System.Drawing.Size(216, 23);
            this.txtCedulaProveedor.TabIndex = 8;
            this.txtCedulaProveedor.UseSystemPasswordChar = false;
            // 
            // lblCedulaProveedor
            // 
            this.lblCedulaProveedor.AutoSize = true;
            this.lblCedulaProveedor.Depth = 0;
            this.lblCedulaProveedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCedulaProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCedulaProveedor.Location = new System.Drawing.Point(358, 25);
            this.lblCedulaProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCedulaProveedor.Name = "lblCedulaProveedor";
            this.lblCedulaProveedor.Size = new System.Drawing.Size(59, 19);
            this.lblCedulaProveedor.TabIndex = 7;
            this.lblCedulaProveedor.Text = "Cedula:";
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Depth = 0;
            this.txtTelefonoProveedor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtTelefonoProveedor.Hint = "";
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(101, 75);
            this.txtTelefonoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.PasswordChar = '\0';
            this.txtTelefonoProveedor.SelectedText = "";
            this.txtTelefonoProveedor.SelectionLength = 0;
            this.txtTelefonoProveedor.SelectionStart = 0;
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(216, 23);
            this.txtTelefonoProveedor.TabIndex = 6;
            this.txtTelefonoProveedor.UseSystemPasswordChar = false;            
            // 
            // lblTelefonoProveedor
            // 
            this.lblTelefonoProveedor.AutoSize = true;
            this.lblTelefonoProveedor.Depth = 0;
            this.lblTelefonoProveedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTelefonoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefonoProveedor.Location = new System.Drawing.Point(18, 75);
            this.lblTelefonoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            this.lblTelefonoProveedor.Size = new System.Drawing.Size(73, 19);
            this.lblTelefonoProveedor.TabIndex = 5;
            this.lblTelefonoProveedor.Text = "Telefono:";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Depth = 0;
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtNombreProveedor.Hint = "";
            this.txtNombreProveedor.Location = new System.Drawing.Point(101, 21);
            this.txtNombreProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.PasswordChar = '\0';
            this.txtNombreProveedor.SelectedText = "";
            this.txtNombreProveedor.SelectionLength = 0;
            this.txtNombreProveedor.SelectionStart = 0;
            this.txtNombreProveedor.Size = new System.Drawing.Size(216, 23);
            this.txtNombreProveedor.TabIndex = 4;
            this.txtNombreProveedor.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 21);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Nombre:";
            // 
            // pnlGridProveedores
            // 
            this.pnlGridProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlGridProveedores.Controls.Add(this.dtProveedores);
            this.pnlGridProveedores.Location = new System.Drawing.Point(13, 262);
            this.pnlGridProveedores.Name = "pnlGridProveedores";
            this.pnlGridProveedores.Size = new System.Drawing.Size(678, 358);
            this.pnlGridProveedores.TabIndex = 1;
            // 
            // dtProveedores
            // 
            this.dtProveedores.AllowUserToAddRows = false;
            this.dtProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dtProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtProveedores.Location = new System.Drawing.Point(3, 3);
            this.dtProveedores.Name = "dtProveedores";
            this.dtProveedores.Size = new System.Drawing.Size(672, 352);
            this.dtProveedores.TabIndex = 0;
            this.dtProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeleccionarRegistro);
            // 
            // lblProveedorId
            // 
            this.lblProveedorId.AutoSize = true;
            this.lblProveedorId.Depth = 0;
            this.lblProveedorId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProveedorId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProveedorId.Location = new System.Drawing.Point(362, 134);
            this.lblProveedorId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProveedorId.Name = "lblProveedorId";
            this.lblProveedorId.Size = new System.Drawing.Size(0, 19);
            this.lblProveedorId.TabIndex = 15;
            this.lblProveedorId.Visible = false;
            // 
            // RegistrarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 632);
            this.Controls.Add(this.pnlGridProveedores);
            this.Controls.Add(this.pnlFormularioProveedores);
            this.Name = "RegistrarProveedor";
            this.Text = "RegistrarProveedor";
            this.pnlFormularioProveedores.ResumeLayout(false);
            this.pnlFormularioProveedores.PerformLayout();
            this.pnlGridProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFormularioProveedores;
        private System.Windows.Forms.ComboBox cbxEstadoProveedor;
        private MaterialSkin.Controls.MaterialLabel lblEstadoProveedor;
        private MaterialSkin.Controls.MaterialCheckBox chkGastosFijo;
        private MaterialSkin.Controls.MaterialLabel lblProveedorGasto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCedulaProveedor;
        private MaterialSkin.Controls.MaterialLabel lblCedulaProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefonoProveedor;
        private MaterialSkin.Controls.MaterialLabel lblTelefonoProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProveedor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel pnlGridProveedores;
        private System.Windows.Forms.DataGridView dtProveedores;
        private FontAwesome.Sharp.IconButton btnLimpiarProveedor;
        private FontAwesome.Sharp.IconButton btnGuardarProveedor;
        private MaterialSkin.Controls.MaterialLabel lblProveedorId;
    }
}