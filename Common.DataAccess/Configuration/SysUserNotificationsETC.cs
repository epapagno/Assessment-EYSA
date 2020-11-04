using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public partial class SysUsersNotificationsETC : IEntityTypeConfiguration<SysUsersNotifications>
    {
        public void Configure(EntityTypeBuilder<SysUsersNotifications> builder)
        {
            // Generación tabla: SYS_USERS_NOTIFICATIONS
            builder.ToTable("SYS_USERS_NOTIFICATIONS", "WHOUSE").HasKey(i => new { i.RegionalUsername, i.NotificationId });
            builder.Property(i => i.RegionalUsername).HasColumnName("REGIONAL_USERNAME");
            builder.Property(i => i.NotificationId).HasColumnName("NOTIFICATION_ID");
            builder.Property(i => i.IsReaded).HasColumnName("IS_READED");

            builder.HasOne(i => i.SysUsers)
                .WithMany(i => i.SysUsersNotifications)
                .HasForeignKey(i => i.RegionalUsername)
                .HasPrincipalKey(i => new { i.RegionalUsername });

            builder.HasOne(i => i.Notifications)
                .WithMany(s => s.SysUsersNotifications)
                .HasForeignKey(i => i.NotificationId)
                .HasPrincipalKey(i => i.NotificationId); ;
        }

    }
}
