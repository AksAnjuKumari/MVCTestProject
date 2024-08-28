using MVCTestProject.Models;
using Microsoft.EntityFrameworkCore;
using MVCTestProject.Models;

namespace MVCTestProject.Data
{
    public class CusProDbContext : DbContext
    {
        public CusProDbContext(DbContextOptions<CusProDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
