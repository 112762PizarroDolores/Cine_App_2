using Cine_App_2.Datos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Cine_App_2.Formularios.FormsConsultas
{
    public partial class Form6 : Form
    {
        public string descripcion;
        public string nombreSp;
        public Form6()
        {
            InitializeComponent();
            obtenerCombos();
            this.obtenerFunciones();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = descripcion;
            var today = DateTime.Today;
            this.dtpHasta.Value = today.AddDays(1);

        }
        private void obtenerCombos()
        {
            this.obtenerFunciones();
            
        }

        private void obtenerFunciones()
        {
            DataTable lista = ConsultasData.obtenerCombo("PA_OBT_FUNCIONES");
            this.cboFunciones.DataSource = lista;
            foreach (DataRow row in lista.Rows)
            {
                this.cboFunciones.ValueMember = "COD_FUNCION";
                this.cboFunciones.DisplayMember = "NOMBRE";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand();
            comando.Parameters.AddWithValue("@funcion", this.cboFunciones.SelectedValue);
            comando.Parameters.AddWithValue("@desde", dtpDesde.Value);
            comando.Parameters.AddWithValue("@hasta", dtpHasta.Value);

            DataTable Resultado = ConsultasData.ejecutarSpParams("PA_REPORTE_ENTRADAS", comando);
            if (Resultado.Rows.Count > 0)
            {
                if (!Resultado.Rows[0].ItemArray[0].ToString().Contains("La fecha desde no puede ser mayor a la fecha hasta"))
                {
                    this.dgvResultados.DataSource = Resultado;
                }
                else
                {
                    MessageBox.Show("La fecha desde no puede ser mayor ni igual a la fecha hasta");
                }
            }
            else
            {
                MessageBox.Show("No hay resultados");
            }
              


        }
    }
}
