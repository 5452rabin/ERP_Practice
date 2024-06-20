using Practise.GenericRepository.Interface;
using Practise.Models;
using Practise.Services.Interface;

namespace Practise.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _repository;
        public ProductService(IGenericRepository<Product> repository)
        {
            _repository = repository;
        }

        public Product AddProduct(Product product)
        {
            product=_repository.Add(product);
            return product;
        }

        public void DeleteProduct(Product product)
        {
           _repository.Delete(product.productId);
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products=_repository.GetAll();
            return products;
        }

        public Product GetProductById(int id)
        {
            Product product = _repository.GetById(id);
            return product;
        }

        public Product GetProductByName(string name)
        {
            List<Product> products = _repository.GetAll();
            Product product=products.FirstOrDefault(p => p.Name == name);
            return product;
        }
    }
}
