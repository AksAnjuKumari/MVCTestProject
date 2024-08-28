using MVCTestProject.Models;
namespace MVCTestProject.Services
{
    public interface ICustomerService
    {
         List<Customer> GetCustomers();

         Customer GetCustomerById(int id);

        List<Customer> GetCustomersByAlphabetically();

        void AddCustomer(Customer customer);
    }
}
