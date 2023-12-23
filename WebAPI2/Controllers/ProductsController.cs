using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI2.Models;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        static List<Product> products;
        public ProductsController()
        {
            if (products == null)
                products = ProductService.GetProducts();
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(products);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpPost("create")]
        public IActionResult Create(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            products.Remove(product);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update(Product product)
        {
            var productToUpdate = products.FirstOrDefault(p => p.Id == product.Id);
            if (productToUpdate == null)
                return NotFound();
            productToUpdate.Name = product.Name;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.Category = product.Category;
            return Ok();
        }

    }
}
