namespace administradorFormularios.CambioContrasenna
{
    partial class CambioContrasenna
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
            this.pnlCambioContrasenna = new System.Windows.Forms.Panel();
            this.txtToken = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblToken = new MaterialSkin.Controls.MaterialLabel();
            this.btnValidarToken = new FontAwesome.Sharp.IconButton();
            this.btnValidarCorreo = new FontAwesome.Sharp.IconButton();
            this.txtCorreoValidar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCorreoUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.pnlCambioContrasenna.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCambioContrasenna
            // 
            this.pnlCambioContrasenna.Controls.Add(this.txtToken);
            this.pnlCambioContrasenna.Controls.Add(this.lblToken);
            this.pnlCambioContrasenna.Controls.Add(this.btnValidarToken);
            this.pnlCambioContrasenna.Controls.Add(this.btnValidarCorreo);
            this.pnlCambioContrasenna.Controls.Add(this.txtCorreoValidar);
            this.pnlCambioContrasenna.Controls.Add(this.lblCorreoUsuario);
            this.pnlCambioContrasenna.Location = new System.Drawing.Point(12, 12);
            this.pnlCambioContrasenna.Name = "pnlCambioContrasenna";
            this.pnlCambioContrasenna.Size = new System.Drawing.Size(468, 219);
            this.pnlCambioContrasenna.TabIndex = 0;
            // 
            // txtToken
            // 
            this.txtToken.Depth = 0;
            this.txtToken.Hint = "";
            this.txtToken.Location = new System.Drawing.Point(29, 160);
            this.txtToken.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtToken.Name = "txtToken";
            this.txtToken.PasswordChar = '\0';
            this.txtToken.SelectedText = "";
            this.txtToken.SelectionLength = 0;
            this.txtToken.SelectionStart = 0;
            this.txtToken.Size = new System.Drawing.Size(280, 23);
            this.txtToken.TabIndex = 5;
            this.txtToken.UseSystemPasswordChar = false;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Depth = 0;
            this.lblToken.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToken.Location = new System.Drawing.Point(25, 129);
            this.lblToken.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(120, 19);
            this.lblToken.TabIndex = 4;
            this.lblToken.Text = "Ingrese el token:";
            // 
            // btnValidarToken
            // 
            this.btnValidarToken.FlatAppearance.BorderSize = 0;
            this.btnValidarToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarToken.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnValidarToken.IconColor = System.Drawing.Color.Black;
            this.btnValidarToken.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidarToken.IconSize = 35;
            this.btnValidarToken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarToken.Location = new System.Drawing.Point(315, 160);
            this.btnValidarToken.Name = "btnValidarToken";
            this.btnValidarToken.Size = new System.Drawing.Size(82, 36);
            this.btnValidarToken.TabIndex = 3;
            this.btnValidarToken.Text = " Validar";
            this.btnValidarToken.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidarToken.UseVisualStyleBackColor = true;
            this.btnValidarToken.Click += new System.EventHandler(this.btnValidarToken_Click);
            // 
            // btnValidarCorreo
            // 
            this.btnValidarCorreo.FlatAppearance.BorderSize = 0;
            this.btnValidarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarCorreo.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btnValidarCorreo.IconColor = System.Drawing.Color.Black;
            this.btnValidarCorreo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidarCorreo.IconSize = 35;
            this.btnValidarCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarCorreo.Location = new System.Drawing.Point(315, 74);
            this.btnValidarCorreo.Name = "btnValidarCorreo";
            this.btnValidarCorreo.Size = new System.Drawing.Size(109, 35);
            this.btnValidarCorreo.TabIndex = 2;
            this.btnValidarCorreo.Text = "Enviar token";
            this.btnValidarCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidarCorreo.UseVisualStyleBackColor = true;
            this.btnValidarCorreo.Click += new System.EventHandler(this.btnValidarCorreo_Click);
            // 
            // txtCorreoValidar
            // 
            this.txtCorreoValidar.Depth = 0;
            this.txtCorreoValidar.Hint = "";
            this.txtCorreoValidar.Location = new System.Drawing.Point(29, 74);
            this.txtCorreoValidar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreoValidar.Name = "txtCorreoValidar";
            this.txtCorreoValidar.PasswordChar = '\0';
            this.txtCorreoValidar.SelectedText = "";
            this.txtCorreoValidar.SelectionLength = 0;
            this.txtCorreoValidar.SelectionStart = 0;
            this.txtCorreoValidar.Size = new System.Drawing.Size(280, 23);
            this.txtCorreoValidar.TabIndex = 1;
            this.txtCorreoValidar.UseSystemPasswordChar = false;
            // 
            // lblCorreoUsuario
            // 
            this.lblCorreoUsuario.AutoSize = true;
            this.lblCorreoUsuario.Depth = 0;
            this.lblCorreoUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCorreoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCorreoUsuario.Location = new System.Drawing.Point(25, 33);
            this.lblCorreoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCorreoUsuario.Name = "lblCorreoUsuario";
            this.lblCorreoUsuario.Size = new System.Drawing.Size(284, 19);
            this.lblCorreoUsuario.TabIndex = 0;
            this.lblCorreoUsuario.Text = "Ingrese el correo electronico del usuario:";
            // 
            // CambioContrasenna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 243);
            this.Controls.Add(this.pnlCambioContrasenna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CambioContrasenna";
            this.Text = "CambioContrasenna";
            this.pnlCambioContrasenna.ResumeLayout(false);
            this.pnlCambioContrasenna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCambioContrasenna;
        private MaterialSkin.Controls.MaterialLabel lblCorreoUsuario;
        private FontAwesome.Sharp.IconButton btnValidarCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreoValidar;
        private FontAwesome.Sharp.IconButton btnValidarToken;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtToken;
        private MaterialSkin.Controls.MaterialLabel lblToken;
    }
}