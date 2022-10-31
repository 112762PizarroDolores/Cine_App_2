namespace Cine_App_2.Formularios
{
    partial class FrmPago
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
            this.rbtNoAplica = new System.Windows.Forms.RadioButton();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.rbtJubilado = new System.Windows.Forms.RadioButton();
            this.rbtMenor = new System.Windows.Forms.RadioButton();
            this.rbtEstudiante = new System.Windows.Forms.RadioButton();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtNoAplica
            // 
            this.rbtNoAplica.AutoSize = true;
            this.rbtNoAplica.BackColor = System.Drawing.Color.Transparent;
            this.rbtNoAplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNoAplica.Location = new System.Drawing.Point(33, 202);
            this.rbtNoAplica.Name = "rbtNoAplica";
            this.rbtNoAplica.Size = new System.Drawing.Size(86, 19);
            this.rbtNoAplica.TabIndex = 0;
            this.rbtNoAplica.Text = "No Aplica";
            this.rbtNoAplica.UseVisualStyleBackColor = false;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.BackColor = System.Drawing.Color.Transparent;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(30, 171);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(81, 16);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Descuento";
            // 
            // rbtJubilado
            // 
            this.rbtJubilado.AutoSize = true;
            this.rbtJubilado.BackColor = System.Drawing.Color.Transparent;
            this.rbtJubilado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtJubilado.Location = new System.Drawing.Point(33, 252);
            this.rbtJubilado.Name = "rbtJubilado";
            this.rbtJubilado.Size = new System.Drawing.Size(80, 19);
            this.rbtJubilado.TabIndex = 2;
            this.rbtJubilado.Text = "Jubilado";
            this.rbtJubilado.UseVisualStyleBackColor = false;
            // 
            // rbtMenor
            // 
            this.rbtMenor.AutoSize = true;
            this.rbtMenor.BackColor = System.Drawing.Color.Transparent;
            this.rbtMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMenor.Location = new System.Drawing.Point(33, 277);
            this.rbtMenor.Name = "rbtMenor";
            this.rbtMenor.Size = new System.Drawing.Size(66, 19);
            this.rbtMenor.TabIndex = 3;
            this.rbtMenor.Text = "Menor";
            this.rbtMenor.UseVisualStyleBackColor = false;
            // 
            // rbtEstudiante
            // 
            this.rbtEstudiante.AutoSize = true;
            this.rbtEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.rbtEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEstudiante.Location = new System.Drawing.Point(33, 227);
            this.rbtEstudiante.Name = "rbtEstudiante";
            this.rbtEstudiante.Size = new System.Drawing.Size(93, 19);
            this.rbtEstudiante.TabIndex = 4;
            this.rbtEstudiante.Text = "Estudiante";
            this.rbtEstudiante.UseVisualStyleBackColor = false;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(27, 34);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(122, 16);
            this.lblMetodoPago.TabIndex = 5;
            this.lblMetodoPago.Text = "Metodo de Pago";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(465, 427);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine_App_2.Properties.Resources._00f1e2c2002ad8612e0384e951b754541;
            this.ClientSize = new System.Drawing.Size(562, 484);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.rbtEstudiante);
            this.Controls.Add(this.rbtMenor);
            this.Controls.Add(this.rbtJubilado);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.rbtNoAplica);
            this.Name = "FrmPago";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtNoAplica;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.RadioButton rbtJubilado;
        private System.Windows.Forms.RadioButton rbtMenor;
        private System.Windows.Forms.RadioButton rbtEstudiante;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}