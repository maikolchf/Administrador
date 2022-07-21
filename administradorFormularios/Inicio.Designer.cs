namespace administradorFormularios
{
    partial class Inicio
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnProductosBodega = new FontAwesome.Sharp.IconButton();
            this.btnFacturas = new FontAwesome.Sharp.IconButton();
            this.btnNotasCambio = new FontAwesome.Sharp.IconButton();
            this.btnGastos = new FontAwesome.Sharp.IconButton();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnGraficos = new FontAwesome.Sharp.IconButton();
            this.panelIcono = new System.Windows.Forms.Panel();
            this.panelFomularios = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(97)))), ((int)(((byte)(147)))));
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnProductosBodega);
            this.panelMenu.Controls.Add(this.btnFacturas);
            this.panelMenu.Controls.Add(this.btnNotasCambio);
            this.panelMenu.Controls.Add(this.btnGastos);
            this.panelMenu.Controls.Add(this.btnProveedores);
            this.panelMenu.Controls.Add(this.btnGraficos);
            this.panelMenu.Controls.Add(this.panelIcono);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 671);
            this.panelMenu.TabIndex = 0;
            // 
            // btnProductosBodega
            // 
            this.btnProductosBodega.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductosBodega.FlatAppearance.BorderSize = 0;
            this.btnProductosBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosBodega.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosBodega.ForeColor = System.Drawing.Color.White;
            this.btnProductosBodega.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnProductosBodega.IconColor = System.Drawing.Color.White;
            this.btnProductosBodega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductosBodega.IconSize = 35;
            this.btnProductosBodega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosBodega.Location = new System.Drawing.Point(0, 357);
            this.btnProductosBodega.Name = "btnProductosBodega";
            this.btnProductosBodega.Size = new System.Drawing.Size(238, 50);
            this.btnProductosBodega.TabIndex = 11;
            this.btnProductosBodega.Text = "  Productos en bodega";
            this.btnProductosBodega.UseVisualStyleBackColor = true;
            this.btnProductosBodega.Click += new System.EventHandler(this.btnProductosBodega_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.btnFacturas.IconColor = System.Drawing.Color.White;
            this.btnFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacturas.IconSize = 35;
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(0, 307);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(238, 50);
            this.btnFacturas.TabIndex = 10;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnNotasCambio
            // 
            this.btnNotasCambio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotasCambio.FlatAppearance.BorderSize = 0;
            this.btnNotasCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotasCambio.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotasCambio.ForeColor = System.Drawing.Color.White;
            this.btnNotasCambio.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnNotasCambio.IconColor = System.Drawing.Color.White;
            this.btnNotasCambio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotasCambio.IconSize = 35;
            this.btnNotasCambio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotasCambio.Location = new System.Drawing.Point(0, 257);
            this.btnNotasCambio.Name = "btnNotasCambio";
            this.btnNotasCambio.Size = new System.Drawing.Size(238, 50);
            this.btnNotasCambio.TabIndex = 8;
            this.btnNotasCambio.Text = "Notas de cambio";
            this.btnNotasCambio.UseVisualStyleBackColor = true;
            this.btnNotasCambio.Click += new System.EventHandler(this.btnNotasCambio_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.ForeColor = System.Drawing.Color.White;
            this.btnGastos.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnGastos.IconColor = System.Drawing.Color.White;
            this.btnGastos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGastos.IconSize = 35;
            this.btnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.Location = new System.Drawing.Point(0, 207);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(238, 50);
            this.btnGastos.TabIndex = 7;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnProveedores.IconColor = System.Drawing.Color.White;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 35;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 157);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(238, 50);
            this.btnProveedores.TabIndex = 6;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnGraficos
            // 
            this.btnGraficos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGraficos.FlatAppearance.BorderSize = 0;
            this.btnGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.ForeColor = System.Drawing.Color.White;
            this.btnGraficos.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnGraficos.IconColor = System.Drawing.Color.White;
            this.btnGraficos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGraficos.IconSize = 35;
            this.btnGraficos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficos.Location = new System.Drawing.Point(0, 107);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(238, 50);
            this.btnGraficos.TabIndex = 5;
            this.btnGraficos.Text = "Graficos";
            this.btnGraficos.UseVisualStyleBackColor = true;
            // 
            // panelIcono
            // 
            this.panelIcono.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIcono.Location = new System.Drawing.Point(0, 0);
            this.panelIcono.Name = "panelIcono";
            this.panelIcono.Size = new System.Drawing.Size(238, 107);
            this.panelIcono.TabIndex = 0;
            // 
            // panelFomularios
            // 
            this.panelFomularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFomularios.Location = new System.Drawing.Point(238, 0);
            this.panelFomularios.Name = "panelFomularios";
            this.panelFomularios.Size = new System.Drawing.Size(719, 671);
            this.panelFomularios.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 407);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(238, 50);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "Usuarios";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 457);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(238, 50);
            this.iconButton2.TabIndex = 13;
            this.iconButton2.Text = "Usuarios";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 671);
            this.Controls.Add(this.panelFomularios);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(973, 710);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelIcono;
        private System.Windows.Forms.Panel panelFomularios;
        private FontAwesome.Sharp.IconButton btnFacturas;
        private FontAwesome.Sharp.IconButton btnNotasCambio;
        private FontAwesome.Sharp.IconButton btnGastos;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnGraficos;
        private FontAwesome.Sharp.IconButton btnProductosBodega;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}