using STARMN.Database.Entities;

namespace STARMN.Web.Models
{
    public class ProductCategoryView
    {
        public List<Product> ProductList { get; set; }
        public List<Category> CategoryList { get; set; }
    }
}
