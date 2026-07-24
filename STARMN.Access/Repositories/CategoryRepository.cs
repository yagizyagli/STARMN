
using STARMN.Access.Repositories.Interfaces;
using STARMN.Database;
using STARMN.Database.Entities;

namespace STARMN.Access.Repositories;

public class CategoryRepository:GenericRepository<Category>,ICategoryRepository
{
    public CategoryRepository(STARMNDB sTARMNDB) : base(sTARMNDB)
    {

    }
    public int ProductCount(int categoryId)
    {
        throw new NotImplementedException();
    }
}
