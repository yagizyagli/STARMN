
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
                User KullaniciEkle = new User();

                KullaniciEkle.KullanicAdi = user.KullanicAdi;                
                KullaniciEkle.Email = user.Email;
                KullaniciEkle.Sifre = user.Sifre;
                KullaniciEkle.Tel = user.Tel;                
                KullaniciEkle.RoleId = user.RoleId;
                

                _userRepository.Save(KullaniciEkle);

                return KullaniciEkle;
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
                User KullaniciGuncelle= _userRepository.GetById(user.Id);

                if (KullaniciGuncelle == null)
                {
                    return KullaniciGuncelle;
                }

                KullaniciGuncelle.KullanicAdi = user.KullanicAdi;                
                KullaniciGuncelle.Email = user.Email;
                KullaniciGuncelle.Sifre = user.Sifre;
                KullaniciGuncelle.Tel = user.Tel;                
                KullaniciGuncelle.RoleId = user.RoleId;

                _userRepository.Update(KullaniciGuncelle);

                return KullaniciGuncelle;
            }
            catch
            {
                return null;
            }
        }
    }
}
