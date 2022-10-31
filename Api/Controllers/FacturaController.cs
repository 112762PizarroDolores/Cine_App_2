using CinemaApp.dominio;
using DataAPI.fachada;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private IDataApi dataApi; //punto de acceso a la API

        public FacturaController()
        {
            dataApi = new DataApiImp();
        }

        [HttpGet("/factura/{nro}")]
        public IActionResult GetFacturaPorId(int nro)
        {
            Factura factura;
            try
            {
                factura = dataApi.ObtenerPorId(nro);
                return Ok(factura);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpDelete("/factura/{nro}")]
        public IActionResult Borrar(int nro)
        {
            try
            {
                return Ok(dataApi.BorrarFactura(nro));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("/factura")]
        public IActionResult PostFactura(Factura factura)
        {
            try
            {
                if(factura == null)
                {
                    return BadRequest("Datos de factura incorrectos!");
                }

                return Ok(dataApi.CrearFactura(factura));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpPut("/factura")]
        public IActionResult PutFactura(Factura factura)
        {
            try
            {
                if (factura == null)
                {
                    return BadRequest("Datos de factura incorrectos!");
                }

                return Ok(dataApi.ActualizarFactura(factura));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


    }
}
