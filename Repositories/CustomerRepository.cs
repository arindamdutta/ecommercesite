using ecommercesite.Data;
using ecommercesite.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ecommercesite.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Customer?> GetCustomerByIdAsync(string custId)
        {
            return await _context.Customer
                                 .FirstOrDefaultAsync(c => c.CustId == custId);
        }

        public async Task<Customer?> GetCustomerByNameAsync(string custName)
        {
            return await _context.Customer
                                 .FirstOrDefaultAsync(c => c.CustName == custName);
        }
    }
}
