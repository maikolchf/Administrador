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
            this.lblCorreoUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.txtCorreoValidar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnValidarCorreo = new FontAwesome.Sharp.IconButton();
            this.pnlCambioContrasenna.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCambioContrasenna
            // 
            this.pnlCambioContrasenna.Controls.Add(this.btnValidarCorreo);
            this.pnlCambioContrasenna.Controls.Add(this.txtCorreoValidar);
            this.pnlCambioContrasenna.Controls.Add(this.lblCorreoUsuario);
            this.pnlCambioContrasenna.Location = new System.Drawing.Point(12, 12);
            this.pnlCambioContrasenna.Name = "pnlCambioContrasenna";
            this.pnlCambioContrasenna.Size = new System.Drawing.Size(468, 219);
            this.pnlCambioContrasenna.TabIndex = 0;
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
            this.txtCorreoValidar.Size = new System.Drawing.Size(409, 23);
            this.txtCorreoValidar.TabIndex = 1;
            this.txtCorreoValidar.UseSystemPasswordChar = false;
            // 
            // btnValidarCorreo
            // 
            this.btnValidarCorreo.FlatAppearance.BorderSize = 0;
            this.btnValidarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarCorreo.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnValidarCorreo.IconColor = System.Drawing.Color.Black;
            this.btnValidarCorreo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidarCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarCorreo.Location = new System.Drawing.Point(186, 126);
            this.btnValidarCorreo.Name = "btnValidarCorreo";
            this.btnValidarCorreo.Size = new System.Drawing.Size(91, 54);
            this.btnValidarCorreo.TabIndex = 2;
            this.btnValidarCorreo.Text = " Validar";
            this.btnValidarCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidarCorreo.UseVisualStyleBackColor = true;
            this.btnValidarCorreo.Click += new System.EventHandler(this.btnValidarCorreo_Click);
            // 
            // CambioContrasenna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 243);
            this.Controls.Add(this.pnlCambioContrasenna);
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
    }
}