namespace STARMN.Database.Entities;

public class Product
{
    public int Id { get; set; } 
    public string Adi { get; set; } 
    public string Aciklama { get; set; } 
    public decimal Fiyat { get; set; }
    public int Stok { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
