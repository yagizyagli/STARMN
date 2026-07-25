

using STARMN.Access.Repositories;
using STARMN.Access.Repositories.Interfaces;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Service.Services
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public bool Delete(int id)
        {
            try
            {
                _orderRepository.Delete(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public Order Save(Order order)
        {

            try
            {
                _orderRepository.Save(order);
                return order;

            }
            catch (Exception)
            {
                return null;

            }
        }
        

        public Order Update(Order order)
        {
            try
            {
                _orderRepository.Update(order);
                return order;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
