using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STARMN.Database.Entities;

namespace STARMN.Database.Configuration
{
    internal class CategoryConfiguration:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Adi).IsRequired().HasMaxLength(250);

            builder.Property(x => x.Aciklama).HasMaxLength(500);
        }
    }
}
