
using STARMN.Access.Repositories;
using STARMN.Access.Repositories.Interfaces;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool Delete(int id)
        {
            try
            {
                _userRepository.Delete(id);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User Save(User user)
        {
            try
            {
               _userRepository.Save(user);
               return user;
            }
            catch
            {
                return null;
            }
        }

        public User Update(User user)
        {
            try
            {
               _userRepository.Update(user);
                return user;
            }
            catch
            {
                return null;
            }
        }
    }
}
