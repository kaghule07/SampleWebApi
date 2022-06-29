using WebAPIDemo.Entities;
using WebAPIDemo.Model;
using System.Collections.Generic;
using System.Linq;

namespace WebAPIDemo.Services
{
    public interface IProductServices
    {
        IEnumerable<Product> GetAllProducts();
        int AddProduct(Product prod);
        int ModifyProduct(Product prod);
        int DeleteProduct(int id);

    }
}
