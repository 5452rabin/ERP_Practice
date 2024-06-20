using Practise.Models;

namespace Practise.Services.Interface
{
    public interface ICustomerService
    {
        Customer AddCustomer(Customer customer);
        Customer GetCustomerById(int id);
        void DeleteCustomer(Customer customer);
        List<Customer> GetAllCustomers();
    }
}
