using WebAPIDemo.Entities;
using WebAPIDemo.Model;
using System.Collections.Generic;
using System.Linq;
namespace WebAPIDemo.Repositories
{
    public interface IProductRepositoy
    { 
        IEnumerable<Product> GetAllProducts();
        int AddProduct(Product prod);
        int ModifyProduct(Product prod);
        int DeleteProduct(int id);
    }
}

