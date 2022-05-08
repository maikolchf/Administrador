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
            this.btnGuardarProveedor = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarCampos = new FontAwesome.Sharp.IconButton();
            this.pnlFormularioProveedores = new System.Windows.Forms.Panel();
            this.cbxEstadoProveedor = new System.Windows.Forms.ComboBox();
            this.lblEstadoProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.chkGastosFijo = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblProveedorGasto = new MaterialSkin.Controls.MaterialLabel();
            this.btnCedulaProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCedulaProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.btnTelefonoProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTelefonoProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.btnNombreProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pnlGridProveedores = new System.Windows.Forms.Panel();
            this.dtProveedores = new System.Windows.Forms.DataGridView();
            this.pnlFormularioProveedores.SuspendLayout();
            this.pnlGridProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProveedores)).BeginInit();
            this.SuspendLayout();
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
            this.btnGuardarProveedor.Location = new System.Drawing.Point(562, 183);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(95, 57);
            this.btnGuardarProveedor.TabIndex = 1;
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarCampos.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarCampos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(441, 183);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(95, 57);
            this.btnLimpiarCampos.TabIndex = 2;
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // pnlFormularioProveedores
            // 
            this.pnlFormularioProveedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFormularioProveedores.BackColor = System.Drawing.Color.White;
            this.pnlFormularioProveedores.Controls.Add(this.cbxEstadoProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.lblEstadoProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.chkGastosFijo);
            this.pnlFormularioProveedores.Controls.Add(this.lblProveedorGasto);
            this.pnlFormularioProveedores.Controls.Add(this.btnCedulaProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.lblCedulaProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.btnTelefonoProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.lblTelefonoProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.btnNombreProveedor);
            this.pnlFormularioProveedores.Controls.Add(this.materialLabel1);
            this.pnlFormularioProveedores.Controls.Add(this.btnLimpiarCampos);
            this.pnlFormularioProveedores.Controls.Add(this.btnGuardarProveedor);
            this.pnlFormularioProveedores.Location = new System.Drawing.Point(12, 12);
            this.pnlFormularioProveedores.Name = "pnlFormularioProveedores";
            this.pnlFormularioProveedores.Size = new System.Drawing.Size(679, 243);
            this.pnlFormularioProveedores.TabIndex = 0;
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
            this.lblEstadoProveedor.Location = new System.Drawing.Point(18, 130);
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
            // btnCedulaProveedor
            // 
            this.btnCedulaProveedor.Depth = 0;
            this.btnCedulaProveedor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnCedulaProveedor.Hint = "";
            this.btnCedulaProveedor.Location = new System.Drawing.Point(441, 25);
            this.btnCedulaProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCedulaProveedor.Name = "btnCedulaProveedor";
            this.btnCedulaProveedor.PasswordChar = '\0';
            this.btnCedulaProveedor.SelectedText = "";
            this.btnCedulaProveedor.SelectionLength = 0;
            this.btnCedulaProveedor.SelectionStart = 0;
            this.btnCedulaProveedor.Size = new System.Drawing.Size(216, 23);
            this.btnCedulaProveedor.TabIndex = 8;
            this.btnCedulaProveedor.UseSystemPasswordChar = false;
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
            // btnTelefonoProveedor
            // 
            this.btnTelefonoProveedor.Depth = 0;
            this.btnTelefonoProveedor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnTelefonoProveedor.Hint = "";
            this.btnTelefonoProveedor.Location = new System.Drawing.Point(101, 75);
            this.btnTelefonoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTelefonoProveedor.Name = "btnTelefonoProveedor";
            this.btnTelefonoProveedor.PasswordChar = '\0';
            this.btnTelefonoProveedor.SelectedText = "";
            this.btnTelefonoProveedor.SelectionLength = 0;
            this.btnTelefonoProveedor.SelectionStart = 0;
            this.btnTelefonoProveedor.Size = new System.Drawing.Size(216, 23);
            this.btnTelefonoProveedor.TabIndex = 6;
            this.btnTelefonoProveedor.UseSystemPasswordChar = false;
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
            // btnNombreProveedor
            // 
            this.btnNombreProveedor.Depth = 0;
            this.btnNombreProveedor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnNombreProveedor.Hint = "";
            this.btnNombreProveedor.Location = new System.Drawing.Point(101, 21);
            this.btnNombreProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNombreProveedor.Name = "btnNombreProveedor";
            this.btnNombreProveedor.PasswordChar = '\0';
            this.btnNombreProveedor.SelectedText = "";
            this.btnNombreProveedor.SelectionLength = 0;
            this.btnNombreProveedor.SelectionStart = 0;
            this.btnNombreProveedor.Size = new System.Drawing.Size(216, 23);
            this.btnNombreProveedor.TabIndex = 4;
            this.btnNombreProveedor.UseSystemPasswordChar = false;
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
            this.dtProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dtProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProveedores.Location = new System.Drawing.Point(3, 3);
            this.dtProveedores.Name = "dtProveedores";
            this.dtProveedores.Size = new System.Drawing.Size(672, 352);
            this.dtProveedores.TabIndex = 0;
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

        private FontAwesome.Sharp.IconButton btnGuardarProveedor;
        private FontAwesome.Sharp.IconButton btnLimpiarCampos;
        private System.Windows.Forms.Panel pnlFormularioProveedores;
        private System.Windows.Forms.ComboBox cbxEstadoProveedor;
        private MaterialSkin.Controls.MaterialLabel lblEstadoProveedor;
        private MaterialSkin.Controls.MaterialCheckBox chkGastosFijo;
        private MaterialSkin.Controls.MaterialLabel lblProveedorGasto;
        private MaterialSkin.Controls.MaterialSingleLineTextField btnCedulaProveedor;
        private MaterialSkin.Controls.MaterialLabel lblCedulaProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField btnTelefonoProveedor;
        private MaterialSkin.Controls.MaterialLabel lblTelefonoProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField btnNombreProveedor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel pnlGridProveedores;
        private System.Windows.Forms.DataGridView dtProveedores;
    }
}