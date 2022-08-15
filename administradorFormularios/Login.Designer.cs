using AdministradorEntidades.Entidades;

namespace administradorFormularios
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.linklblOlvidoContrasenna = new System.Windows.Forms.LinkLabel();
            this.icnContrasenna = new FontAwesome.Sharp.IconPictureBox();
            this.icnUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.btnMostrarContrasenna = new FontAwesome.Sharp.IconButton();
            this.txtContrasenna = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblContrasenna = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnContrasenna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.linklblOlvidoContrasenna);
            this.panel1.Controls.Add(this.icnContrasenna);
            this.panel1.Controls.Add(this.icnUsuario);
            this.panel1.Controls.Add(this.btnMostrarContrasenna);
            this.panel1.Controls.Add(this.txtContrasenna);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.lblContrasenna);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 219);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.Black;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.Location = new System.Drawing.Point(196, 151);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(99, 52);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linklblOlvidoContrasenna
            // 
            this.linklblOlvidoContrasenna.AutoSize = true;
            this.linklblOlvidoContrasenna.LinkColor = System.Drawing.Color.Black;
            this.linklblOlvidoContrasenna.Location = new System.Drawing.Point(193, 206);
            this.linklblOlvidoContrasenna.Name = "linklblOlvidoContrasenna";
            this.linklblOlvidoContrasenna.Size = new System.Drawing.Size(116, 13);
            this.linklblOlvidoContrasenna.TabIndex = 7;
            this.linklblOlvidoContrasenna.TabStop = true;
            this.linklblOlvidoContrasenna.Text = "¿Olvido la contraseña?";
            // 
            // icnContrasenna
            // 
            this.icnContrasenna.BackColor = System.Drawing.Color.Transparent;
            this.icnContrasenna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icnContrasenna.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.icnContrasenna.IconColor = System.Drawing.SystemColors.ControlText;
            this.icnContrasenna.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnContrasenna.IconSize = 66;
            this.icnContrasenna.Location = new System.Drawing.Point(24, 93);
            this.icnContrasenna.Name = "icnContrasenna";
            this.icnContrasenna.Size = new System.Drawing.Size(66, 67);
            this.icnContrasenna.TabIndex = 6;
            this.icnContrasenna.TabStop = false;
            // 
            // icnUsuario
            // 
            this.icnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.icnUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icnUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.icnUsuario.IconColor = System.Drawing.SystemColors.ControlText;
            this.icnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnUsuario.IconSize = 66;
            this.icnUsuario.Location = new System.Drawing.Point(24, 20);
            this.icnUsuario.Name = "icnUsuario";
            this.icnUsuario.Size = new System.Drawing.Size(66, 67);
            this.icnUsuario.TabIndex = 5;
            this.icnUsuario.TabStop = false;
            // 
            // btnMostrarContrasenna
            // 
            this.btnMostrarContrasenna.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContrasenna.FlatAppearance.BorderSize = 0;
            this.btnMostrarContrasenna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContrasenna.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnMostrarContrasenna.IconColor = System.Drawing.Color.Black;
            this.btnMostrarContrasenna.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrarContrasenna.IconSize = 20;
            this.btnMostrarContrasenna.Location = new System.Drawing.Point(417, 124);
            this.btnMostrarContrasenna.Name = "btnMostrarContrasenna";
            this.btnMostrarContrasenna.Size = new System.Drawing.Size(26, 24);
            this.btnMostrarContrasenna.TabIndex = 4;
            this.btnMostrarContrasenna.UseVisualStyleBackColor = false;
            this.btnMostrarContrasenna.Click += new System.EventHandler(this.btnMostrarContrasenna_Click);
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.Depth = 0;
            this.txtContrasenna.Hint = "";
            this.txtContrasenna.Location = new System.Drawing.Point(196, 122);
            this.txtContrasenna.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.PasswordChar = '\0';
            this.txtContrasenna.SelectedText = "";
            this.txtContrasenna.SelectionLength = 0;
            this.txtContrasenna.SelectionStart = 0;
            this.txtContrasenna.Size = new System.Drawing.Size(215, 23);
            this.txtContrasenna.TabIndex = 3;
            this.txtContrasenna.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(196, 55);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(215, 23);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // lblContrasenna
            // 
            this.lblContrasenna.AutoSize = true;
            this.lblContrasenna.Depth = 0;
            this.lblContrasenna.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblContrasenna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContrasenna.Location = new System.Drawing.Point(87, 126);
            this.lblContrasenna.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContrasenna.Name = "lblContrasenna";
            this.lblContrasenna.Size = new System.Drawing.Size(90, 19);
            this.lblContrasenna.TabIndex = 1;
            this.lblContrasenna.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(96, 59);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 243);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnContrasenna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private FontAwesome.Sharp.IconButton btnMostrarContrasenna;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenna;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialLabel lblContrasenna;
        private FontAwesome.Sharp.IconPictureBox icnContrasenna;
        private FontAwesome.Sharp.IconPictureBox icnUsuario;
        private System.Windows.Forms.LinkLabel linklblOlvidoContrasenna;
        private FontAwesome.Sharp.IconButton btnLogin;

        public Usuario usuarioSesion { get; set; }
    }
}