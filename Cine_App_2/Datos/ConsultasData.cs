using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_App_2.Datos
{
    public class ConsultasData

    {
        public static DataGridView ejecutarConsulta(string consulta)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString());
            conexion.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            adp.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(tabla);
            conexion.Close();
            conexion.Dispose();
            DataGridView result = new DataGridView();
            result.DataSource = tabla;
            return result;
        }

        public static void ejecutarSp(string nombreSp, SqlCommand comando)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString());
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandText = nombreSp;
            comando.ExecuteNonQuery();
        }

        public static DataTable obtenerCombo(string nombreSp)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString());
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSp;
                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                conexion.Close();
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable ejecutarSpParams(string nombreSp, SqlCommand cmd)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString());
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = nombreSp;
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                conexion.Close();
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

   
}