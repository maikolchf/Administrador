namespace administradorFormularios.Gastos
{
    partial class RegistrarGastos
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
            this.pnlFormularioGasto = new System.Windows.Forms.Panel();
            this.btnHabilitarCons = new FontAwesome.Sharp.IconButton();
            this.txtMontoGasto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtConsecutivoGasto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblIdGasto = new System.Windows.Forms.Label();
            this.lblConsecutivoGasto = new MaterialSkin.Controls.MaterialLabel();
            this.btnLimpiarGasto = new FontAwesome.Sharp.IconButton();
            this.btnGuardarGasto = new FontAwesome.Sharp.IconButton();
            this.cbxGastoEstado = new System.Windows.Forms.ComboBox();
            this.lblEstadoGasto = new MaterialSkin.Controls.MaterialLabel();
            this.txtDetalleGasto = new System.Windows.Forms.TextBox();
            this.lblDetalleGasto = new MaterialSkin.Controls.MaterialLabel();
            this.lblNontoGasto = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaVenciGasto = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenciGasto = new MaterialSkin.Controls.MaterialLabel();
            this.cbxProveedorGasto = new System.Windows.Forms.ComboBox();
            this.lblNombreProvGasto = new MaterialSkin.Controls.MaterialLabel();
            this.pnlGridgastos = new System.Windows.Forms.Panel();
            this.dtGastos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.lblPaginaGasto = new System.Windows.Forms.Label();
            this.pnlFormularioGasto.SuspendLayout();
            this.pnlGridgastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGastos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormularioGasto
            // 
            this.pnlFormularioGasto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFormularioGasto.Controls.Add(this.btnHabilitarCons);
            this.pnlFormularioGasto.Controls.Add(this.txtMontoGasto);
            this.pnlFormularioGasto.Controls.Add(this.txtConsecutivoGasto);
            this.pnlFormularioGasto.Controls.Add(this.lblIdGasto);
            this.pnlFormularioGasto.Controls.Add(this.lblConsecutivoGasto);
            this.pnlFormularioGasto.Controls.Add(this.btnLimpiarGasto);
            this.pnlFormularioGasto.Controls.Add(this.btnGuardarGasto);
            this.pnlFormularioGasto.Controls.Add(this.cbxGastoEstado);
            this.pnlFormularioGasto.Controls.Add(this.lblEstadoGasto);
            this.pnlFormularioGasto.Controls.Add(this.txtDetalleGasto);
            this.pnlFormularioGasto.Controls.Add(this.lblDetalleGasto);
            this.pnlFormularioGasto.Controls.Add(this.lblNontoGasto);
            this.pnlFormularioGasto.Controls.Add(this.dtpFechaVenciGasto);
            this.pnlFormularioGasto.Controls.Add(this.lblFechaVenciGasto);
            this.pnlFormularioGasto.Controls.Add(this.cbxProveedorGasto);
            this.pnlFormularioGasto.Controls.Add(this.lblNombreProvGasto);
            this.pnlFormularioGasto.Location = new System.Drawing.Point(12, 12);
            this.pnlFormularioGasto.Name = "pnlFormularioGasto";
            this.pnlFormularioGasto.Size = new System.Drawing.Size(679, 246);
            this.pnlFormularioGasto.TabIndex = 0;
            // 
            // btnHabilitarCons
            // 
            this.btnHabilitarCons.FlatAppearance.BorderSize = 0;
            this.btnHabilitarCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitarCons.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnHabilitarCons.IconColor = System.Drawing.Color.Black;
            this.btnHabilitarCons.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHabilitarCons.IconSize = 15;
            this.btnHabilitarCons.Location = new System.Drawing.Point(387, 59);
            this.btnHabilitarCons.Name = "btnHabilitarCons";
            this.btnHabilitarCons.Size = new System.Drawing.Size(26, 23);
            this.btnHabilitarCons.TabIndex = 19;
            this.btnHabilitarCons.UseVisualStyleBackColor = true;
            this.btnHabilitarCons.Visible = false;
            this.btnHabilitarCons.Click += new System.EventHandler(this.btnHabilitarCons_Click);
            // 
            // txtMontoGasto
            // 
            this.txtMontoGasto.Depth = 0;
            this.txtMontoGasto.Hint = "";
            this.txtMontoGasto.Location = new System.Drawing.Point(181, 140);
            this.txtMontoGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMontoGasto.Name = "txtMontoGasto";
            this.txtMontoGasto.PasswordChar = '\0';
            this.txtMontoGasto.SelectedText = "";
            this.txtMontoGasto.SelectionLength = 0;
            this.txtMontoGasto.SelectionStart = 0;
            this.txtMontoGasto.Size = new System.Drawing.Size(200, 23);
            this.txtMontoGasto.TabIndex = 18;
            this.txtMontoGasto.UseSystemPasswordChar = false;
            this.txtMontoGasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoGasto_KeyPress);
            this.txtMontoGasto.Leave += new System.EventHandler(this.txtMontoGasto_Leave);
            // 
            // txtConsecutivoGasto
            // 
            this.txtConsecutivoGasto.Depth = 0;
            this.txtConsecutivoGasto.Hint = "";
            this.txtConsecutivoGasto.Location = new System.Drawing.Point(181, 59);
            this.txtConsecutivoGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConsecutivoGasto.Name = "txtConsecutivoGasto";
            this.txtConsecutivoGasto.PasswordChar = '\0';
            this.txtConsecutivoGasto.SelectedText = "";
            this.txtConsecutivoGasto.SelectionLength = 0;
            this.txtConsecutivoGasto.SelectionStart = 0;
            this.txtConsecutivoGasto.Size = new System.Drawing.Size(200, 23);
            this.txtConsecutivoGasto.TabIndex = 17;
            this.txtConsecutivoGasto.UseSystemPasswordChar = false;
            this.txtConsecutivoGasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsecutivoGasto_KeyPress);
            // 
            // lblIdGasto
            // 
            this.lblIdGasto.AutoSize = true;
            this.lblIdGasto.Location = new System.Drawing.Point(419, 150);
            this.lblIdGasto.Name = "lblIdGasto";
            this.lblIdGasto.Size = new System.Drawing.Size(0, 13);
            this.lblIdGasto.TabIndex = 16;
            this.lblIdGasto.Visible = false;
            // 
            // lblConsecutivoGasto
            // 
            this.lblConsecutivoGasto.AutoSize = true;
            this.lblConsecutivoGasto.Depth = 0;
            this.lblConsecutivoGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblConsecutivoGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConsecutivoGasto.Location = new System.Drawing.Point(15, 64);
            this.lblConsecutivoGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConsecutivoGasto.Name = "lblConsecutivoGasto";
            this.lblConsecutivoGasto.Size = new System.Drawing.Size(97, 19);
            this.lblConsecutivoGasto.TabIndex = 15;
            this.lblConsecutivoGasto.Text = "Consecutivo:";
            // 
            // btnLimpiarGasto
            // 
            this.btnLimpiarGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarGasto.FlatAppearance.BorderSize = 0;
            this.btnLimpiarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarGasto.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarGasto.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarGasto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarGasto.IconSize = 50;
            this.btnLimpiarGasto.Location = new System.Drawing.Point(592, 171);
            this.btnLimpiarGasto.Name = "btnLimpiarGasto";
            this.btnLimpiarGasto.Size = new System.Drawing.Size(75, 59);
            this.btnLimpiarGasto.TabIndex = 8;
            this.btnLimpiarGasto.UseVisualStyleBackColor = true;
            this.btnLimpiarGasto.Click += new System.EventHandler(this.btnLimpiarGasto_Click);
            // 
            // btnGuardarGasto
            // 
            this.btnGuardarGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarGasto.FlatAppearance.BorderSize = 0;
            this.btnGuardarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarGasto.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarGasto.IconColor = System.Drawing.Color.Black;
            this.btnGuardarGasto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarGasto.IconSize = 50;
            this.btnGuardarGasto.Location = new System.Drawing.Point(511, 171);
            this.btnGuardarGasto.Name = "btnGuardarGasto";
            this.btnGuardarGasto.Size = new System.Drawing.Size(75, 59);
            this.btnGuardarGasto.TabIndex = 7;
            this.btnGuardarGasto.UseVisualStyleBackColor = true;
            this.btnGuardarGasto.Click += new System.EventHandler(this.btnGuardarGasto_Click);
            // 
            // cbxGastoEstado
            // 
            this.cbxGastoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGastoEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxGastoEstado.FormattingEnabled = true;
            this.cbxGastoEstado.Location = new System.Drawing.Point(180, 188);
            this.cbxGastoEstado.MaxDropDownItems = 5;
            this.cbxGastoEstado.Name = "cbxGastoEstado";
            this.cbxGastoEstado.Size = new System.Drawing.Size(201, 21);
            this.cbxGastoEstado.TabIndex = 11;
            // 
            // lblEstadoGasto
            // 
            this.lblEstadoGasto.AutoSize = true;
            this.lblEstadoGasto.Depth = 0;
            this.lblEstadoGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoGasto.Location = new System.Drawing.Point(15, 190);
            this.lblEstadoGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoGasto.Name = "lblEstadoGasto";
            this.lblEstadoGasto.Size = new System.Drawing.Size(60, 19);
            this.lblEstadoGasto.TabIndex = 10;
            this.lblEstadoGasto.Text = "Estado:";
            // 
            // txtDetalleGasto
            // 
            this.txtDetalleGasto.BackColor = System.Drawing.Color.White;
            this.txtDetalleGasto.Location = new System.Drawing.Point(419, 44);
            this.txtDetalleGasto.Multiline = true;
            this.txtDetalleGasto.Name = "txtDetalleGasto";
            this.txtDetalleGasto.Size = new System.Drawing.Size(248, 88);
            this.txtDetalleGasto.TabIndex = 6;
            // 
            // lblDetalleGasto
            // 
            this.lblDetalleGasto.AutoSize = true;
            this.lblDetalleGasto.Depth = 0;
            this.lblDetalleGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalleGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalleGasto.Location = new System.Drawing.Point(415, 22);
            this.lblDetalleGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalleGasto.Name = "lblDetalleGasto";
            this.lblDetalleGasto.Size = new System.Drawing.Size(60, 19);
            this.lblDetalleGasto.TabIndex = 5;
            this.lblDetalleGasto.Text = "Detalle:";
            // 
            // lblNontoGasto
            // 
            this.lblNontoGasto.AutoSize = true;
            this.lblNontoGasto.Depth = 0;
            this.lblNontoGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNontoGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNontoGasto.Location = new System.Drawing.Point(15, 145);
            this.lblNontoGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNontoGasto.Name = "lblNontoGasto";
            this.lblNontoGasto.Size = new System.Drawing.Size(57, 19);
            this.lblNontoGasto.TabIndex = 3;
            this.lblNontoGasto.Text = "Monto:";
            // 
            // dtpFechaVenciGasto
            // 
            this.dtpFechaVenciGasto.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFechaVenciGasto.Location = new System.Drawing.Point(180, 102);
            this.dtpFechaVenciGasto.Name = "dtpFechaVenciGasto";
            this.dtpFechaVenciGasto.Size = new System.Drawing.Size(201, 20);
            this.dtpFechaVenciGasto.TabIndex = 3;
            // 
            // lblFechaVenciGasto
            // 
            this.lblFechaVenciGasto.AutoSize = true;
            this.lblFechaVenciGasto.Depth = 0;
            this.lblFechaVenciGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaVenciGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaVenciGasto.Location = new System.Drawing.Point(15, 104);
            this.lblFechaVenciGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaVenciGasto.Name = "lblFechaVenciGasto";
            this.lblFechaVenciGasto.Size = new System.Drawing.Size(159, 19);
            this.lblFechaVenciGasto.TabIndex = 2;
            this.lblFechaVenciGasto.Text = "Fecha de vencimiento:";
            // 
            // cbxProveedorGasto
            // 
            this.cbxProveedorGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedorGasto.DropDownWidth = 201;
            this.cbxProveedorGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxProveedorGasto.FormattingEnabled = true;
            this.cbxProveedorGasto.Location = new System.Drawing.Point(181, 22);
            this.cbxProveedorGasto.Name = "cbxProveedorGasto";
            this.cbxProveedorGasto.Size = new System.Drawing.Size(200, 21);
            this.cbxProveedorGasto.TabIndex = 1;
            // 
            // lblNombreProvGasto
            // 
            this.lblNombreProvGasto.AutoSize = true;
            this.lblNombreProvGasto.Depth = 0;
            this.lblNombreProvGasto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombreProvGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreProvGasto.Location = new System.Drawing.Point(15, 24);
            this.lblNombreProvGasto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreProvGasto.Name = "lblNombreProvGasto";
            this.lblNombreProvGasto.Size = new System.Drawing.Size(138, 19);
            this.lblNombreProvGasto.TabIndex = 0;
            this.lblNombreProvGasto.Text = "Nombre proveedor:";
            // 
            // pnlGridgastos
            // 
            this.pnlGridgastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlGridgastos.Controls.Add(this.panel1);
            this.pnlGridgastos.Controls.Add(this.dtGastos);
            this.pnlGridgastos.Location = new System.Drawing.Point(13, 264);
            this.pnlGridgastos.Name = "pnlGridgastos";
            this.pnlGridgastos.Size = new System.Drawing.Size(678, 356);
            this.pnlGridgastos.TabIndex = 1;
            // 
            // dtGastos
            // 
            this.dtGastos.AllowUserToAddRows = false;
            this.dtGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGastos.BackgroundColor = System.Drawing.Color.White;
            this.dtGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGastos.Location = new System.Drawing.Point(3, 3);
            this.dtGastos.MultiSelect = false;
            this.dtGastos.Name = "dtGastos";
            this.dtGastos.Size = new System.Drawing.Size(672, 311);
            this.dtGastos.TabIndex = 0;
            this.dtGastos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeleccionarRegistro);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblPaginaGasto);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Location = new System.Drawing.Point(3, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 33);
            this.panel1.TabIndex = 1;
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
            // RegistrarGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 632);
            this.Controls.Add(this.pnlGridgastos);
            this.Controls.Add(this.pnlFormularioGasto);
            this.Name = "RegistrarGastos";
            this.Text = "RegistrarGastos";
            this.pnlFormularioGasto.ResumeLayout(false);
            this.pnlFormularioGasto.PerformLayout();
            this.pnlGridgastos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGastos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormularioGasto;
        private System.Windows.Forms.Panel pnlGridgastos;
        private System.Windows.Forms.ComboBox cbxProveedorGasto;
        private MaterialSkin.Controls.MaterialLabel lblNombreProvGasto;
        private System.Windows.Forms.DateTimePicker dtpFechaVenciGasto;
        private MaterialSkin.Controls.MaterialLabel lblFechaVenciGasto;
        private MaterialSkin.Controls.MaterialLabel lblNontoGasto;
        private System.Windows.Forms.TextBox txtDetalleGasto;
        private MaterialSkin.Controls.MaterialLabel lblDetalleGasto;
        private System.Windows.Forms.DataGridView dtGastos;
        private System.Windows.Forms.ComboBox cbxGastoEstado;
        private MaterialSkin.Controls.MaterialLabel lblEstadoGasto;
        private FontAwesome.Sharp.IconButton btnLimpiarGasto;
        private FontAwesome.Sharp.IconButton btnGuardarGasto;
        private MaterialSkin.Controls.MaterialLabel lblConsecutivoGasto;
        private System.Windows.Forms.Label lblIdGasto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMontoGasto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConsecutivoGasto;
        private FontAwesome.Sharp.IconButton btnHabilitarCons;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnAtras;
        private System.Windows.Forms.Label lblPaginaGasto;
    }
}