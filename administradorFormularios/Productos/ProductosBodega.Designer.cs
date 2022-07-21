namespace administradorFormularios.Productos
{
    partial class ProductosBodega
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
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPaginaGasto = new System.Windows.Forms.Label();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.lblCodigo = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigoProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNombreProducto = new MaterialSkin.Controls.MaterialLabel();
            this.dgvProductosBodega = new System.Windows.Forms.DataGridView();
            this.pnlFiltro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFiltro.Controls.Add(this.txtNombreProducto);
            this.pnlFiltro.Controls.Add(this.lblNombreProducto);
            this.pnlFiltro.Controls.Add(this.txtCodigoProducto);
            this.pnlFiltro.Controls.Add(this.lblCodigo);
            this.pnlFiltro.Location = new System.Drawing.Point(12, 12);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(679, 71);
            this.pnlFiltro.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.dgvProductosBodega);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 531);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblPaginaGasto);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAtras);
            this.panel2.Location = new System.Drawing.Point(3, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 33);
            this.panel2.TabIndex = 3;
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
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Depth = 0;
            this.lblCodigo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigo.Location = new System.Drawing.Point(3, 23);
            this.lblCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Depth = 0;
            this.txtCodigoProducto.Hint = "";
            this.txtCodigoProducto.Location = new System.Drawing.Point(134, 23);
            this.txtCodigoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.PasswordChar = '\0';
            this.txtCodigoProducto.SelectedText = "";
            this.txtCodigoProducto.SelectionLength = 0;
            this.txtCodigoProducto.SelectionStart = 0;
            this.txtCodigoProducto.Size = new System.Drawing.Size(199, 23);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.UseSystemPasswordChar = false;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Hint = "";
            this.txtNombreProducto.Location = new System.Drawing.Point(473, 23);
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(199, 23);
            this.txtNombreProducto.TabIndex = 3;
            this.txtNombreProducto.UseSystemPasswordChar = false;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Depth = 0;
            this.lblNombreProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreProducto.Location = new System.Drawing.Point(354, 23);
            this.lblNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(67, 19);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // dgvProductosBodega
            // 
            this.dgvProductosBodega.AllowUserToAddRows = false;
            this.dgvProductosBodega.AllowUserToDeleteRows = false;
            this.dgvProductosBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosBodega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosBodega.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosBodega.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosBodega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosBodega.GridColor = System.Drawing.Color.White;
            this.dgvProductosBodega.Location = new System.Drawing.Point(3, 3);
            this.dgvProductosBodega.Name = "dgvProductosBodega";
            this.dgvProductosBodega.Size = new System.Drawing.Size(672, 486);
            this.dgvProductosBodega.TabIndex = 4;
            // 
            // ProductosBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFiltro);
            this.Name = "ProductosBodega";
            this.Text = "ProductosBodega";
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBodega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPaginaGasto;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnAtras;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
        private MaterialSkin.Controls.MaterialLabel lblNombreProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoProducto;
        private MaterialSkin.Controls.MaterialLabel lblCodigo;
        private System.Windows.Forms.DataGridView dgvProductosBodega;
    }
}