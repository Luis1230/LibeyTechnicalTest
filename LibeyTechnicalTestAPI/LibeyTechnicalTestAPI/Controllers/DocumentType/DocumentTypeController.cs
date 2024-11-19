using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibeyTechnicalTestAPI.Controllers.DocumentType
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentTypeController : Controller
    {
        private readonly IDocumentTypeSearch _aggregate;
        public DocumentTypeController(IDocumentTypeSearch aggregate)
        {
            _aggregate = aggregate;
        }

        [HttpGet]
        public IActionResult FindResponse()
        {
            var row = _aggregate.FindAllResponse();
            return Ok(row);
        }
    }
}
