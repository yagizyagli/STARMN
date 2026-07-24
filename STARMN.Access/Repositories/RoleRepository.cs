

using STARMN.Access.Repositories.Interfaces;
using STARMN.Database;
using STARMN.Database.Entities;

namespace STARMN.Access.Repositories;

public class RoleRepository:GenericRepository<Role>, IRoleRepository
{
    public RoleRepository(STARMNDB sTARMNDB) : base(sTARMNDB)
    {

    }
}
