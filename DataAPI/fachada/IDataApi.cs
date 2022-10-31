using CinemaApp.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.fachada
{
    public interface IDataApi
    {
        public List<Factura> ObtenerFacturasEnPeriodo(DateTime desde, DateTime hasta);

        public bool CrearFactura(Factura factura);

        public bool ActualizarFactura(Factura factura);

        public bool BorrarFactura(int nroFactura);

        public Factura ObtenerPorId(int nro);
    }
}
