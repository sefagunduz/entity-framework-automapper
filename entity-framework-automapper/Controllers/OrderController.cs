using AutoMapper;
using entity_framework_automapper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace entity_framework_automapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMapper mapper;
        public OrderController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post(Order order)
        {
            Product product = mapper.Map<Product>(order);
            Customer customer = mapper.Map<Customer>(order);

            return Ok();
        }

    }
}
