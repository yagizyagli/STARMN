using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STARMN.Database.Entities;

namespace STARMN.Database.Configuration
{
    internal class OrderDetailConfiguration: IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(); 

            builder.Property(x => x.Miktar).IsRequired(); 

            builder.Property(x => x.BirimFiyat).IsRequired().HasColumnType("decimal(18,2)"); 

            builder.HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Order).WithMany(k => k.OrderDetail).HasForeignKey(x => x.OrderId);
        }
    }
}
