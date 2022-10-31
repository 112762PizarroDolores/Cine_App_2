using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_App_2.Formularios
{
    public partial class FrmReserva : Form
    {
        private bool Reserva1, Reserva2, Reserva3, Reserva4, Reserva5, Reserva6, Reserva7, Reserva8, Reserva9, Reserva10,
        Reserva11, Reserva12, Reserva13, Reserva14, Reserva15,Reserva16, Reserva17, Reserva18, Reserva19, Reserva20,
        Reserva21, Reserva22, Reserva23, Reserva24, Reserva25,Reserva26, Reserva27, Reserva28, Reserva29, Reserva30 = false;

        private int contador = 0;
        //cambiar cada uno su path
        private string myPath = @"C:\Users\santi\desktop\";
        private string pathImg = @"Cine_App_2\Cine_App_2\Resources\Otra_Butaca_111.png";
        private string pathImgD = @"Cine_App_2\Cine_App_2\Resources\Otra_Butaca.png";
        public FrmReserva()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FrmPago nuevo = new FrmPago();
            nuevo.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Reserva1 == false)
            {
                pictureBox1.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva1 = !Reserva1;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox1.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva1 = !Reserva1;
                lblnumeroAsientos.Text = contador.ToString();
            }
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Reserva2 == false)
            {
                pictureBox4.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva2 = !Reserva2;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox4.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva2 = !Reserva2;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Reserva3 == false)
            {
                pictureBox2.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva3 = !Reserva3;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox2.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva3 = !Reserva3;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Reserva4 == false)
            {
                pictureBox7.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva4 = !Reserva4;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox7.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva4 = !Reserva4;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (Reserva5 == false)
            {
                pictureBox13.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva5 = !Reserva5;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox13.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva5 = !Reserva5;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (Reserva6 == false)
            {
                pictureBox20.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva6 = !Reserva6;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox20.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva6 = !Reserva6;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Reserva7 == false)
            {
                pictureBox5.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva7 = !Reserva7;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox5.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva7 = !Reserva7;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Reserva8 == false)
            {
                pictureBox3.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva8 = !Reserva8;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox3.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva8 = !Reserva8;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (Reserva9 == false)
            {
                pictureBox17.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva9 = !Reserva9;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox17.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva9 = !Reserva9;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (Reserva10 == false)
            {
                pictureBox12.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva10 = !Reserva10;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox12.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva10 = !Reserva10;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (Reserva11 == false)
            {
                pictureBox19.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva11 = !Reserva11;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox19.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva11 = !Reserva11;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (Reserva12 == false)
            {
                pictureBox18.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva12 = !Reserva12;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox18.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva12 = !Reserva12;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (Reserva13 == false)
            {
                pictureBox14.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva13 = !Reserva13;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox14.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva13 = !Reserva13;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (Reserva14 == false)
            {
                pictureBox15.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva14 = !Reserva14;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox15.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva14 = !Reserva14;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (Reserva15 == false)
            {
                pictureBox16.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva15 = !Reserva15;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox16.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva15 = !Reserva15;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (Reserva16 == false)
            {
                pictureBox11.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva16 = !Reserva16;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox11.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva16 = !Reserva16;
                lblnumeroAsientos.Text = contador.ToString();
            }

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (Reserva17 == false)
            {
                pictureBox27.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva17 = !Reserva17;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox27.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva17 = !Reserva17;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (Reserva18 == false)
            {
                pictureBox26.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva18 = !Reserva18;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox26.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva18 = !Reserva18;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Reserva19 == false)
            {
                pictureBox6.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva19 = !Reserva19;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox6.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva19 = !Reserva19;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Reserva20 == false)
            {
                pictureBox8.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva20 = !Reserva20;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox8.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva20 = !Reserva20;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (Reserva21 == false)
            {
                pictureBox9.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva21 = !Reserva21;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox9.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva21 = !Reserva21;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (Reserva22 == false)
            {
                pictureBox10.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva22 = !Reserva22;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox10.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva22 = !Reserva22;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (Reserva23 == false)
            {
                pictureBox25.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva23 = !Reserva23;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox25.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva23 = !Reserva23;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (Reserva24 == false)
            {
                pictureBox24.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva24 = !Reserva24;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox24.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva24 = !Reserva24;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (Reserva25 == false)
            {
                pictureBox21.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva25 = !Reserva25;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox21.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva25 = !Reserva25;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (Reserva26 == false)
            {
                pictureBox23.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva26 = !Reserva26;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox23.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva26 = !Reserva26;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (Reserva27 == false)
            {
                pictureBox22.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva27 = !Reserva27;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox22.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva27 = !Reserva27;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (Reserva28 == false)
            {
                pictureBox30.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva28 = !Reserva28;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox30.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva28 = !Reserva28;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            if (Reserva29 == false)
            {
                pictureBox29.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva29 = !Reserva29;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox29.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva29 = !Reserva29;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (Reserva30 == false)
            {
                pictureBox28.Image = new Bitmap(myPath + pathImg);
                contador++;
                Reserva30 = !Reserva30;
                lblnumeroAsientos.Text = contador.ToString();

            }
            else
            {
                pictureBox28.Image = new Bitmap(myPath + pathImgD);
                contador--;
                Reserva30 = !Reserva30;
                lblnumeroAsientos.Text = contador.ToString();
            }
        }

        private void FrmReserva_Load(object sender, EventArgs e)
        {

        }
      
    }
    
}
