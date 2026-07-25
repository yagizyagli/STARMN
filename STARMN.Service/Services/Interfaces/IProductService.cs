

using STARMN.Database.Entities;

namespace STARMN.Service.Services.Interfaces;

public interface IProductService
{
    List<Product> GetAll();
    Product GetById(int id);
    Product Save(Product product);
    Product Update(Product product);
    bool Delete(int id);
}
