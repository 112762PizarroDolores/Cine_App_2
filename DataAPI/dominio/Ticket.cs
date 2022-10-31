using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.dominio
{
    public class Ticket
    {
        public Ticket()
        {

        }
        public Funcion Funcion { get; set; }
        public int Cod_Butaca { get; set; }

        public int Cod_Tipo_Cliente { get; set; }

        public double Precio { get; set; }
        public Ticket(Funcion p) {
            Funcion = p;
        }

    }
}
