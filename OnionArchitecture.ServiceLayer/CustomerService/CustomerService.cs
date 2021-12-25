using Microsoft.Extensions.Logging;
using OnionArchitecture.DomainLayer.Entities;
using OnionArchitecture.RepositoryLayer.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.ServiceLayer.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly ILogger<CustomerService> _logger;
        private IRepository<Customer> _repository;

        public CustomerService(
            ILogger<CustomerService> logger, 
            IRepository<Customer> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task DeleteCustomer(int id)
        {
            try
            {
                var customer = await _repository.Get(id);

                if (customer != null)
                    await _repository.Delete(customer);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
            }
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            try
            {
                return await _repository.GetAll();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                return null;
            }
        }

        public async Task<Customer> GetCustomer(int id)
        {
            try
            {
                return await _repository.Get(id);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                return null;
            }
        }

        public async Task InsertCustomer(Customer customer)
        {
            try
            {
                await _repository.Insert(customer); 
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
            }
        }

        public async Task UpdateCustomer(Customer customer)
        {
            try
            {
                await _repository.Update(customer);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
            }
        }
    }
}
