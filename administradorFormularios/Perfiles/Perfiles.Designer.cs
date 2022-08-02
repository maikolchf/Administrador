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
            this.lblRolId = new System.Windows.Forms.Label();
            this.cbxEstadoPerfil = new System.Windows.Forms.ComboBox();
            this.lblEstadoPerfil = new MaterialSkin.Controls.MaterialLabel();
            this.btnLimpiarPerfil = new FontAwesome.Sharp.IconButton();
            this.btnGuardarPerfil = new FontAwesome.Sharp.IconButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pnlPermisosPerfil = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.chxPerfiles = new MaterialSkin.Controls.MaterialCheckBox();
            this.chxUsuarios = new MaterialSkin.Controls.MaterialCheckBox();
            this.chxFacturas = new MaterialSkin.Controls.MaterialCheckBox();
            this.chxNotasCambio = new MaterialSkin.Controls.MaterialCheckBox();
            this.chxGastos = new MaterialSkin.Controls.MaterialCheckBox();
            this.chxProveedores = new MaterialSkin.Controls.MaterialCheckBox();
            this.chxInicio = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtNombrePerfil = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPaginaPerfil = new System.Windows.Forms.Label();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.pnlFormularioPerfiles.SuspendLayout();
            this.pnlPermisosPerfil.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormularioPerfiles
            // 
            this.pnlFormularioPerfiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFormularioPerfiles.Controls.Add(this.lblRolId);
            this.pnlFormularioPerfiles.Controls.Add(this.cbxEstadoPerfil);
            this.pnlFormularioPerfiles.Controls.Add(this.lblEstadoPerfil);
            this.pnlFormularioPerfiles.Controls.Add(this.btnLimpiarPerfil);
            this.pnlFormularioPerfiles.Controls.Add(this.btnGuardarPerfil);
            this.pnlFormularioPerfiles.Controls.Add(this.materialLabel1);
            this.pnlFormularioPerfiles.Controls.Add(this.pnlPermisosPerfil);
            this.pnlFormularioPerfiles.Controls.Add(this.txtNombrePerfil);
            this.pnlFormularioPerfiles.Location = new System.Drawing.Point(12, 12);
            this.pnlFormularioPerfiles.Name = "pnlFormularioPerfiles";
            this.pnlFormularioPerfiles.Size = new System.Drawing.Size(679, 276);
            this.pnlFormularioPerfiles.TabIndex = 0;
            // 
            // lblRolId
            // 
            this.lblRolId.AutoSize = true;
            this.lblRolId.Location = new System.Drawing.Point(20, 247);
            this.lblRolId.Name = "lblRolId";
            this.lblRolId.Size = new System.Drawing.Size(0, 13);
            this.lblRolId.TabIndex = 15;
            this.lblRolId.Visible = false;
            // 
            // cbxEstadoPerfil
            // 
            this.cbxEstadoPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEstadoPerfil.FormattingEnabled = true;
            this.cbxEstadoPerfil.Location = new System.Drawing.Point(421, 14);
            this.cbxEstadoPerfil.Name = "cbxEstadoPerfil";
            this.cbxEstadoPerfil.Size = new System.Drawing.Size(237, 21);
            this.cbxEstadoPerfil.TabIndex = 14;
            // 
            // lblEstadoPerfil
            // 
            this.lblEstadoPerfil.AutoSize = true;
            this.lblEstadoPerfil.Depth = 0;
            this.lblEstadoPerfil.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoPerfil.Location = new System.Drawing.Point(355, 16);
            this.lblEstadoPerfil.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoPerfil.Name = "lblEstadoPerfil";
            this.lblEstadoPerfil.Size = new System.Drawing.Size(60, 19);
            this.lblEstadoPerfil.TabIndex = 13;
            this.lblEstadoPerfil.Text = "Estado:";
            // 
            // btnLimpiarPerfil
            // 
            this.btnLimpiarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarPerfil.FlatAppearance.BorderSize = 0;
            this.btnLimpiarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarPerfil.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarPerfil.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarPerfil.IconSize = 50;
            this.btnLimpiarPerfil.Location = new System.Drawing.Point(583, 202);
            this.btnLimpiarPerfil.Name = "btnLimpiarPerfil";
            this.btnLimpiarPerfil.Size = new System.Drawing.Size(75, 59);
            this.btnLimpiarPerfil.TabIndex = 12;
            this.btnLimpiarPerfil.UseVisualStyleBackColor = true;
            this.btnLimpiarPerfil.Click += new System.EventHandler(this.btnLimpiarPerfil_Click);
            // 
            // btnGuardarPerfil
            // 
            this.btnGuardarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarPerfil.FlatAppearance.BorderSize = 0;
            this.btnGuardarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPerfil.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarPerfil.IconColor = System.Drawing.Color.Black;
            this.btnGuardarPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarPerfil.IconSize = 50;
            this.btnGuardarPerfil.Location = new System.Drawing.Point(502, 202);
            this.btnGuardarPerfil.Name = "btnGuardarPerfil";
            this.btnGuardarPerfil.Size = new System.Drawing.Size(75, 59);
            this.btnGuardarPerfil.TabIndex = 11;
            this.btnGuardarPerfil.UseVisualStyleBackColor = true;
            this.btnGuardarPerfil.Click += new System.EventHandler(this.btnGuardarPerfil_Click);
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
            // pnlPermisosPerfil
            // 
            this.pnlPermisosPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlPermisosPerfil.Controls.Add(this.materialLabel2);
            this.pnlPermisosPerfil.Controls.Add(this.chxPerfiles);
            this.pnlPermisosPerfil.Controls.Add(this.chxUsuarios);
            this.pnlPermisosPerfil.Controls.Add(this.chxFacturas);
            this.pnlPermisosPerfil.Controls.Add(this.chxNotasCambio);
            this.pnlPermisosPerfil.Controls.Add(this.chxGastos);
            this.pnlPermisosPerfil.Controls.Add(this.chxProveedores);
            this.pnlPermisosPerfil.Controls.Add(this.chxInicio);
            this.pnlPermisosPerfil.Location = new System.Drawing.Point(20, 58);
            this.pnlPermisosPerfil.Name = "pnlPermisosPerfil";
            this.pnlPermisosPerfil.Size = new System.Drawing.Size(639, 162);
            this.pnlPermisosPerfil.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(135, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Permisos del perfil";
            // 
            // chxPerfiles
            // 
            this.chxPerfiles.AutoSize = true;
            this.chxPerfiles.Depth = 0;
            this.chxPerfiles.Font = new System.Drawing.Font("Roboto", 10F);
            this.chxPerfiles.Location = new System.Drawing.Point(13, 123);
            this.chxPerfiles.Margin = new System.Windows.Forms.Padding(0);
            this.chxPerfiles.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chxPerfiles.MouseState = MaterialSkin.MouseState.HOVER;
            this.chxPerfiles.Name = "chxPerfiles";
            this.chxPerfiles.Ripple = true;
            this.chxPerfiles.Size = new System.Drawing.Size(77, 30);
            this.chxPerfiles.TabIndex = 8;
            this.chxPerfiles.Text = "Perfiles";
            this.chxPerfiles.UseVisualStyleBackColor = true;
            // 
            // chxUsuarios
            // 
            this.chxUsuarios.AutoSize = true;
            this.chxUsuarios.Depth = 0;
            this.chxUsuarios.Font = new System.Drawing.Font("Roboto", 10F);
            this.chxUsuarios.Location = new System.Drawing.Point(544, 84);
            this.chxUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.chxUsuarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chxUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.chxUsuarios.Name = "chxUsuarios";
            this.chxUsuarios.Ripple = true;
            this.chxUsuarios.Size = new System.Drawing.Size(84, 30);
            this.chxUsuarios.TabIndex = 7;
            this.chxUsuarios.Text = "Usuarios";
            this.chxUsuarios.UseVisualStyleBackColor = true;
            // 
            // chxFacturas
            // 
            this.chxFacturas.AutoSize = true;
            this.chxFacturas.Depth = 0;
            this.chxFacturas.Font = new System.Drawing.Font("Roboto", 10F);
            this.chxFacturas.Location = new System.Drawing.Point(271, 84);
            this.chxFacturas.Margin = new System.Windows.Forms.Padding(0);
            this.chxFacturas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chxFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.chxFacturas.Name = "chxFacturas";
            this.chxFacturas.Ripple = true;
            this.chxFacturas.Size = new System.Drawing.Size(84, 30);
            this.chxFacturas.TabIndex = 6;
            this.chxFacturas.Text = "Facturas";
            this.chxFacturas.UseVisualStyleBackColor = true;
            // 
            // chxNotasCambio
            // 
            this.chxNotasCambio.AutoSize = true;
            this.chxNotasCambio.Depth = 0;
            this.chxNotasCambio.Font = new System.Drawing.Font("Roboto", 10F);
            this.chxNotasCambio.Location = new System.Drawing.Point(13, 84);
            this.chxNotasCambio.Margin = new System.Windows.Forms.Padding(0);
            this.chxNotasCambio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chxNotasCambio.MouseState = MaterialSkin.MouseState.HOVER;
            this.chxNotasCambio.Name = "chxNotasCambio";
            this.chxNotasCambio.Ripple = true;
            this.chxNotasCambio.Size = new System.Drawing.Size(117, 30);
            this.chxNotasCambio.TabIndex = 5;
            this.chxNotasCambio.Text = "Notas Cambio";
            this.chxNotasCambio.UseVisualStyleBackColor = true;
            // 
            // chxGastos
            // 
            this.chxGastos.AutoSize = true;
            this.chxGastos.Depth = 0;
            this.chxGastos.Font = new System.Drawing.Font("Roboto", 10F);
            this.chxGastos.Location = new System.Drawing.Point(544, 42);
            this.chxGastos.Margin = new System.Windows.Forms.Padding(0);
            this.chxGastos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chxGastos.MouseState = MaterialSkin.MouseState.HOVER;
            this.chxGastos.Name = "chxGastos";
            this.chxGastos.Ripple = true;
            this.chxGastos.Size = new System.Drawing.Size(73, 30);
            this.chxGastos.TabIndex = 4;
            this.chxGastos.Text = "Gastos";
            this.chxGastos.UseVisualStyleBackColor = true;
            // 
            // chxProveedores
            // 
            this.chxProveedores.AutoSize = true;
            this.chxProveedores.Depth = 0;
            this.chxProveedores.Font = new System.Drawing.Font("Roboto", 10F);
            this.chxProveedores.Location = new System.Drawing.Point(271, 42);
            this.chxProveedores.Margin = new System.Windows.Forms.Padding(0);
            this.chxProveedores.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chxProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.chxProveedores.Name = "chxProveedores";
            this.chxProveedores.Ripple = true;
            this.chxProveedores.Size = new System.Drawing.Size(108, 30);
            this.chxProveedores.TabIndex = 3;
            this.chxProveedores.Text = "Proveedores";
            this.chxProveedores.UseVisualStyleBackColor = true;
            // 
            // chxInicio
            // 
            this.chxInicio.AutoSize = true;
            this.chxInicio.Depth = 0;
            this.chxInicio.Font = new System.Drawing.Font("Roboto", 10F);
            this.chxInicio.Location = new System.Drawing.Point(13, 42);
            this.chxInicio.Margin = new System.Windows.Forms.Padding(0);
            this.chxInicio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chxInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.chxInicio.Name = "chxInicio";
            this.chxInicio.Ripple = true;
            this.chxInicio.Size = new System.Drawing.Size(63, 30);
            this.chxInicio.TabIndex = 2;
            this.chxInicio.Text = "Inicio";
            this.chxInicio.UseVisualStyleBackColor = true;
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
            this.txtNombrePerfil.Size = new System.Drawing.Size(220, 23);
            this.txtNombrePerfil.TabIndex = 1;
            this.txtNombrePerfil.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.dgvPerfiles);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 326);
            this.panel1.TabIndex = 1;
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
            this.dgvPerfiles.Size = new System.Drawing.Size(672, 281);
            this.dgvPerfiles.TabIndex = 3;
            this.dgvPerfiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeleccionarRegistro);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblPaginaPerfil);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAtras);
            this.panel2.Location = new System.Drawing.Point(4, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 33);
            this.panel2.TabIndex = 2;
            // 
            // lblPaginaPerfil
            // 
            this.lblPaginaPerfil.AutoSize = true;
            this.lblPaginaPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaPerfil.Location = new System.Drawing.Point(323, 5);
            this.lblPaginaPerfil.Name = "lblPaginaPerfil";
            this.lblPaginaPerfil.Size = new System.Drawing.Size(24, 25);
            this.lblPaginaPerfil.TabIndex = 0;
            this.lblPaginaPerfil.Text = "1";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormularioPerfiles;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombrePerfil;
        private System.Windows.Forms.Panel pnlPermisosPerfil;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckBox chxPerfiles;
        private MaterialSkin.Controls.MaterialCheckBox chxUsuarios;
        private MaterialSkin.Controls.MaterialCheckBox chxFacturas;
        private MaterialSkin.Controls.MaterialCheckBox chxNotasCambio;
        private MaterialSkin.Controls.MaterialCheckBox chxGastos;
        private MaterialSkin.Controls.MaterialCheckBox chxProveedores;
        private MaterialSkin.Controls.MaterialCheckBox chxInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPaginaPerfil;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnAtras;
        private System.Windows.Forms.DataGridView dgvPerfiles;
        private FontAwesome.Sharp.IconButton btnLimpiarPerfil;
        private FontAwesome.Sharp.IconButton btnGuardarPerfil;
        private System.Windows.Forms.ComboBox cbxEstadoPerfil;
        private MaterialSkin.Controls.MaterialLabel lblEstadoPerfil;
        private System.Windows.Forms.Label lblRolId;
    }
}