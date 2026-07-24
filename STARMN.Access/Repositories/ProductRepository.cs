

using STARMN.Access.Repositories.Interfaces;
using STARMN.Database;
using STARMN.Database.Entities;

namespace STARMN.Access.Repositories;

public class ProductRepository:GenericRepository<Product>, IProductRepository
{
    public ProductRepository(STARMNDB sTARMNDB) : base(sTARMNDB)
    {

    }
}
