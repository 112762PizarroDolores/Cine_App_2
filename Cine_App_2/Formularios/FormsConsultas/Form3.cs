using Cine_App_2.Datos;
using System;
using System.Windows.Forms;


namespace Cine_App_2.Formularios.FormsConsultas
{
    public partial class Form3 : Form
    {
        public string descripcion;
        public string consulta;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = descripcion;
            this.dgvResultados.DataSource = this.resultadoBase(this.consulta).DataSource;

        }

        public DataGridView resultadoBase(string consulta)
        {
            return ConsultasData.ejecutarConsulta(consulta);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
