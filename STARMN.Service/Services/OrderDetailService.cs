

using STARMN.Access.Repositories.Interfaces;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Service.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;


        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }
        public bool Delete(int id)
        {
            try
            {
                _orderDetailRepository.Delete(id);
                return true;

            }
            catch
            {
                return false;
            }
        }

        public List<OrderDetail> GetAll()
        {
            return _orderDetailRepository.GetAll();
        }

        public OrderDetail GetById(int id)
        {
            return _orderDetailRepository.GetById(id);
        }

        public OrderDetail Save(OrderDetail orderDetail)
        {
            try
            {
                _orderDetailRepository.Save(orderDetail);
                return orderDetail;
            }
            catch
            {
                return null;
            }
        }

        public OrderDetail Update(OrderDetail orderDetail)
        {
            try
            {
                _orderDetailRepository.Update(orderDetail);
                return orderDetail;
            }
            catch
            {
                return null;
            }
        }
    }
}
