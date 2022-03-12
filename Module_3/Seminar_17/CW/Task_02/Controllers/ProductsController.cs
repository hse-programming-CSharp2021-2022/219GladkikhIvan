using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_02.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController
    {
        private static List<Product> list = new List<Product>()
        {
            new Product() { Id = 1,  Name = "fdhg", Price = 192 },
            new Product() { Id = 2,  Name = "fask", Price = 24 },
            new Product() { Id = 3,  Name = "dfgr", Price = 535 },
        };

        [HttpGet]
        public IEnumerable<Product> Get() => list;

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = list.SingleOrDefault(p => p.Id == id);

            if (product == null)
                return NotFoundResult();

            return new OkObjectResult(product);
        }
    }
}
