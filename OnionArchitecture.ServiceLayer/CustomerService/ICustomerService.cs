using OnionArchitecture.DomainLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.ServiceLayer.CustomerService
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomer(int id);
        Task InsertCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
        Task DeleteCustomer(int id);
    }
}
