using MVCTestProject.Data;
using MVCTestProject.Models;

namespace MVCTestProject.Services
{
    public class ProductService : IProductService
    {
        private readonly CusProDbContext _db;
        private readonly IConfiguration _configuration;
        public ProductService(CusProDbContext db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }
        public List<Product> GetProducts() 
        {
            var product = _db.Products.ToList();
            return product; 
        }

        public Product GetProductById(int id) 
        {
        var product = _db.Products.FirstOrDefault(p => p.Id ==id);
           
            return product;
        }

        public   List<Product> GetProductsByAlphabetically()
        {
            var products = _db.Products.OrderBy(p => p.ProductName).ToList();
            return products;
        }

        public void AddProduct(Product product) 
        {
            _db.Products.Add(product);
            _db.SaveChanges();

        }
    }
}
