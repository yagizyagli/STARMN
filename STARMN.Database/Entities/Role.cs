namespace STARMN.Database.Entities;

public class Role
{

    public int RoleId { get; set; }

    public string RolAdi { get; set; }

    public string Aciklama { get; set; }
    public string Sirket { get; set; }

    public ICollection<User> User { get; set; }
}
