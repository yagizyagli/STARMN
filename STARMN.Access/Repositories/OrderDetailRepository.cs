

using STARMN.Access.Repositories.Interfaces;
using STARMN.Database;
using STARMN.Database.Entities;

namespace STARMN.Access.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(STARMNDB sTARMNDB) : base(sTARMNDB)
        {

        }
    }
}
