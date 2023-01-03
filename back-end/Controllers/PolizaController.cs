using back_end.Data;
using back_end.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.Controllers
{

    [ApiController]
    public class PolizaController : ControllerBase
    {
        private readonly PolizaContexto _contexto;
        private readonly ParametroContexto _contextoParametro;
        private readonly string CodigoCiudadesNoPermitidas = "CiudadesNoPermitidas";
        public PolizaController(PolizaContexto contexto, ParametroContexto contextoParametro)
        {
            this._contexto = contexto;
            this._contextoParametro = contextoParametro;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Poliza>>> Get()
        //{

        //    return await _contexto.Poliza.ToArrayAsync();

        //}

        [HttpGet]
        [Route("api/polizas/{id}")]
        public async Task<ActionResult<IEnumerable<Poliza>>> Get(string id)
        {
            string ciudades = _contextoParametro.Parametro.Where(x => x.Codigo.Equals(CodigoCiudadesNoPermitidas)).ToList().First(y => y.Codigo == CodigoCiudadesNoPermitidas).Valor;
            string[] ciudadess = ciudades.Split(',');
            return await _contexto.Poliza.Where(x => x.PlacaAutomotor.Equals(id) && !ciudadess.Contains(x.CiudadVenta)).ToArrayAsync();
        }

    }
}
