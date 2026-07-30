

using STARMN.Access.Repositories.Interfaces;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Service.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public bool Delete(int id)
        {
            try
            {
                _roleRepository.Delete(id);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        public Role Save(Role role)
        {
            try
            {
                _roleRepository.Save(role);
                return role;
            }
            catch
            {
                return null;
            }
        }

        public Role Update(Role role)
        {
            try
            {
                _roleRepository.Update(role);
                return role;
                
            }
            catch
            {
                return null;
            }
        }
    }
}
