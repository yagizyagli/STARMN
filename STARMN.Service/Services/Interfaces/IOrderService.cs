

using STARMN.Database.Entities;

namespace STARMN.Service.Services.Interfaces;

public interface IOrderService
{

    List<Order> GetAll();
    Order GetById(int id);
    Order Save(Order order);
    Order Update(Order order);
    bool Delete(int id);
}
