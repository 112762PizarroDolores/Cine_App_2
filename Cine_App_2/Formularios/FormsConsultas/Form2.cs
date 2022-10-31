using Cine_App_2.Datos;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Cine_App_2.Entidades;


namespace Cine_App_2.Formularios.FormsConsultas
{
    public partial class Form2 : Form
    {
        public string descripcion;
        public string consulta;
        public Form2()
        {
            InitializeComponent();
            this.obtenerPeliculas();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = descripcion;
            //this.obtenerPeliculas();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(cboPeliculas.SelectedIndex>0)
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.AddWithValue("@COD_PELICULA", cboPeliculas.SelectedValue);
                DataTable Resultado = ConsultasData.ejecutarSpParams("PA_OBT_SINOPSIS_POR_PELICULAS", comando);
                this.textBox1.Text = Resultado.Rows[0].ItemArray[0].ToString();

                SqlCommand comando2 = new SqlCommand();
                comando2.Parameters.AddWithValue("@IDPELICULA", cboPeliculas.SelectedValue);
                DataTable Funciones = ConsultasData.ejecutarSpParams("PA_FUNCIONES_DISPONIBLES_X_PELI", comando2);
                this.cboFunciones.DataSource = Funciones;
                foreach (DataRow row in Funciones.Rows)
                {
                    this.cboFunciones.ValueMember = "COD_FUNCION";
                    this.cboFunciones.DisplayMember = "NOMBRE";
                }
            }



            //NOS CARGUE FUNCIONES(PA)
        }
        private void obtenerPeliculas()
        {
            
            DataTable result = ConsultasData.obtenerCombo("PA_OBT_PELICULAS_VIGENTES");
                  
            this.cboPeliculas.DataSource = result;
                       
            foreach (DataRow row in result.Rows)
            {
                this.cboPeliculas.ValueMember = "COD_PELICULA";
                this.cboPeliculas.DisplayMember = "NOMBRE";
                
            }
            
        }
    }
}
