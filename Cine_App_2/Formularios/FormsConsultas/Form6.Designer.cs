namespace Cine_App_2.Formularios.FormsConsultas
{
    partial class Form6
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
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboFunciones = new System.Windows.Forms.ComboBox();
            this.LblFunciones = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(192, 276);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.Size = new System.Drawing.Size(627, 185);
            this.dgvResultados.TabIndex = 4;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(41, 496);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Cerrar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.Location = new System.Drawing.Point(56, 94);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 21);
            this.lblTitulo.TabIndex = 5;
            // 
            // cboFunciones
            // 
            this.cboFunciones.FormattingEnabled = true;
            this.cboFunciones.Location = new System.Drawing.Point(208, 135);
            this.cboFunciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFunciones.Name = "cboFunciones";
            this.cboFunciones.Size = new System.Drawing.Size(268, 24);
            this.cboFunciones.TabIndex = 6;
            // 
            // LblFunciones
            // 
            this.LblFunciones.AutoSize = true;
            this.LblFunciones.Location = new System.Drawing.Point(69, 143);
            this.LblFunciones.Name = "LblFunciones";
            this.LblFunciones.Size = new System.Drawing.Size(54, 16);
            this.LblFunciones.TabIndex = 7;
            this.LblFunciones.Text = "Función";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(208, 178);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(268, 22);
            this.dtpDesde.TabIndex = 10;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(627, 178);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(268, 22);
            this.dtpHasta.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha Hasta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine_App_2.Properties.Resources.png_transparent_popcorn_discount_theater_film_cinema_movie_theatre_computer_wallpaper_film_poster_stock_photography;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.LblFunciones);
            this.Controls.Add(this.cboFunciones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "Consulta 6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboFunciones;
        private System.Windows.Forms.Label LblFunciones;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}