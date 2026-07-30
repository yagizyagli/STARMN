using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STARMN.Database.Entities;

namespace STARMN.Database.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.KullaniciAdi).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Sifre).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Tel).IsRequired().HasMaxLength(20);


            builder.HasOne(x => x.Role).WithMany(x => x.User).HasForeignKey(x => x.RoleId);
        }
    }
}
