

using STARMN.Database.Entities;

namespace STARMN.Service.Services.Interfaces;

public interface IUserService
{
    List<User> GetAll();
    User GetById(int id);
    User Save(User user);
    User Update(User user);
    bool Delete(int id);
}
