using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/products")]
    [ApiVersion("1.0")]  
    public class ProductsV1Controller : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetProductV1(int id)
        {
            return Ok($"Product V1 with id {id}");
        }
    }
}