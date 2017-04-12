using Galaxia.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GalaxiaWebAPI.Controllers
{
    [RoutePrefix("api/v1")]
    public class PlanetaController : ApiController
    {
        PlanetaNG _planetaNG;
        public PlanetaController()
        {

        }
        [HttpGet]
        [Route("Planeta")]
        public IHttpActionResult Selecionar()
        {
            return Ok(_planetaNG.);
        }
    }
}
