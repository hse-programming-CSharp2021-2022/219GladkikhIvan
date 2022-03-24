using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Task_02.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController
    {
        private static List<Product> list = new List<Product>(new[]
        {
            new Product() {Id = 1, Name = "gergr", Price = 12},
            new Product() {Id = 2, Name = "ergre", Price = 145},
            new Product() {Id = 3, Name = "regrae", Price = 4325},
        });

        [HttpGet]
        public IEnumerable<Product> Get() => list;

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var product = list.SingleOrDefault(p => p.Id == id);
            if (product == null)
                return new NotFoundResult();
            return new OkObjectResult(product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            list.Remove(list.SingleOrDefault(p => p.Id == id));
            return new OkResult();
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            product.Id = 123;
            list.Add(product);
            return new CreatedResult(nameof(Get), product);
        }
    }
}