using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public partial class NotificationsETC : IEntityTypeConfiguration<Notifications>
    {
        public void Configure(EntityTypeBuilder<Notifications> builder)
        {
            builder.ToTable("NOTIFICATIONS", "WHOUSE").HasKey(i => new { i.NotificationId });
            builder.Property(i => i.NotificationId).HasColumnName("NOTIFICATION_ID");
            builder.Property(i => i.Message).HasColumnName("MESSAGE");
            builder.Property(i => i.CreatedDate).HasColumnName("CREATED_DATE");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");

            builder.HasMany(i => i.SysUsersNotifications)
               .WithOne(i => i.Notifications)
               .HasForeignKey(i => i.NotificationId);
        }

    }
}
