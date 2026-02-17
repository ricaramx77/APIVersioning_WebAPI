using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/products")]
    [ApiVersion("2.0")]  
    public class ProductsV2Controller : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetProductV2(int id)
        {
            return Ok($"Product V2 with id {id}");
        }
    }
}

