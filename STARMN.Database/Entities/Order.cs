namespace STARMN.Database.Entities;

public class Order
{

    public int Id { get; set; }
    public DateTime Tarih { get; set; }
    public string? MusteriAdi { get; set; }
    public decimal ToplamTutar { get; set; }

    public ICollection<OrderDetail> OrderDetail { get; set; }
}
