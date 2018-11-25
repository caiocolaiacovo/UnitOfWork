using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkProject.Context;
using UnitOfWorkProject.Implementation;
using UnitOfWorkProject.Interfaces;
// using UnitOfWorkProject.Interfaces;
using UnitOfWorkProject.Models;
using UnitOfWorkProject.Repositories;
using UnitOfWorkProject.Services;

namespace UnitOfWorkProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService productService;
        
        public ProductsController(ProductService productService) 
        { 
            this.productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return productService.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            // return productRepository.GetById(id);
            return new JsonResult(new {});
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}