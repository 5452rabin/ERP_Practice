using Practise.GenericRepository.Interface;
using Practise.Models;
using Practise.Services.Interface;

namespace Practise.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<Order> _genericRepository;
        public OrderService(IGenericRepository<Order> genericRepository) { 
            _genericRepository = genericRepository;
        
        }
        public Order AddOrder(Order order)
        {
            if (order.OrderId == null)
            {
                order = _genericRepository.Add(order);
            }
            else
            {
                order=_genericRepository.Update(order);
            }
            return order;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders=_genericRepository.GetAll();
            return orders;
        }

        public Order GetOrderByCustomerId(int id)
        {
            Order order=_genericRepository.GetAll().Where(x=>x.CustomerId == id).FirstOrDefault();
            return order;
        }

        public Order GetOrderById(int id)
        {
            Order order=_genericRepository.GetById(id);
            return order;
        }
    }
}
