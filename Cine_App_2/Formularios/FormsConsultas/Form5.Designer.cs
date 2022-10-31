namespace Cine_App_2.Formularios.FormsConsultas
{
    partial class Form5
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.cboVendedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoVenta = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbTickets = new System.Windows.Forms.GroupBox();
            this.LblTipoCliente = new System.Windows.Forms.Label();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.btnRegistrarTicket = new System.Windows.Forms.Button();
            this.lblButacas = new System.Windows.Forms.Label();
            this.cboButacasDisp = new System.Windows.Forms.ComboBox();
            this.lblSalas = new System.Windows.Forms.Label();
            this.lblFunciones = new System.Windows.Forms.Label();
            this.cboFunciones = new System.Windows.Forms.ComboBox();
            this.cboSalas = new System.Windows.Forms.ComboBox();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.gbTickets.SuspendLayout();
            this.gbFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(33, 407);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Cerrar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.Location = new System.Drawing.Point(46, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 16);
            this.lblTitulo.TabIndex = 5;
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(227, 75);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(158, 21);
            this.cboClientes.TabIndex = 6;
            this.cboClientes.UseWaitCursor = true;
            // 
            // cboVendedores
            // 
            this.cboVendedores.FormattingEnabled = true;
            this.cboVendedores.Location = new System.Drawing.Point(14, 75);
            this.cboVendedores.Name = "cboVendedores";
            this.cboVendedores.Size = new System.Drawing.Size(163, 21);
            this.cboVendedores.TabIndex = 7;
            this.cboVendedores.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vendedores";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Clientes";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de venta";
            this.label3.UseWaitCursor = true;
            // 
            // cboTipoVenta
            // 
            this.cboTipoVenta.FormattingEnabled = true;
            this.cboTipoVenta.Location = new System.Drawing.Point(442, 75);
            this.cboTipoVenta.Name = "cboTipoVenta";
            this.cboTipoVenta.Size = new System.Drawing.Size(121, 21);
            this.cboTipoVenta.TabIndex = 10;
            this.cboTipoVenta.UseWaitCursor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(676, 110);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(111, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar factura";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.UseWaitCursor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gbTickets
            // 
            this.gbTickets.BackgroundImage = global::Cine_App_2.Properties.Resources.png_transparent_popcorn_discount_theater_film_cinema_movie_theatre_computer_wallpaper_film_poster_stock_photography;
            this.gbTickets.Controls.Add(this.LblTipoCliente);
            this.gbTickets.Controls.Add(this.cboTipoCliente);
            this.gbTickets.Controls.Add(this.label4);
            this.gbTickets.Controls.Add(this.txPrecio);
            this.gbTickets.Controls.Add(this.btnRegistrarTicket);
            this.gbTickets.Controls.Add(this.lblButacas);
            this.gbTickets.Controls.Add(this.cboButacasDisp);
            this.gbTickets.Controls.Add(this.lblSalas);
            this.gbTickets.Controls.Add(this.lblFunciones);
            this.gbTickets.Controls.Add(this.cboFunciones);
            this.gbTickets.Controls.Add(this.cboSalas);
            this.gbTickets.Location = new System.Drawing.Point(1, 147);
            this.gbTickets.Name = "gbTickets";
            this.gbTickets.Size = new System.Drawing.Size(796, 254);
            this.gbTickets.TabIndex = 20;
            this.gbTickets.TabStop = false;
            this.gbTickets.Text = "Registrar tickets";
            this.gbTickets.UseWaitCursor = true;
            this.gbTickets.Visible = false;
            // 
            // LblTipoCliente
            // 
            this.LblTipoCliente.AutoSize = true;
            this.LblTipoCliente.Location = new System.Drawing.Point(266, 146);
            this.LblTipoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTipoCliente.Name = "LblTipoCliente";
            this.LblTipoCliente.Size = new System.Drawing.Size(78, 13);
            this.LblTipoCliente.TabIndex = 29;
            this.LblTipoCliente.Text = "Tipo de Cliente";
            this.LblTipoCliente.UseWaitCursor = true;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(352, 144);
            this.cboTipoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(92, 21);
            this.cboTipoCliente.TabIndex = 28;
            this.cboTipoCliente.UseWaitCursor = true;
            this.cboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cboTipoCliente_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Precio";
            this.label4.UseWaitCursor = true;
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(582, 116);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(63, 20);
            this.txPrecio.TabIndex = 26;
            this.txPrecio.UseWaitCursor = true;
            this.txPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnRegistrarTicket
            // 
            this.btnRegistrarTicket.Location = new System.Drawing.Point(685, 225);
            this.btnRegistrarTicket.Name = "btnRegistrarTicket";
            this.btnRegistrarTicket.Size = new System.Drawing.Size(111, 23);
            this.btnRegistrarTicket.TabIndex = 22;
            this.btnRegistrarTicket.Text = "Registrar ticket";
            this.btnRegistrarTicket.UseVisualStyleBackColor = true;
            this.btnRegistrarTicket.UseWaitCursor = true;
            this.btnRegistrarTicket.Click += new System.EventHandler(this.btnRegistrarTicket_Click);
            // 
            // lblButacas
            // 
            this.lblButacas.AutoSize = true;
            this.lblButacas.Location = new System.Drawing.Point(456, 92);
            this.lblButacas.Name = "lblButacas";
            this.lblButacas.Size = new System.Drawing.Size(101, 13);
            this.lblButacas.TabIndex = 24;
            this.lblButacas.Text = "Butacas disponibles";
            this.lblButacas.UseWaitCursor = true;
            // 
            // cboButacasDisp
            // 
            this.cboButacasDisp.FormattingEnabled = true;
            this.cboButacasDisp.Location = new System.Drawing.Point(582, 89);
            this.cboButacasDisp.Name = "cboButacasDisp";
            this.cboButacasDisp.Size = new System.Drawing.Size(63, 21);
            this.cboButacasDisp.TabIndex = 23;
            this.cboButacasDisp.UseWaitCursor = true;
            // 
            // lblSalas
            // 
            this.lblSalas.AutoSize = true;
            this.lblSalas.Location = new System.Drawing.Point(37, 144);
            this.lblSalas.Name = "lblSalas";
            this.lblSalas.Size = new System.Drawing.Size(28, 13);
            this.lblSalas.TabIndex = 22;
            this.lblSalas.Text = "Sala";
            this.lblSalas.UseWaitCursor = true;
            // 
            // lblFunciones
            // 
            this.lblFunciones.AutoSize = true;
            this.lblFunciones.Location = new System.Drawing.Point(37, 92);
            this.lblFunciones.Name = "lblFunciones";
            this.lblFunciones.Size = new System.Drawing.Size(56, 13);
            this.lblFunciones.TabIndex = 21;
            this.lblFunciones.Text = "Funciones";
            this.lblFunciones.UseWaitCursor = true;
            // 
            // cboFunciones
            // 
            this.cboFunciones.FormattingEnabled = true;
            this.cboFunciones.Location = new System.Drawing.Point(117, 89);
            this.cboFunciones.Name = "cboFunciones";
            this.cboFunciones.Size = new System.Drawing.Size(285, 21);
            this.cboFunciones.TabIndex = 20;
            this.cboFunciones.UseWaitCursor = true;
            this.cboFunciones.SelectedIndexChanged += new System.EventHandler(this.cboFunciones_SelectedIndexChanged);
            // 
            // cboSalas
            // 
            this.cboSalas.FormattingEnabled = true;
            this.cboSalas.Location = new System.Drawing.Point(117, 136);
            this.cboSalas.Name = "cboSalas";
            this.cboSalas.Size = new System.Drawing.Size(104, 21);
            this.cboSalas.TabIndex = 19;
            this.cboSalas.UseWaitCursor = true;
            // 
            // gbFactura
            // 
            this.gbFactura.BackgroundImage = global::Cine_App_2.Properties.Resources.png_transparent_popcorn_discount_theater_film_cinema_movie_theatre_computer_wallpaper_film_poster_stock_photography;
            this.gbFactura.Controls.Add(this.cboTipoVenta);
            this.gbFactura.Controls.Add(this.cboClientes);
            this.gbFactura.Controls.Add(this.btnRegistrar);
            this.gbFactura.Controls.Add(this.cboVendedores);
            this.gbFactura.Controls.Add(this.label3);
            this.gbFactura.Controls.Add(this.label1);
            this.gbFactura.Controls.Add(this.label2);
            this.gbFactura.Location = new System.Drawing.Point(1, 2);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(796, 139);
            this.gbFactura.TabIndex = 21;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Registrar factura";
            this.gbFactura.UseWaitCursor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine_App_2.Properties.Resources.png_transparent_popcorn_discount_theater_film_cinema_movie_theatre_computer_wallpaper_film_poster_stock_photography;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.gbTickets);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVolver);
            this.Name = "Form5";
            this.Text = "Consulta 5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.gbTickets.ResumeLayout(false);
            this.gbTickets.PerformLayout();
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.ComboBox cboVendedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoVenta;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gbTickets;
        private System.Windows.Forms.Label lblButacas;
        private System.Windows.Forms.ComboBox cboButacasDisp;
        private System.Windows.Forms.Label lblSalas;
        private System.Windows.Forms.Label lblFunciones;
        private System.Windows.Forms.ComboBox cboFunciones;
        private System.Windows.Forms.ComboBox cboSalas;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.Button btnRegistrarTicket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label LblTipoCliente;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}