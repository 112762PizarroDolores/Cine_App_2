using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.dominio
{
    public class Factura
    {
        public int Cod_Factura { get; set; }
        public DateTime Fecha { get; set; }
        public int Cod_Cliente { get; set; }
        public int Cod_Vendedor { get; set; }
        public int Cod_Tipo_Venta { get; set; }

        public List<Ticket> Tickets { get; set; }

        public Factura()
        {
            Tickets = new List<Ticket>();
        }

        public void AgregarDetalle(Ticket detalle) {
            Tickets.Add(detalle);
        }

        public void QuitarDetalle(int indice) {
            Tickets.RemoveAt(indice);
        }

        public double CalcularTotal() {
            double total = 0;
            foreach (Ticket item in Tickets)
                total += item.Precio;
            return total;
        }

    }
}
