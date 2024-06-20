using Microsoft.AspNetCore.Mvc;
using Practise.Models;
using Practise.Services.Interface;

namespace Practise.Controllers
{
    
    public class OrderController : Controller
    {
        private  readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
      
        public JsonResult CreateOrder(Order order)
        {
            order=_orderService.AddOrder(order);
            return Json(order);
        }
    }
}
