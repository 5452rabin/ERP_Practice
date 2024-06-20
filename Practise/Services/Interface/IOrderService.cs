using Practise.Models;

namespace Practise.Services.Interface
{
    public interface IOrderService
    {
        Order AddOrder (Order order);
        Order GetOrderById(int id);
        Order GetOrderByCustomerId(int id);
        List<Order> GetAllOrders();

    }
}
