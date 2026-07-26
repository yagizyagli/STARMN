using STARMN.Database.Entities;

namespace STARMN.Web.Models
{
    public class UserRoleView
    {
        public List<User> UserList { get; set; }
        public List<Role> RoleList { get; set; }
    }
}
