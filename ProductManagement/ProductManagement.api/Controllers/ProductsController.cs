using ProductManagement.datalayer;
using ProductManagement.domain;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProductManagement.api.Controllers
{
    public class ProductsController : ApiController
    {
        private ProductContext _db;

        public ProductsController()
        {
            _db = new ProductContext();
        }
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            return _db.Products.ToList();
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            return _db.Products.Find(id);
        }

        // POST: api/Products
        public void Post(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }

        // PUT: api/Products/5
        public void Put(int id, Product product)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
