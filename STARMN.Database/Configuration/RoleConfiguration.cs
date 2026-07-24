using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STARMN.Database.Entities;

namespace STARMN.Database.Configuration
{
    internal class RoleConfiguration: IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(x => x.RoleId);
            builder.Property(x => x.RoleId).UseIdentityColumn();

            builder.Property(x => x.RolAdi).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Sirket).IsRequired().HasMaxLength(250);            
        }
    }
}
