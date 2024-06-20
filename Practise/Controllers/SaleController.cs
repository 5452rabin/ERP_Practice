using Microsoft.AspNetCore.Mvc;
using Practise.Models;
using Practise.Services.Implementation;
using Practise.Services.Interface;

namespace Practise.Controllers
{
    public class SaleController : Controller
    {
        private readonly ISaleService _saleService;
        public class SaleVM
        {
            public int orderId { get; set; }
            public int productId { get; set; }
            public int quantity { get; set; }
            public int rate { get; set; }
        }
        public SaleController(ISaleService saleService) {
            _saleService = saleService;
        }
        public JsonResult Addsale(SaleVM saleVM)
        {
            Sale sale = new Sale()
            {
                ProductId=saleVM.productId,
                rate=saleVM.rate,
                quantity=saleVM.quantity,
                OrderId=saleVM.orderId
            };
            sale=_saleService.AddSale(sale);
      
            return Json(sale);
        }
    }
}
