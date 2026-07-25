

using STARMN.Database.Entities;

namespace STARMN.Service.Services.Interfaces;

public interface IRoleService
{
    List<Role> GetAll();
    Role GetById(int id);
    Role Save(Role role);
    Role Update(Role role);
    bool Delete(int id);
}
