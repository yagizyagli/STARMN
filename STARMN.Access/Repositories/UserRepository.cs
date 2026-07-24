

using STARMN.Access.Repositories.Interfaces;
using STARMN.Database;
using STARMN.Database.Entities;

namespace STARMN.Access.Repositories;

public class UserRepository:GenericRepository<User>, IUserRepository
{
    public UserRepository(STARMNDB sTARMNDB) : base(sTARMNDB)
    {

    }


}
