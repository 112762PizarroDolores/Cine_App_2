using CinemaApp.datos.Interfaz;
using CinemaApp.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.datos.Implementacion
{
    public class FacturaDao : IDaoFactura
    {
        public bool Crear(Factura oFactura)
        {
            bool ok = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();
            try
            {

                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "PA_FACTURA_CREAR";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", oFactura.Cod_Cliente);
                cmd.Parameters.AddWithValue("@idVendedor", oFactura.Cod_Vendedor);
                cmd.Parameters.AddWithValue("@idTipoVenta", oFactura.Cod_Tipo_Venta);

                //parámetro de salida:
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@idFactura";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                int facturaNro = (int)pOut.Value;

                SqlCommand cmdDetalle;
                foreach (Ticket item in oFactura.Tickets)
                {
                    cmdDetalle = new SqlCommand("PA_TICKET_CREAR", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@idFactura", facturaNro);
                    cmdDetalle.Parameters.AddWithValue("@idFuncion", item.Funcion.Cod_Funcion);
                    cmdDetalle.Parameters.AddWithValue("@idButaca", item.Cod_Butaca);
                    cmdDetalle.Parameters.AddWithValue("@precio", item.Precio);
                    cmdDetalle.Parameters.AddWithValue("@idTipoCliente", item.Cod_Tipo_Cliente);

                    cmdDetalle.ExecuteNonQuery();
                }
                t.Commit();
            }

            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }

        public bool Actualizar(Factura oFactura)
        {
            bool ok = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "PA_FACTURA_ACTUALIZAR";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente", oFactura.Cod_Cliente);
                cmd.Parameters.AddWithValue("@idVendedor", oFactura.Cod_Vendedor);
                cmd.Parameters.AddWithValue("@idTipoVenta", oFactura.Cod_Tipo_Venta);
                cmd.Parameters.AddWithValue("@idFactura", oFactura.Cod_Factura);;
                cmd.ExecuteNonQuery();

                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (Ticket item in oFactura.Tickets)
                {
                    cmdDetalle = new SqlCommand("PA_TICKET_CREAR", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@idFactura", oFactura.Cod_Factura);
                    cmdDetalle.Parameters.AddWithValue("@idFuncion", item.Funcion.Cod_Funcion);
                    cmdDetalle.Parameters.AddWithValue("@idButaca", item.Cod_Butaca);
                    cmdDetalle.Parameters.AddWithValue("@precio", item.Precio);
                    cmdDetalle.Parameters.AddWithValue("@idTipoCliente", item.Cod_Tipo_Cliente);

                    cmdDetalle.ExecuteNonQuery();

                    detalleNro++;
                }
                t.Commit();
            }

            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }

        public bool Borrar(int nro)
        {
            string sp = "PA_FACTURA_BORRAR";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@idFactura", nro));
            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;
        }

        public List<Factura> ObtenerEnPeriodo(DateTime desde, DateTime hasta)
        {
            List<Factura> facturas = new List<Factura>();
            string sp = "SP_FACTURA_OBTENERENPERIODO";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha_desde", desde));
            lst.Add(new Parametro("@fecha_hasta", hasta));
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Factura factura = new Factura();
                factura.Cod_Factura = int.Parse(row["Cod_Factura"].ToString());
                factura.Cod_Cliente = int.Parse(row["Cod_Cliente"].ToString());
                factura.Cod_Vendedor = int.Parse(row["Cod_Vendedor"].ToString());
                factura.Cod_Tipo_Venta = int.Parse(row["Cod_Tipo_Venta"].ToString());
                factura.Fecha = DateTime.Parse(row["fecha"].ToString());

                facturas.Add(factura);
            }

            return facturas;
        }

        public Factura ObtenerPorId(int nro)
        {
            Factura factura = new Factura();
            string sp = "PA_FACTURA_OBTENERPORID";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@idFactura", nro));
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL(sp, lst);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                factura.Cod_Factura = int.Parse(row["Cod_Factura"].ToString());
                factura.Cod_Cliente = int.Parse(row["Cod_Cliente"].ToString());
                factura.Cod_Vendedor = int.Parse(row["Cod_Vendedor"].ToString());
                factura.Cod_Tipo_Venta = int.Parse(row["Cod_Tipo_Venta"].ToString());
                factura.Fecha = DateTime.Parse(row["fecha"].ToString());
            }


            return factura;
        }
    }
}

