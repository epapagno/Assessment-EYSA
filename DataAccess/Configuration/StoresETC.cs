using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class StoresETC : IEntityTypeConfiguration<Stores>
    {
        public void Configure(EntityTypeBuilder<Stores> builder)
        {
            // Generación tabla: STORES
            builder.ToTable("STORES", "IIAW").HasKey(i => new { i.PaisId, i.StoreId });
            builder.Property(i => i.StoreId).HasColumnName("STORE_ID");
            builder.Property(i => i.StoreNumber).HasColumnName("STORE_NUMBER");
            builder.Property(i => i.StoreName).HasColumnName("STORE_NAME");
            builder.Property(i => i.MarketId).HasColumnName("MARKET_ID");
            builder.Property(i => i.SiteId).HasColumnName("SITE_ID");
            builder.Property(i => i.BaseStoreId).HasColumnName("BASE_STORE_ID");
            builder.Property(i => i.PrimaryOperatorId).HasColumnName("PRIMARY_OPERATOR_ID");
            builder.Property(i => i.OpenDate).HasColumnName("OPEN_DATE");
            builder.Property(i => i.CloseDate).HasColumnName("CLOSE_DATE");
            builder.Property(i => i.AddressLine1).HasColumnName("ADDRESS_LINE_1");
            builder.Property(i => i.AddressLine2).HasColumnName("ADDRESS_LINE_2");
            builder.Property(i => i.AddressLine3).HasColumnName("ADDRESS_LINE_3");
            builder.Property(i => i.AddressLine4).HasColumnName("ADDRESS_LINE_4");
            builder.Property(i => i.PostalCode).HasColumnName("POSTAL_CODE");
            builder.Property(i => i.Country).HasColumnName("COUNTRY");
            builder.Property(i => i.StateProvince).HasColumnName("STATE_PROVINCE");
            builder.Property(i => i.City).HasColumnName("CITY");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.ModifyDateCloseDate).HasColumnName("MODIFY_DATE_CLOSE_DATE");
            builder.Property(i => i.ModifyUserCloseDate).HasColumnName("MODIFY_USER_CLOSE_DATE");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.CreationUser).HasColumnName("CREATION_USER");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
            builder.Property(i => i.ModifyUser).HasColumnName("MODIFY_USER");
        }
    }
}
