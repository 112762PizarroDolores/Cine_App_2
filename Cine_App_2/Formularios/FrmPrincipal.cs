using Cine_App_2.Formularios;
using Cine_App_2.Formularios.FormsConsultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Cine_App_2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReserva nuevo = new FrmReserva();
            nuevo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)   
            {
                Application.Exit();
            }
            
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes nuevo = new FrmClientes();
            nuevo.Show();
        }

        //consulta 1
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(); 
            form.descripcion = "Listar los datos de las películas mas vendida en los meses de primavera"+ "\n" +
                "(desde el 21/09 hasta el 21/12 del corriente año.)";
            form.consulta = "select p.nombre, count(t.cod_ticket) 'cantidades vendidas', p.productora, i.nombre as 'idioma' " + 
                "from peliculas p join funciones f on f.cod_pelicula = p.cod_pelicula join idiomas i on i.cod_idioma = p.cod_idioma " +
                "join tickets t on t.COD_FUNCION=f.COD_FUNCION " +
                "where fecha between datefromparts(year(getdate()), 9, 21) and datefromparts(year(getdate()), 12, 21) " +
                "group by p.nombre, p.productora, i.nombre";
            
            form.Show();
        }


        //consulta 2
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.descripcion = "Listar las funciones vigentes con sus respectivos horarios por pelicula.";




            form.consulta = "";
            form.Show();
        }

        //consulta 3
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(); 
            form.descripcion = "Crear una vista que liste el código, nombre, apellido y dirección de clientes que han comprado" + "\n" +
            "en lo que va del mes.";
            form.consulta = "select * from vis_clientes";
            form.Show();
        }

        //consulta 4
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.descripcion = "Crear una vista que permita ver las cantidades vendidas por cada vendedor del mes actual";
            form.consulta = "SELECT * FROM VIS_FACTURA_VENDEDOR_MES_ACTUAL";
            form.Show();
        }

        //consulta 5
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.descripcion = "";
            form.Show();
        }


        //consulta 6
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.descripcion = "Traer importe total y cantidad de entradas vendidas, entre un rango de fechas, por función";
            //form.consulta = "";//FALTA PONER
            form.Show();
        }

        //consulta 7
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.descripcion = "Traer los importes totales, por segmentos (JUBILADOS, MAYORES, MENORES), " + "\n" +
                "para determinado período de fechas.";
            form.nombreSp = "PA_TOTALES_POR_SEGMENTO_POR_PERIODO";
            form.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
