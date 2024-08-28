using MVCTestProject.Models;
namespace MVCTestProject.Services
{
     public interface IProductService
    {
         List<Product> GetProducts();

         Product GetProductById(int id);

        List<Product> GetProductsByAlphabetically();

        void AddProduct(Product product);
    }
}
