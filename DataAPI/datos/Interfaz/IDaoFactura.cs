using CinemaApp.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.datos.Interfaz
{
    public interface IDaoFactura
    {
        bool Crear(Factura oFactura);
        bool Actualizar(Factura oFactura);
        bool Borrar(int nro);
        List<Factura> ObtenerEnPeriodo(DateTime desde, DateTime hasta);

        Factura ObtenerPorId(int nro);
    }
}
