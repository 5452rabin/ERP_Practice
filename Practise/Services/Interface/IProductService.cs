using Practise.Models;

namespace Practise.Services.Interface
{
    public interface IProductService
    {
        Product AddProduct(Product product);
        Product GetProductById(int id);
        Product GetProductByName(string name);
        void DeleteProduct(Product product);
        List<Product> GetAllProducts();
    }
}
