using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibeyTechnicalTestAPI.Controllers.Ubigeo
{
    [ApiController]
    [Route("[controller]")]
    public class UbigeoController : Controller
    {
        private readonly IUbigeoSearch _ubigeo;
        public UbigeoController(IUbigeoSearch ubigeo)
        {
            _ubigeo = ubigeo;
        }

        [HttpGet("ubigeo/{provinceCode}")]
        public IActionResult UbigeoFindAll(string provinceCode)
        {
            var row = _ubigeo.UbigeoFindAllResponse(provinceCode);
            return Ok(row);
        }

        [HttpGet("province/{regionCode}")]
        public IActionResult ProvinceFindAll(string regionCode)
        {
            var row = _ubigeo.ProvinceFindAllResponse(regionCode);
            return Ok(row);
        }

        [HttpGet("region")]
        public IActionResult RegionFindAll()
        {
            var row = _ubigeo.RegionFindAllResponse();
            return Ok(row);
        }
    }
}
