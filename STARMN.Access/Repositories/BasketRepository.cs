using STARMN.Access.Repositories.Interfaces;
using STARMN.Database;
using STARMN.Database.Entities;

namespace STARMN.Access.Repositories;

public class BasketRepository : GenericRepository<Basket>, IBasketRepository
{
    public BasketRepository(STARMNDB sTARMNDB) : base(sTARMNDB)
    {

    }
}
