namespace administradorFormularios.Perfiles
{
    partial class Perfiles
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
            this.pnlFormularioPerfiles = new System.Windows.Forms.Panel();
            this.txtNombrePerfil = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlPermisosPerfil = new System.Windows.Forms.Panel();
            this.cbxInicio = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbxProveedores = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbxGastos = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbxNotasCambio = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbxFacturas = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbxUsuarios = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbxPerfiles = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPaginaGasto = new System.Windows.Forms.Label();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.pnlFormularioPerfiles.SuspendLayout();
            this.pnlPermisosPerfil.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormularioPerfiles
            // 
            this.pnlFormularioPerfiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFormularioPerfiles.Controls.Add(this.materialLabel1);
            this.pnlFormularioPerfiles.Controls.Add(this.pnlPermisosPerfil);
            this.pnlFormularioPerfiles.Controls.Add(this.txtNombrePerfil);
            this.pnlFormularioPerfiles.Location = new System.Drawing.Point(12, 12);
            this.pnlFormularioPerfiles.Name = "pnlFormularioPerfiles";
            this.pnlFormularioPerfiles.Size = new System.Drawing.Size(679, 214);
            this.pnlFormularioPerfiles.TabIndex = 0;
            // 
            // txtNombrePerfil
            // 
            this.txtNombrePerfil.Depth = 0;
            this.txtNombrePerfil.Hint = "";
            this.txtNombrePerfil.Location = new System.Drawing.Point(108, 12);
            this.txtNombrePerfil.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombrePerfil.Name = "txtNombrePerfil";
            this.txtNombrePerfil.PasswordChar = '\0';
            this.txtNombrePerfil.SelectedText = "";
            this.txtNombrePerfil.SelectionLength = 0;
            this.txtNombrePerfil.SelectionStart = 0;
            this.txtNombrePerfil.Size = new System.Drawing.Size(233, 23);
            this.txtNombrePerfil.TabIndex = 1;
            this.txtNombrePerfil.UseSystemPasswordChar = false;
            // 
            // pnlPermisosPerfil
            // 
            this.pnlPermisosPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlPermisosPerfil.Controls.Add(this.materialLabel2);
            this.pnlPermisosPerfil.Controls.Add(this.cbxPerfiles);
            this.pnlPermisosPerfil.Controls.Add(this.cbxUsuarios);
            this.pnlPermisosPerfil.Controls.Add(this.cbxFacturas);
            this.pnlPermisosPerfil.Controls.Add(this.cbxNotasCambio);
            this.pnlPermisosPerfil.Controls.Add(this.cbxGastos);
            this.pnlPermisosPerfil.Controls.Add(this.cbxProveedores);
            this.pnlPermisosPerfil.Controls.Add(this.cbxInicio);
            this.pnlPermisosPerfil.Location = new System.Drawing.Point(20, 58);
            this.pnlPermisosPerfil.Name = "pnlPermisosPerfil";
            this.pnlPermisosPerfil.Size = new System.Drawing.Size(639, 153);
            this.pnlPermisosPerfil.TabIndex = 2;
            // 
            // cbxInicio
            // 
            this.cbxInicio.AutoSize = true;
            this.cbxInicio.Depth = 0;
            this.cbxInicio.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxInicio.Location = new System.Drawing.Point(13, 42);
            this.cbxInicio.Margin = new System.Windows.Forms.Padding(0);
            this.cbxInicio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxInicio.Name = "cbxInicio";
            this.cbxInicio.Ripple = true;
            this.cbxInicio.Size = new System.Drawing.Size(63, 30);
            this.cbxInicio.TabIndex = 2;
            this.cbxInicio.Text = "Inicio";
            this.cbxInicio.UseVisualStyleBackColor = true;
            // 
            // cbxProveedores
            // 
            this.cbxProveedores.AutoSize = true;
            this.cbxProveedores.Depth = 0;
            this.cbxProveedores.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxProveedores.Location = new System.Drawing.Point(271, 42);
            this.cbxProveedores.Margin = new System.Windows.Forms.Padding(0);
            this.cbxProveedores.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxProveedores.Name = "cbxProveedores";
            this.cbxProveedores.Ripple = true;
            this.cbxProveedores.Size = new System.Drawing.Size(108, 30);
            this.cbxProveedores.TabIndex = 3;
            this.cbxProveedores.Text = "Proveedores";
            this.cbxProveedores.UseVisualStyleBackColor = true;
            // 
            // cbxGastos
            // 
            this.cbxGastos.AutoSize = true;
            this.cbxGastos.Depth = 0;
            this.cbxGastos.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxGastos.Location = new System.Drawing.Point(544, 42);
            this.cbxGastos.Margin = new System.Windows.Forms.Padding(0);
            this.cbxGastos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxGastos.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxGastos.Name = "cbxGastos";
            this.cbxGastos.Ripple = true;
            this.cbxGastos.Size = new System.Drawing.Size(73, 30);
            this.cbxGastos.TabIndex = 4;
            this.cbxGastos.Text = "Gastos";
            this.cbxGastos.UseVisualStyleBackColor = true;
            // 
            // cbxNotasCambio
            // 
            this.cbxNotasCambio.AutoSize = true;
            this.cbxNotasCambio.Depth = 0;
            this.cbxNotasCambio.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxNotasCambio.Location = new System.Drawing.Point(13, 84);
            this.cbxNotasCambio.Margin = new System.Windows.Forms.Padding(0);
            this.cbxNotasCambio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxNotasCambio.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxNotasCambio.Name = "cbxNotasCambio";
            this.cbxNotasCambio.Ripple = true;
            this.cbxNotasCambio.Size = new System.Drawing.Size(117, 30);
            this.cbxNotasCambio.TabIndex = 5;
            this.cbxNotasCambio.Text = "Notas Cambio";
            this.cbxNotasCambio.UseVisualStyleBackColor = true;
            // 
            // cbxFacturas
            // 
            this.cbxFacturas.AutoSize = true;
            this.cbxFacturas.Depth = 0;
            this.cbxFacturas.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxFacturas.Location = new System.Drawing.Point(271, 84);
            this.cbxFacturas.Margin = new System.Windows.Forms.Padding(0);
            this.cbxFacturas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxFacturas.Name = "cbxFacturas";
            this.cbxFacturas.Ripple = true;
            this.cbxFacturas.Size = new System.Drawing.Size(84, 30);
            this.cbxFacturas.TabIndex = 6;
            this.cbxFacturas.Text = "Facturas";
            this.cbxFacturas.UseVisualStyleBackColor = true;
            // 
            // cbxUsuarios
            // 
            this.cbxUsuarios.AutoSize = true;
            this.cbxUsuarios.Depth = 0;
            this.cbxUsuarios.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxUsuarios.Location = new System.Drawing.Point(544, 84);
            this.cbxUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.cbxUsuarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxUsuarios.Name = "cbxUsuarios";
            this.cbxUsuarios.Ripple = true;
            this.cbxUsuarios.Size = new System.Drawing.Size(84, 30);
            this.cbxUsuarios.TabIndex = 7;
            this.cbxUsuarios.Text = "Usuarios";
            this.cbxUsuarios.UseVisualStyleBackColor = true;
            // 
            // cbxPerfiles
            // 
            this.cbxPerfiles.AutoSize = true;
            this.cbxPerfiles.Depth = 0;
            this.cbxPerfiles.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxPerfiles.Location = new System.Drawing.Point(13, 123);
            this.cbxPerfiles.Margin = new System.Windows.Forms.Padding(0);
            this.cbxPerfiles.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxPerfiles.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxPerfiles.Name = "cbxPerfiles";
            this.cbxPerfiles.Ripple = true;
            this.cbxPerfiles.Size = new System.Drawing.Size(77, 30);
            this.cbxPerfiles.TabIndex = 8;
            this.cbxPerfiles.Text = "Perfiles";
            this.cbxPerfiles.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel2.Location = new System.Drawing.Point(9, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(135, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Permisos del perfil";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.dgvPerfiles);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 388);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblPaginaGasto);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAtras);
            this.panel2.Location = new System.Drawing.Point(4, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 33);
            this.panel2.TabIndex = 2;
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
            // dgvPerfiles
            // 
            this.dgvPerfiles.AllowUserToAddRows = false;
            this.dgvPerfiles.AllowUserToDeleteRows = false;
            this.dgvPerfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerfiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPerfiles.BackgroundColor = System.Drawing.Color.White;
            this.dgvPerfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.GridColor = System.Drawing.Color.White;
            this.dgvPerfiles.Location = new System.Drawing.Point(4, 3);
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.Size = new System.Drawing.Size(672, 343);
            this.dgvPerfiles.TabIndex = 3;
            // 
            // Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFormularioPerfiles);
            this.Name = "Perfiles";
            this.Text = "Perfiles";
            this.pnlFormularioPerfiles.ResumeLayout(false);
            this.pnlFormularioPerfiles.PerformLayout();
            this.pnlPermisosPerfil.ResumeLayout(false);
            this.pnlPermisosPerfil.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormularioPerfiles;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombrePerfil;
        private System.Windows.Forms.Panel pnlPermisosPerfil;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckBox cbxPerfiles;
        private MaterialSkin.Controls.MaterialCheckBox cbxUsuarios;
        private MaterialSkin.Controls.MaterialCheckBox cbxFacturas;
        private MaterialSkin.Controls.MaterialCheckBox cbxNotasCambio;
        private MaterialSkin.Controls.MaterialCheckBox cbxGastos;
        private MaterialSkin.Controls.MaterialCheckBox cbxProveedores;
        private MaterialSkin.Controls.MaterialCheckBox cbxInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPaginaGasto;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnAtras;
        private System.Windows.Forms.DataGridView dgvPerfiles;
    }
}