namespace STARMN.Database.Entities;

public class User
{

    public int Id { get; set; }

    public string KullanicAdi { get; set; }

    public string Email { get; set; }

    public int Tel { get; set; }

    public string Sifre { get; set; }
        
    public int RoleId { get; set; }

    public Role Role { get; set; }

}
