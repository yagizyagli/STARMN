namespace STARMN.Database.Entities;

public class Role
{

    public int RolId { get; set; }

    public string Roladi { get; set; }

    public string Aciklama { get; set; }
    public string Sirket { get; set; }

    public ICollection<User> User { get; set; }
}
