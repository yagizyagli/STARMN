
using STARMN.Database.Entities;

namespace STARMN.Access.Repositories.Interfaces;

public interface ICategoryRepository : IGenericRepository<Category>
{
    public int ProductCount(int categoryId);
}
