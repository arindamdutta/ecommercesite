
using Microsoft.EntityFrameworkCore;
using ecommercesite.Models;

namespace ecommercesite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {


        }
        public DbSet<Customer> Customer { get; set; }

    }
}
