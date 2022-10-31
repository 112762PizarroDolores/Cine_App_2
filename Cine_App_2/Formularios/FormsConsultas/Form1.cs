using Cine_App_2.Datos;
using System;
using System.Windows.Forms;

namespace Cine_App_2.Formularios.FormsConsultas
{
    public partial class Form1 : Form
    {
        public string descripcion;
        public string consulta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = descripcion;
            this.dgvResultados.DataSource = this.resultadoBase(this.consulta).DataSource;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public DataGridView resultadoBase(string consulta)
        {
            return ConsultasData.ejecutarConsulta(consulta);
        }
    }
}
