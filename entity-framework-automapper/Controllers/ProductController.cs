using AutoMapper;
using entity_framework_automapper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace entity_framework_automapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper mapper;
        public ProductController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpPost] 
        public IActionResult Post(ProductApiModel productApiModel)
        {
            Product product = mapper.Map<Product>(productApiModel);

            return Ok();
        }
    }
}
