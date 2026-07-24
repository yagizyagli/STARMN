

using STARMN.Access.Repositories.Interfaces;
using STARMN.Database;
using STARMN.Database.Entities;

namespace STARMN.Access.Repositories;

public class OrderRepository:GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(STARMNDB sTARMNDB) : base(sTARMNDB)
    {

    }
}
