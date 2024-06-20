using Practise.GenericRepository.Interface;
using Practise.Models;
using Practise.Services.Interface;

namespace Practise.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly IGenericRepository<Customer> _genericRepository;
        public CustomerService(IGenericRepository<Customer> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Customer AddCustomer(Customer customer)
        {
            customer=_genericRepository.Add(customer);
            return customer;
        }

        public void DeleteCustomer(Customer customer)
        {
            _genericRepository.Delete(customer.CustomerId);
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = _genericRepository.GetAll();
            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            Customer customer=_genericRepository.GetById(id);
            return customer;
        }
    }
}
