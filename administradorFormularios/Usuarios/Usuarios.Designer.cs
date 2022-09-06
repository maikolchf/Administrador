namespace administradorFormularios.Usuarios
{
    partial class Usuarios
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
            this.pnlFormularioUsuario = new System.Windows.Forms.Panel();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.btnMostrarContraseña = new FontAwesome.Sharp.IconButton();
            this.cbxEstadoUsuario = new System.Windows.Forms.ComboBox();
            this.cbxRolUsuario = new System.Windows.Forms.ComboBox();
            this.txtContrasennaUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefonoUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCorreoUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidoDos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidoUno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLimpiarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnGuardarUsuario = new FontAwesome.Sharp.IconButton();
            this.lblEstadoUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblRolUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblContrasennaUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lbltelefonoUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblCorreo = new MaterialSkin.Controls.MaterialLabel();
            this.lblApellidoDos = new MaterialSkin.Controls.MaterialLabel();
            this.lblApellidoUno = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.pnlVistaGridUsuarios = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPaginaUsuario = new System.Windows.Forms.Label();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.chkModificarContrasenna = new MaterialSkin.Controls.MaterialCheckBox();
            this.pnlFormularioUsuario.SuspendLayout();
            this.pnlVistaGridUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormularioUsuario
            // 
            this.pnlFormularioUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFormularioUsuario.Controls.Add(this.chkModificarContrasenna);
            this.pnlFormularioUsuario.Controls.Add(this.lblIdUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.btnMostrarContraseña);
            this.pnlFormularioUsuario.Controls.Add(this.cbxEstadoUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.cbxRolUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.txtContrasennaUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.txtUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.txtTelefonoUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.txtCorreoUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.txtApellidoDos);
            this.pnlFormularioUsuario.Controls.Add(this.txtApellidoUno);
            this.pnlFormularioUsuario.Controls.Add(this.txtNombreUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.btnLimpiarUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.btnGuardarUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.lblEstadoUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.lblRolUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.lblContrasennaUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.lblUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.lbltelefonoUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.lblCorreo);
            this.pnlFormularioUsuario.Controls.Add(this.lblApellidoDos);
            this.pnlFormularioUsuario.Controls.Add(this.lblApellidoUno);
            this.pnlFormularioUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlFormularioUsuario.Location = new System.Drawing.Point(12, 12);
            this.pnlFormularioUsuario.Name = "pnlFormularioUsuario";
            this.pnlFormularioUsuario.Size = new System.Drawing.Size(679, 257);
            this.pnlFormularioUsuario.TabIndex = 0;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(369, 184);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblIdUsuario.TabIndex = 25;
            this.lblIdUsuario.Visible = false;
            // 
            // btnMostrarContraseña
            // 
            this.btnMostrarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarContraseña.FlatAppearance.BorderSize = 0;
            this.btnMostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContraseña.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnMostrarContraseña.IconColor = System.Drawing.Color.Black;
            this.btnMostrarContraseña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrarContraseña.IconSize = 20;
            this.btnMostrarContraseña.Location = new System.Drawing.Point(644, 55);
            this.btnMostrarContraseña.Name = "btnMostrarContraseña";
            this.btnMostrarContraseña.Size = new System.Drawing.Size(35, 19);
            this.btnMostrarContraseña.TabIndex = 24;
            this.btnMostrarContraseña.UseVisualStyleBackColor = true;
            this.btnMostrarContraseña.Click += new System.EventHandler(this.btnMostrarContraseña_Click);
            // 
            // cbxEstadoUsuario
            // 
            this.cbxEstadoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEstadoUsuario.FormattingEnabled = true;
            this.cbxEstadoUsuario.Location = new System.Drawing.Point(489, 135);
            this.cbxEstadoUsuario.Name = "cbxEstadoUsuario";
            this.cbxEstadoUsuario.Size = new System.Drawing.Size(161, 21);
            this.cbxEstadoUsuario.TabIndex = 23;
            // 
            // cbxRolUsuario
            // 
            this.cbxRolUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRolUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRolUsuario.FormattingEnabled = true;
            this.cbxRolUsuario.Location = new System.Drawing.Point(489, 99);
            this.cbxRolUsuario.Name = "cbxRolUsuario";
            this.cbxRolUsuario.Size = new System.Drawing.Size(161, 21);
            this.cbxRolUsuario.TabIndex = 22;
            // 
            // txtContrasennaUsuario
            // 
            this.txtContrasennaUsuario.Depth = 0;
            this.txtContrasennaUsuario.Hint = "";
            this.txtContrasennaUsuario.Location = new System.Drawing.Point(489, 55);
            this.txtContrasennaUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContrasennaUsuario.Name = "txtContrasennaUsuario";
            this.txtContrasennaUsuario.PasswordChar = '\0';
            this.txtContrasennaUsuario.SelectedText = "";
            this.txtContrasennaUsuario.SelectionLength = 0;
            this.txtContrasennaUsuario.SelectionStart = 0;
            this.txtContrasennaUsuario.Size = new System.Drawing.Size(161, 23);
            this.txtContrasennaUsuario.TabIndex = 21;
            this.txtContrasennaUsuario.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(489, 13);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(161, 23);
            this.txtUsuario.TabIndex = 20;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Depth = 0;
            this.txtTelefonoUsuario.Hint = "";
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(167, 170);
            this.txtTelefonoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.PasswordChar = '\0';
            this.txtTelefonoUsuario.SelectedText = "";
            this.txtTelefonoUsuario.SelectionLength = 0;
            this.txtTelefonoUsuario.SelectionStart = 0;
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(161, 23);
            this.txtTelefonoUsuario.TabIndex = 19;
            this.txtTelefonoUsuario.UseSystemPasswordChar = false;
            this.txtTelefonoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoUsuario_KeyPress);
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Depth = 0;
            this.txtCorreoUsuario.Hint = "";
            this.txtCorreoUsuario.Location = new System.Drawing.Point(167, 133);
            this.txtCorreoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.PasswordChar = '\0';
            this.txtCorreoUsuario.SelectedText = "";
            this.txtCorreoUsuario.SelectionLength = 0;
            this.txtCorreoUsuario.SelectionStart = 0;
            this.txtCorreoUsuario.Size = new System.Drawing.Size(161, 23);
            this.txtCorreoUsuario.TabIndex = 18;
            this.txtCorreoUsuario.UseSystemPasswordChar = false;
            // 
            // txtApellidoDos
            // 
            this.txtApellidoDos.Depth = 0;
            this.txtApellidoDos.Hint = "";
            this.txtApellidoDos.Location = new System.Drawing.Point(167, 97);
            this.txtApellidoDos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidoDos.Name = "txtApellidoDos";
            this.txtApellidoDos.PasswordChar = '\0';
            this.txtApellidoDos.SelectedText = "";
            this.txtApellidoDos.SelectionLength = 0;
            this.txtApellidoDos.SelectionStart = 0;
            this.txtApellidoDos.Size = new System.Drawing.Size(161, 23);
            this.txtApellidoDos.TabIndex = 17;
            this.txtApellidoDos.UseSystemPasswordChar = false;
            // 
            // txtApellidoUno
            // 
            this.txtApellidoUno.Depth = 0;
            this.txtApellidoUno.Hint = "";
            this.txtApellidoUno.Location = new System.Drawing.Point(167, 55);
            this.txtApellidoUno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidoUno.Name = "txtApellidoUno";
            this.txtApellidoUno.PasswordChar = '\0';
            this.txtApellidoUno.SelectedText = "";
            this.txtApellidoUno.SelectionLength = 0;
            this.txtApellidoUno.SelectionStart = 0;
            this.txtApellidoUno.Size = new System.Drawing.Size(161, 23);
            this.txtApellidoUno.TabIndex = 16;
            this.txtApellidoUno.UseSystemPasswordChar = false;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Depth = 0;
            this.txtNombreUsuario.Hint = "";
            this.txtNombreUsuario.Location = new System.Drawing.Point(167, 13);
            this.txtNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.SelectionLength = 0;
            this.txtNombreUsuario.SelectionStart = 0;
            this.txtNombreUsuario.Size = new System.Drawing.Size(161, 23);
            this.txtNombreUsuario.TabIndex = 15;
            this.txtNombreUsuario.UseSystemPasswordChar = false;
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarUsuario.FlatAppearance.BorderSize = 0;
            this.btnLimpiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarUsuario.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarUsuario.IconSize = 50;
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(588, 195);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(75, 59);
            this.btnLimpiarUsuario.TabIndex = 14;
            this.btnLimpiarUsuario.UseVisualStyleBackColor = true;
            this.btnLimpiarUsuario.Click += new System.EventHandler(this.btnLimpiarUsuario_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarUsuario.FlatAppearance.BorderSize = 0;
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUsuario.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnGuardarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarUsuario.IconSize = 50;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(507, 195);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 59);
            this.btnGuardarUsuario.TabIndex = 13;
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // lblEstadoUsuario
            // 
            this.lblEstadoUsuario.AutoSize = true;
            this.lblEstadoUsuario.Depth = 0;
            this.lblEstadoUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoUsuario.Location = new System.Drawing.Point(368, 137);
            this.lblEstadoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoUsuario.Name = "lblEstadoUsuario";
            this.lblEstadoUsuario.Size = new System.Drawing.Size(60, 19);
            this.lblEstadoUsuario.TabIndex = 8;
            this.lblEstadoUsuario.Text = "Estado:";
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Depth = 0;
            this.lblRolUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRolUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRolUsuario.Location = new System.Drawing.Point(368, 101);
            this.lblRolUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(115, 19);
            this.lblRolUsuario.TabIndex = 7;
            this.lblRolUsuario.Text = "Rol del Usuario:";
            // 
            // lblContrasennaUsuario
            // 
            this.lblContrasennaUsuario.AutoSize = true;
            this.lblContrasennaUsuario.Depth = 0;
            this.lblContrasennaUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblContrasennaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContrasennaUsuario.Location = new System.Drawing.Point(368, 59);
            this.lblContrasennaUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContrasennaUsuario.Name = "lblContrasennaUsuario";
            this.lblContrasennaUsuario.Size = new System.Drawing.Size(90, 19);
            this.lblContrasennaUsuario.TabIndex = 6;
            this.lblContrasennaUsuario.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(368, 17);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 19);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lbltelefonoUsuario
            // 
            this.lbltelefonoUsuario.AutoSize = true;
            this.lbltelefonoUsuario.Depth = 0;
            this.lbltelefonoUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbltelefonoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltelefonoUsuario.Location = new System.Drawing.Point(16, 174);
            this.lbltelefonoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbltelefonoUsuario.Name = "lbltelefonoUsuario";
            this.lbltelefonoUsuario.Size = new System.Drawing.Size(73, 19);
            this.lbltelefonoUsuario.TabIndex = 4;
            this.lbltelefonoUsuario.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Depth = 0;
            this.lblCorreo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCorreo.Location = new System.Drawing.Point(16, 137);
            this.lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(139, 19);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo electronico:";
            // 
            // lblApellidoDos
            // 
            this.lblApellidoDos.AutoSize = true;
            this.lblApellidoDos.Depth = 0;
            this.lblApellidoDos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblApellidoDos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellidoDos.Location = new System.Drawing.Point(16, 101);
            this.lblApellidoDos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApellidoDos.Name = "lblApellidoDos";
            this.lblApellidoDos.Size = new System.Drawing.Size(128, 19);
            this.lblApellidoDos.TabIndex = 2;
            this.lblApellidoDos.Text = "Segundo apellido:";
            // 
            // lblApellidoUno
            // 
            this.lblApellidoUno.AutoSize = true;
            this.lblApellidoUno.Depth = 0;
            this.lblApellidoUno.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblApellidoUno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellidoUno.Location = new System.Drawing.Point(16, 59);
            this.lblApellidoUno.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApellidoUno.Name = "lblApellidoUno";
            this.lblApellidoUno.Size = new System.Drawing.Size(114, 19);
            this.lblApellidoUno.TabIndex = 1;
            this.lblApellidoUno.Text = "Primer apellido:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Depth = 0;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(16, 17);
            this.lblNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(67, 19);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // pnlVistaGridUsuarios
            // 
            this.pnlVistaGridUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlVistaGridUsuarios.Controls.Add(this.dgvUsuarios);
            this.pnlVistaGridUsuarios.Controls.Add(this.panel3);
            this.pnlVistaGridUsuarios.Location = new System.Drawing.Point(12, 275);
            this.pnlVistaGridUsuarios.Name = "pnlVistaGridUsuarios";
            this.pnlVistaGridUsuarios.Size = new System.Drawing.Size(679, 345);
            this.pnlVistaGridUsuarios.TabIndex = 1;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ShowEditingIcon = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(673, 303);
            this.dgvUsuarios.TabIndex = 4;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeleccionarRegistro);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lblPaginaUsuario);
            this.panel3.Controls.Add(this.btnSiguiente);
            this.panel3.Controls.Add(this.btnAtras);
            this.panel3.Location = new System.Drawing.Point(3, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 33);
            this.panel3.TabIndex = 3;
            // 
            // lblPaginaUsuario
            // 
            this.lblPaginaUsuario.AutoSize = true;
            this.lblPaginaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaUsuario.Location = new System.Drawing.Point(323, 5);
            this.lblPaginaUsuario.Name = "lblPaginaUsuario";
            this.lblPaginaUsuario.Size = new System.Drawing.Size(24, 25);
            this.lblPaginaUsuario.TabIndex = 0;
            this.lblPaginaUsuario.Text = "1";
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
            // chkModificarContrasenna
            // 
            this.chkModificarContrasenna.AutoSize = true;
            this.chkModificarContrasenna.Depth = 0;
            this.chkModificarContrasenna.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkModificarContrasenna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkModificarContrasenna.Location = new System.Drawing.Point(372, 170);
            this.chkModificarContrasenna.Margin = new System.Windows.Forms.Padding(0);
            this.chkModificarContrasenna.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkModificarContrasenna.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkModificarContrasenna.Name = "chkModificarContrasenna";
            this.chkModificarContrasenna.Ripple = true;
            this.chkModificarContrasenna.Size = new System.Drawing.Size(175, 30);
            this.chkModificarContrasenna.TabIndex = 27;
            this.chkModificarContrasenna.Text = "¿Modificar contraseña?";
            this.chkModificarContrasenna.UseVisualStyleBackColor = true;
            this.chkModificarContrasenna.Visible = false;
            this.chkModificarContrasenna.CheckedChanged += new System.EventHandler(this.chkModificarContrasenna_CheckedChanged);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 632);
            this.Controls.Add(this.pnlVistaGridUsuarios);
            this.Controls.Add(this.pnlFormularioUsuario);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.pnlFormularioUsuario.ResumeLayout(false);
            this.pnlFormularioUsuario.PerformLayout();
            this.pnlVistaGridUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormularioUsuario;
        private MaterialSkin.Controls.MaterialLabel lblNombreUsuario;
        private MaterialSkin.Controls.MaterialLabel lblEstadoUsuario;
        private MaterialSkin.Controls.MaterialLabel lblRolUsuario;
        private MaterialSkin.Controls.MaterialLabel lblContrasennaUsuario;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lbltelefonoUsuario;
        private MaterialSkin.Controls.MaterialLabel lblCorreo;
        private MaterialSkin.Controls.MaterialLabel lblApellidoDos;
        private MaterialSkin.Controls.MaterialLabel lblApellidoUno;
        private FontAwesome.Sharp.IconButton btnLimpiarUsuario;
        private FontAwesome.Sharp.IconButton btnGuardarUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasennaUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefonoUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreoUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidoDos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidoUno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreUsuario;
        private System.Windows.Forms.ComboBox cbxEstadoUsuario;
        private System.Windows.Forms.ComboBox cbxRolUsuario;
        private System.Windows.Forms.Panel pnlVistaGridUsuarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPaginaUsuario;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnAtras;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private FontAwesome.Sharp.IconButton btnMostrarContraseña;
        private System.Windows.Forms.Label lblIdUsuario;
        private MaterialSkin.Controls.MaterialCheckBox chkModificarContrasenna;
    }
}