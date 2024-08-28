using MVCTestProject.Data;
using MVCTestProject.Models;

namespace MVCTestProject.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly CusProDbContext _db;
        private readonly IConfiguration _configuration;
        public CustomerService(CusProDbContext db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }
        public List<Customer> GetCustomers()
        {
            var customers = _db.Customers.ToList(); 
            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            var customer = _db.Customers.FirstOrDefault(c => c.Id == id);
            
            return customer;
        }

        public List<Customer> GetCustomersByAlphabetically()
        {

            var customers = _db.Customers.OrderBy(p => p.FirstName).ToList();
            return customers; 
;
        }
        
      public  void AddCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
        }
    }
}
