using System.Collections;
using System.Collections.Generic;
using Testing.Models;
using System.Linq;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
