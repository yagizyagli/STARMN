

using STARMN.Database.Entities;

namespace STARMN.Service.Services.Interfaces;

public interface ICategoryService
{
    public bool Save(Category category);
    public bool Update(Category category);
    public bool Delete(int id);
    public List<Category> GetAll();
    public Category GetById(int id);
    public int ProductCount(int categoryId);
}
