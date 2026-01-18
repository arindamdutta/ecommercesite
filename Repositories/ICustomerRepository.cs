using ecommercesite.Models;
using System.Threading.Tasks;

namespace ecommercesite.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Task<Customer?> GetCustomerByIdAsync(string custId);
        Task<Customer?> GetCustomerByNameAsync(string custName);
    }
}
