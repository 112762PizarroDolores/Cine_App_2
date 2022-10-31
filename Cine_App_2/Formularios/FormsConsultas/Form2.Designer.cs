namespace Cine_App_2.Formularios.FormsConsultas
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPeliculas = new System.Windows.Forms.ComboBox();
            this.cboFunciones = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblFunciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(48, 474);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 37);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Cerrar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.Location = new System.Drawing.Point(44, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 21);
            this.lblTitulo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Película";
            // 
            // cboPeliculas
            // 
            this.cboPeliculas.FormattingEnabled = true;
            this.cboPeliculas.Location = new System.Drawing.Point(222, 150);
            this.cboPeliculas.Name = "cboPeliculas";
            this.cboPeliculas.Size = new System.Drawing.Size(565, 24);
            this.cboPeliculas.TabIndex = 7;
            this.cboPeliculas.SelectedIndexChanged += new System.EventHandler(this.cboPeliculas_SelectedIndexChanged);
            // 
            // cboFunciones
            // 
            this.cboFunciones.FormattingEnabled = true;
            this.cboFunciones.Location = new System.Drawing.Point(222, 204);
            this.cboFunciones.Name = "cboFunciones";
            this.cboFunciones.Size = new System.Drawing.Size(565, 24);
            this.cboFunciones.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 256);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(739, 186);
            this.textBox1.TabIndex = 9;
            // 
            // LblFunciones
            // 
            this.LblFunciones.AutoSize = true;
            this.LblFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFunciones.Location = new System.Drawing.Point(43, 203);
            this.LblFunciones.Name = "LblFunciones";
            this.LblFunciones.Size = new System.Drawing.Size(125, 29);
            this.LblFunciones.TabIndex = 10;
            this.LblFunciones.Text = "Funciones";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine_App_2.Properties.Resources.png_transparent_popcorn_discount_theater_film_cinema_movie_theatre_computer_wallpaper_film_poster_stock_photography;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LblFunciones);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboFunciones);
            this.Controls.Add(this.cboPeliculas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Consulta 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPeliculas;
        private System.Windows.Forms.ComboBox cboFunciones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblFunciones;
    }
}