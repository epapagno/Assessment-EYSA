using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class SysUsersETC : IEntityTypeConfiguration<SysUsers>
    {
        public void Configure(EntityTypeBuilder<SysUsers> builder)
        {
            // Generación tabla: SYS_USERS
            builder.ToTable("SYS_USERS", "ORADBA").HasKey(i => new { i.PaisId, i.Username });
            builder.Property(i => i.Username).HasColumnName("USERNAME");
            builder.Property(i => i.FirstName).HasColumnName("FIRST_NAME");
            builder.Property(i => i.LastName).HasColumnName("LAST_NAME");
            builder.Property(i => i.LastChange).HasColumnName("LAST_CHANGE");
            builder.Property(i => i.ExpirationDays).HasColumnName("EXPIRATION_DAYS");
            builder.Property(i => i.LastLogin).HasColumnName("LAST_LOGIN");
            builder.Property(i => i.AccessMethod).HasColumnName("ACCESS_METHOD");
            builder.Property(i => i.MailUser).HasColumnName("MAIL_USER");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.UserType).HasColumnName("USER_TYPE");
            builder.Property(i => i.RegionalUsername).HasColumnName("REGIONAL_USERNAME");
            builder.Property(i => i.UserCountryType).HasColumnName("USER_COUNTRY_TYPE");
            builder.Property(i => i.SuperUserControlables).HasColumnName("SUPER_USER_CONTROLABLES");
            builder.Ignore(i => i.Countries);
            builder.Ignore(i => i.RepId);
            builder.HasMany(i => i.SysUsersNotifications)
               .WithOne(i => i.SysUsers)
               .HasForeignKey(i => i.RegionalUsername);
        }
    }
}
