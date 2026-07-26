using STARMN.Database.Entities;

namespace STARMN.Web.Models
{
    public class OrderOrderDetailView
    {
        public List<Order> OrderList { get; set; }
        public List<OrderDetail> OrderDetailList { get; set; }
        public List<Product> ProductList { get; set; }
    }
}
