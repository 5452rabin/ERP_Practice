using Microsoft.AspNetCore.Mvc;
using Practise.Models;
using Practise.Services.Interface;

namespace Practise.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService) 
        {
            _customerService = customerService;
        }
        [HttpPost]
        public JsonResult AddCustomer(string customerName,string customerAddress)
        {
            Customer customer = new Customer()
            {
                Name = customerName,
                Address = customerAddress
            };
            customer= _customerService.AddCustomer(customer);
            var data= new { customername=customer.Name, customeraddress=customer.Address };
            return Json(data);
        }
        [HttpGet]
        public IActionResult Customer()
        {
            List<Customer> customers=_customerService.GetAllCustomers();
            return View(customers);
        }
        [HttpGet]
        public JsonResult GetAllCustomers()
        {
            List<Customer> customers= _customerService.GetAllCustomers();
            return Json(customers);
        }
    }
}
