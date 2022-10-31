using Cine_App_2.Datos;
using Cine_App_2.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Cine_App_2.Formularios.FormsConsultas
{
    public partial class Form5 : Form
    {
        public string descripcion;
        public string idFacturaRegistrado;
        List<TipoCliente> tiposClientes = new List<TipoCliente>();
        public int idTicket;

        public Form5()
        {
            InitializeComponent();
            this.obtenerCombos();
            this.obtenerFunciones();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void obtenerCombos()
        {
            this.obtenerClientes();
            this.obtenerVendedores();
            this.obtenerTiposVentas();
        }

        private void obtenerClientes()
        {
            DataTable lista = ConsultasData.obtenerCombo("PA_OBT_CLIENTES");
            this.cboClientes.DataSource = lista;
            foreach (DataRow row in lista.Rows)
            {
                this.cboClientes.ValueMember = "COD_CLIENTE";
                this.cboClientes.DisplayMember = "NOMBRE";
            }
        }

        private void obtenerVendedores()
        {
            DataTable lista = ConsultasData.obtenerCombo("PA_OBT_VENDEDORES");
            this.cboVendedores.DataSource = lista;
            foreach (DataRow row in lista.Rows)
            {
                this.cboVendedores.ValueMember = "COD_VENDEDOR";
                this.cboVendedores.DisplayMember = "NOMBRE";
            }
        }

        private void obtenerTiposVentas()
        {
            DataTable lista = ConsultasData.obtenerCombo("PA_OBT_TIPO_V");
            this.cboTipoVenta.DataSource = lista;
            foreach (DataRow row in lista.Rows)
            {
                this.cboTipoVenta.ValueMember = "COD_TIPO_VENTA";
                this.cboTipoVenta.DisplayMember = "NOMBRE";
            }
        }

        private void obtenerFunciones()
        {
            DataTable result = ConsultasData.obtenerCombo("PA_OBT_FUNCIONES");
            this.cboFunciones.DataSource = result;
            foreach (DataRow row in result.Rows)
            {
                this.cboFunciones.ValueMember = "COD_FUNCION";
                this.cboFunciones.DisplayMember = "NOMBRE";
            }
        }

        private void obtenerSalas()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idFuncion", this.cboFunciones.SelectedValue);
            DataTable result = ConsultasData.ejecutarSpParams("PA_OBT_SALA_X_FUNCION", cmd);
            this.cboSalas.DataSource = result;
            foreach (DataRow row in result.Rows)
            {
                this.cboSalas.ValueMember = "cod_sala";
                this.cboSalas.DisplayMember = "NOMBRE";
            }
            this.obtenerButacasDisponibles();
        }

        private void obtenerButacasDisponibles()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idFuncion", this.cboFunciones.SelectedValue);
            cmd.Parameters.AddWithValue("@idSala", this.cboSalas.SelectedValue);
            DataTable result = ConsultasData.ejecutarSpParams("PA_OBT_BUTACAS_DISPONIBLES", cmd);
            this.cboButacasDisp.DataSource = result;
            foreach (DataRow row in result.Rows)
            {
                this.cboButacasDisp.ValueMember = "COD_BUTACA";
                this.cboButacasDisp.DisplayMember = "NRO_BUTACA";
            }
        }

        private void obtenerTiposClientes()
        {
            DataTable result = ConsultasData.obtenerCombo("PA_OBT_TIPOS_C");
            this.cboTipoCliente.DataSource = result;
            foreach (DataRow row in result.Rows)
            {
                this.cboTipoCliente.ValueMember = "COD_TIPO_CLIENTE";
                this.cboTipoCliente.DisplayMember = "DESCRIPCION";
                TipoCliente tc = new TipoCliente((int)row.ItemArray[0], (string)row.ItemArray[1], (decimal)row.ItemArray[2]);
                tiposClientes.Add(tc);
            }
        }

        private string registrarFactura()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", this.cboClientes.SelectedValue);
            cmd.Parameters.AddWithValue("@idVendedor", this.cboVendedores.SelectedValue);
            cmd.Parameters.AddWithValue("@idTipoVenta", this.cboTipoVenta.SelectedValue);
            SqlParameter idFactura = new SqlParameter();
            idFactura.ParameterName = "@idFactura";
            idFactura.SqlDbType = System.Data.SqlDbType.Int;
            idFactura.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(idFactura);
            SqlParameter mensaje = new SqlParameter("@mensaje", SqlDbType.VarChar, 20);
            mensaje.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(mensaje);
            ConsultasData.ejecutarSp("PA_REGISTRAR_FACTURA", cmd);
            return idFactura.Value.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.idFacturaRegistrado = this.registrarFactura();
            MessageBox.Show("Se registró con éxito la factura número " + this.idFacturaRegistrado);
            this.obtenerTiposClientes();
            if (idFacturaRegistrado != "")
            {
                this.gbTickets.Visible = true;
                this.gbFactura.Visible = false;
            } 
            else
            {
                this.gbTickets.Visible = false;
                this.gbFactura.Visible = true;
            }
        }

        private void cboFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboFunciones.SelectedIndex > 0)
            {
                this.obtenerSalas();
            }
        }

        private void btnRegistrarTicket_Click(object sender, EventArgs e)
        {
            this.gbFactura.Visible = false;
            this.gbTickets.Visible = true;
            string funcionStr = this.cboFunciones.Text.ToString();
            string salaStr = this.cboSalas.Text.ToString();
            string butaca = this.cboButacasDisp.Text.ToString();
            string resultado = this.registrarTicket();
            
            if ( resultado != "OK")
            {
                MessageBox.Show(resultado);
            } 
            else
            {
                MessageBox.Show("TICKET FACTURA N°: " + this.idFacturaRegistrado + "\n" +
               "Se ha registrado los tickets para la película: " + funcionStr + "\n" +
               "Sala seleccionada: " + salaStr + "\n" +
               "Butaca seleccionada: " + butaca);
            }
        }

        private string registrarTicket()
        {
            if(this.txPrecio.Text == "")
            {
                return "El precio no puede estar vacío";
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idFactura", Convert.ToInt32(this.idFacturaRegistrado));
            cmd.Parameters.AddWithValue("@idFuncion", this.cboFunciones.SelectedValue);
            cmd.Parameters.AddWithValue("@idButaca", this.cboButacasDisp.SelectedValue);
            cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(this.txPrecio.Text));
            cmd.Parameters.AddWithValue("@idTipoCliente", this.cboTipoCliente.SelectedValue);
            SqlParameter mensaje = new SqlParameter("@mensaje", SqlDbType.VarChar, 30)
            {
                Direction = ParameterDirection.Output
            };
            SqlParameter idTicket = new SqlParameter("@idTicket", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(mensaje);
            cmd.Parameters.Add(idTicket);
            DataTable result = ConsultasData.ejecutarSpParams("PA_REGISTRAR_TICKET", cmd);
            DataRow row = result.Rows[0];
            string status = row.ItemArray[0].ToString();
            this.idTicket = Convert.ToInt32(row.ItemArray[1]);
            PrintDocument pd = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            pd.PrinterSettings = ps;
            pd.PrintPage += printDocument1_PrintPage;
            pd.DocumentName = "ticket-" + this.idTicket.ToString();
            pd.Print();
            return status;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tiposClientes.Count > 0)
            {
                decimal precio = tiposClientes.FirstOrDefault(o => o.idTipoCliente == this.cboTipoCliente.SelectedIndex + 1).precio;
                this.txPrecio.Text = precio.ToString();
            }

        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idTicket", this.idTicket);
            DataTable impresion = ConsultasData.ejecutarSpParams("PA_IMPRIMIR_TICKET", cmd);
            string nombrePelicula = impresion.Rows[0].ItemArray[0].ToString();
            string fecha = impresion.Rows[0].ItemArray[1].ToString();
            int nroButaca = Convert.ToInt32(impresion.Rows[0].ItemArray[2]);
            int nroSala = Convert.ToInt32(impresion.Rows[0].ItemArray[3]);
            Font font = new Font("Arial", 20, FontStyle.Bold);
            Font fontTitulo = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString("CINEMA 15 - REPORTE", fontTitulo, Brushes.Black, new RectangleF(220, 10, 1000, 40));
            e.Graphics.DrawString("Ticket numero: " + this.idTicket.ToString(), font, Brushes.Black, new RectangleF(0, 50, 1000, 40));
            e.Graphics.DrawString("-------------------------------------------------", fontTitulo, Brushes.Black, new RectangleF(0, 80, 1000, 40));
            e.Graphics.DrawString("Pelicula: " + nombrePelicula, font, Brushes.Black, new RectangleF(0, 110, 1000, 40));
            e.Graphics.DrawString("Fecha de emisión: " + fecha, font, Brushes.Black, new RectangleF(0, 140, 1000, 40));
            e.Graphics.DrawString("Número de butaca: " + nroButaca.ToString(), font, Brushes.Black, new RectangleF(0, 170, 1000, 40));
            e.Graphics.DrawString("Número de sala: " + nroSala.ToString(), font, Brushes.Black, new RectangleF(0, 200, 1000, 40));
            e.Graphics.DrawString("-------------------------------------------------", fontTitulo, Brushes.Black, new RectangleF(0, 250, 1000, 40));
        }
    }
}
