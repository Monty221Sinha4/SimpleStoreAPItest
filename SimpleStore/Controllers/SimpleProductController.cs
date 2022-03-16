using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleStore.Models;
using System.Threading.Tasks;

namespace SimpleStore.Controllers
{
    public class SimpleProductController : ApiController
    {
        List<SimpleProduct> products = new List<SimpleProduct>();
        public SimpleProductController() { }

        public SimpleProductController(List<SimpleProduct> products)
        {
            this.products = products;
        }
        public IEnumerable<SimpleProduct> GetAllProducts()
        {
            return products;
        }
        public async Task<IEnumerable<SimpleProduct>> GetAllProductsAsync()
        {
            return await Task.FromResult(GetAllProducts());
        }
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        public async Task<IHttpActionResult> GetProductAsync(int id)
        {
            return await Task.FromResult(GetProduct(id));
        }


    }
}
