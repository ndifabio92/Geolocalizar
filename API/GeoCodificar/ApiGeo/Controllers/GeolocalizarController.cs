using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiGeo.Models;
using ApiGeo.Services;

namespace ApiGeo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GeolocalizarController : ControllerBase
    {
        private readonly Service _service;

        public GeolocalizarController(Service service)
        {
            _service = service;
        }

        [HttpPost]
        public ObjectResult Create ([FromBody] Geolocalizar geolocalizar)
        {
            try
            {
                var geo = _service.Create(geolocalizar);
                return StatusCode(202, new { id = geo.Id.ToString() });
            }
            catch( Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        //[HttpGet]
        //public Geocodificar Get(string id)
        //{
        //    var geo = _service.Get(id);
        //    return geo;
        //}
    }
}