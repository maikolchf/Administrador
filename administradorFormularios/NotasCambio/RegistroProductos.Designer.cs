namespace administradorFormularios.NotasCambio
{
    partial class RegistroProductos
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
            this.PnlFormularioProductos = new System.Windows.Forms.Panel();
            this.btnLimpiarProducto = new FontAwesome.Sharp.IconButton();
            this.btnGuardarProducto = new FontAwesome.Sharp.IconButton();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProductos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblPrecioProducto = new MaterialSkin.Controls.MaterialLabel();
            this.txtCantidadProductos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCantidadProductos = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigoProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCodigoProducto = new MaterialSkin.Controls.MaterialLabel();
            this.pnlGripProductos = new System.Windows.Forms.Panel();
            this.dtProductos = new System.Windows.Forms.DataGridView();
            this.PnlFormularioProductos.SuspendLayout();
            this.pnlGripProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlFormularioProductos
            // 
            this.PnlFormularioProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlFormularioProductos.BackColor = System.Drawing.Color.White;
            this.PnlFormularioProductos.Controls.Add(this.btnLimpiarProducto);
            this.PnlFormularioProductos.Controls.Add(this.btnGuardarProducto);
            this.PnlFormularioProductos.Controls.Add(this.txtDescripcionProducto);
            this.PnlFormularioProductos.Controls.Add(this.lblDescripcion);
            this.PnlFormularioProductos.Controls.Add(this.txtNombreProducto);
            this.PnlFormularioProductos.Controls.Add(this.txtPrecioProductos);
            this.PnlFormularioProductos.Controls.Add(this.lblPrecioProducto);
            this.PnlFormularioProductos.Controls.Add(this.txtCantidadProductos);
            this.PnlFormularioProductos.Controls.Add(this.lblCantidadProductos);
            this.PnlFormularioProductos.Controls.Add(this.materialLabel1);
            this.PnlFormularioProductos.Controls.Add(this.txtCodigoProducto);
            this.PnlFormularioProductos.Controls.Add(this.lblCodigoProducto);
            this.PnlFormularioProductos.Location = new System.Drawing.Point(12, 12);
            this.PnlFormularioProductos.Name = "PnlFormularioProductos";
            this.PnlFormularioProductos.Size = new System.Drawing.Size(679, 265);
            this.PnlFormularioProductos.TabIndex = 0;
            this.PnlFormularioProductos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarProducto.FlatAppearance.BorderSize = 0;
            this.btnLimpiarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProducto.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarProducto.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarProducto.IconSize = 50;
            this.btnLimpiarProducto.Location = new System.Drawing.Point(586, 203);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(75, 59);
            this.btnLimpiarProducto.TabIndex = 12;
            this.btnLimpiarProducto.UseVisualStyleBackColor = true;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarProducto.IconColor = System.Drawing.Color.Black;
            this.btnGuardarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarProducto.IconSize = 50;
            this.btnGuardarProducto.Location = new System.Drawing.Point(505, 203);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(75, 59);
            this.btnGuardarProducto.TabIndex = 11;
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.BackColor = System.Drawing.Color.White;
            this.txtDescripcionProducto.Location = new System.Drawing.Point(124, 136);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(537, 61);
            this.txtDescripcionProducto.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Depth = 0;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcion.Location = new System.Drawing.Point(21, 135);
            this.lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(93, 19);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.White;
            this.txtNombreProducto.Location = new System.Drawing.Point(365, 56);
            this.txtNombreProducto.Multiline = true;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(296, 61);
            this.txtNombreProducto.TabIndex = 8;
            // 
            // txtPrecioProductos
            // 
            this.txtPrecioProductos.Depth = 0;
            this.txtPrecioProductos.Hint = "";
            this.txtPrecioProductos.Location = new System.Drawing.Point(110, 94);
            this.txtPrecioProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioProductos.Name = "txtPrecioProductos";
            this.txtPrecioProductos.PasswordChar = '\0';
            this.txtPrecioProductos.SelectedText = "";
            this.txtPrecioProductos.SelectionLength = 0;
            this.txtPrecioProductos.SelectionStart = 0;
            this.txtPrecioProductos.Size = new System.Drawing.Size(214, 23);
            this.txtPrecioProductos.TabIndex = 7;
            this.txtPrecioProductos.UseSystemPasswordChar = false;
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Depth = 0;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPrecioProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrecioProducto.Location = new System.Drawing.Point(21, 98);
            this.lblPrecioProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(56, 19);
            this.lblPrecioProducto.TabIndex = 6;
            this.lblPrecioProducto.Text = "Precio:";
            // 
            // txtCantidadProductos
            // 
            this.txtCantidadProductos.Depth = 0;
            this.txtCantidadProductos.Hint = "";
            this.txtCantidadProductos.Location = new System.Drawing.Point(110, 56);
            this.txtCantidadProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidadProductos.Name = "txtCantidadProductos";
            this.txtCantidadProductos.PasswordChar = '\0';
            this.txtCantidadProductos.SelectedText = "";
            this.txtCantidadProductos.SelectionLength = 0;
            this.txtCantidadProductos.SelectionStart = 0;
            this.txtCantidadProductos.Size = new System.Drawing.Size(214, 23);
            this.txtCantidadProductos.TabIndex = 5;
            this.txtCantidadProductos.UseSystemPasswordChar = false;
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.Depth = 0;
            this.lblCantidadProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCantidadProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCantidadProductos.Location = new System.Drawing.Point(21, 60);
            this.lblCantidadProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(72, 19);
            this.lblCantidadProductos.TabIndex = 4;
            this.lblCantidadProductos.Text = "Cantidad:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(361, 18);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(132, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Nombre Producto:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Depth = 0;
            this.txtCodigoProducto.Hint = "";
            this.txtCodigoProducto.Location = new System.Drawing.Point(110, 14);
            this.txtCodigoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.PasswordChar = '\0';
            this.txtCodigoProducto.SelectedText = "";
            this.txtCodigoProducto.SelectionLength = 0;
            this.txtCodigoProducto.SelectionStart = 0;
            this.txtCodigoProducto.Size = new System.Drawing.Size(214, 23);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.UseSystemPasswordChar = false;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Depth = 0;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCodigoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigoProducto.Location = new System.Drawing.Point(21, 18);
            this.lblCodigoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(61, 19);
            this.lblCodigoProducto.TabIndex = 0;
            this.lblCodigoProducto.Text = "Codigo:";
            // 
            // pnlGripProductos
            // 
            this.pnlGripProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlGripProductos.Controls.Add(this.dtProductos);
            this.pnlGripProductos.Location = new System.Drawing.Point(13, 284);
            this.pnlGripProductos.Name = "pnlGripProductos";
            this.pnlGripProductos.Size = new System.Drawing.Size(678, 336);
            this.pnlGripProductos.TabIndex = 1;
            // 
            // dtProductos
            // 
            this.dtProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtProductos.BackgroundColor = System.Drawing.Color.White;
            this.dtProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProductos.Location = new System.Drawing.Point(3, 3);
            this.dtProductos.Name = "dtProductos";
            this.dtProductos.Size = new System.Drawing.Size(672, 330);
            this.dtProductos.TabIndex = 0;
            // 
            // RegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 632);
            this.Controls.Add(this.pnlGripProductos);
            this.Controls.Add(this.PnlFormularioProductos);
            this.Name = "RegistroProductos";
            this.Text = "RegistroProductos";
            this.PnlFormularioProductos.ResumeLayout(false);
            this.PnlFormularioProductos.PerformLayout();
            this.pnlGripProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFormularioProductos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoProducto;
        private MaterialSkin.Controls.MaterialLabel lblCodigoProducto;
        private FontAwesome.Sharp.IconButton btnLimpiarProducto;
        private FontAwesome.Sharp.IconButton btnGuardarProducto;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioProductos;
        private MaterialSkin.Controls.MaterialLabel lblPrecioProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidadProductos;
        private MaterialSkin.Controls.MaterialLabel lblCantidadProductos;
        private System.Windows.Forms.Panel pnlGripProductos;
        private System.Windows.Forms.DataGridView dtProductos;
    }
}