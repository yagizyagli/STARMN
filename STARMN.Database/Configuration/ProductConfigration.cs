using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STARMN.Database.Entities;

namespace STARMN.Database.Configuration
{
    internal class ProductConfigration:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Adi).IsRequired().HasMaxLength(250); 

            builder.Property(x => x.Aciklama).HasMaxLength(500); 

            builder.Property(x => x.Fiyat).IsRequired().HasColumnType("decimal(18,2)"); 

            builder.Property(x => x.Stok).IsRequired(); 
            builder.HasOne(k => k.Category).WithMany(k => k.Product).HasForeignKey(k => k.CategoryId);
        }
    }
}
