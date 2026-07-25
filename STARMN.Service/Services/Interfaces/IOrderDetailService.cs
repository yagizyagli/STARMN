
using STARMN.Database.Entities;

namespace STARMN.Service.Services.Interfaces;

public interface IOrderDetailService
{
    List<OrderDetail> GetAll();
    OrderDetail GetById(int id);
    OrderDetail Save(OrderDetail orderDetail);
    OrderDetail Update(OrderDetail orderDetail);
    bool Delete(int id);
}
