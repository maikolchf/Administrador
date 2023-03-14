namespace administradorFormularios.CambioContrasenna
{
    partial class NuevaContrasenna
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
            this.lblNuevaContrasenna = new MaterialSkin.Controls.MaterialLabel();
            this.txtNuevaContrasenna = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGuardarNuevaContrasenna = new FontAwesome.Sharp.IconButton();
            this.btnMostrarContrasenna = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblNuevaContrasenna
            // 
            this.lblNuevaContrasenna.AutoSize = true;
            this.lblNuevaContrasenna.Depth = 0;
            this.lblNuevaContrasenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNuevaContrasenna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNuevaContrasenna.Location = new System.Drawing.Point(52, 54);
            this.lblNuevaContrasenna.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNuevaContrasenna.Name = "lblNuevaContrasenna";
            this.lblNuevaContrasenna.Size = new System.Drawing.Size(201, 18);
            this.lblNuevaContrasenna.TabIndex = 0;
            this.lblNuevaContrasenna.Text = "Ingrese su nueva contraseña:";
            // 
            // txtNuevaContrasenna
            // 
            this.txtNuevaContrasenna.Depth = 0;
            this.txtNuevaContrasenna.Hint = "";
            this.txtNuevaContrasenna.Location = new System.Drawing.Point(55, 96);
            this.txtNuevaContrasenna.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNuevaContrasenna.Name = "txtNuevaContrasenna";
            this.txtNuevaContrasenna.PasswordChar = '\0';
            this.txtNuevaContrasenna.SelectedText = "";
            this.txtNuevaContrasenna.SelectionLength = 0;
            this.txtNuevaContrasenna.SelectionStart = 0;
            this.txtNuevaContrasenna.Size = new System.Drawing.Size(350, 23);
            this.txtNuevaContrasenna.TabIndex = 1;
            this.txtNuevaContrasenna.UseSystemPasswordChar = true;
            // 
            // btnGuardarNuevaContrasenna
            // 
            this.btnGuardarNuevaContrasenna.FlatAppearance.BorderSize = 0;
            this.btnGuardarNuevaContrasenna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevaContrasenna.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarNuevaContrasenna.IconColor = System.Drawing.Color.Black;
            this.btnGuardarNuevaContrasenna.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarNuevaContrasenna.IconSize = 50;
            this.btnGuardarNuevaContrasenna.Location = new System.Drawing.Point(208, 144);
            this.btnGuardarNuevaContrasenna.Name = "btnGuardarNuevaContrasenna";
            this.btnGuardarNuevaContrasenna.Size = new System.Drawing.Size(75, 53);
            this.btnGuardarNuevaContrasenna.TabIndex = 2;
            this.btnGuardarNuevaContrasenna.UseVisualStyleBackColor = true;
            this.btnGuardarNuevaContrasenna.Click += new System.EventHandler(this.btnGuardarNuevaContrasenna_Click);
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
            this.btnMostrarContrasenna.Location = new System.Drawing.Point(411, 96);
            this.btnMostrarContrasenna.Name = "btnMostrarContrasenna";
            this.btnMostrarContrasenna.Size = new System.Drawing.Size(26, 24);
            this.btnMostrarContrasenna.TabIndex = 5;
            this.btnMostrarContrasenna.UseVisualStyleBackColor = false;
            this.btnMostrarContrasenna.Click += new System.EventHandler(this.btnMostrarContrasenna_Click);
            // 
            // NuevaContrasenna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 243);
            this.Controls.Add(this.btnMostrarContrasenna);
            this.Controls.Add(this.btnGuardarNuevaContrasenna);
            this.Controls.Add(this.txtNuevaContrasenna);
            this.Controls.Add(this.lblNuevaContrasenna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NuevaContrasenna";
            this.Text = "NuevaContrasenna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblNuevaContrasenna;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNuevaContrasenna;
        private FontAwesome.Sharp.IconButton btnGuardarNuevaContrasenna;
        private FontAwesome.Sharp.IconButton btnMostrarContrasenna;
    }
}