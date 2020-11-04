using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class RepStoreDetProjFreezeETC : IEntityTypeConfiguration<RepStoreDetProjFreeze>
    {
        public void Configure(EntityTypeBuilder<RepStoreDetProjFreeze> builder)
        {
            // Generación tabla: REP_STORE_DET_PROJ_FREEZE
            builder.ToTable("REP_STORE_DET_PROJ_FREEZE", "REP").HasKey(i => new { i.PaisId, i.Id, i.MonthsYears, i.TypeOfProjection, i.FreezeId });
            builder.Property(i => i.MonthsYears).HasColumnName("MONTHS_YEARS");
            builder.Property(i => i.ReCosts).HasColumnName("RE_COSTS");
            builder.Property(i => i.KeyMoney).HasColumnName("KEY_MONEY");
            builder.Property(i => i.Land).HasColumnName("LAND");
            builder.Property(i => i.Budget).HasColumnName("BUDGET");
            builder.Property(i => i.Approved).HasColumnName("APPROVED");
            builder.Property(i => i.InitialFranchiseFee).HasColumnName("INITIAL_FRANCHISE_FEE");
            builder.Property(i => i.EquipmentImprov).HasColumnName("EQUIPMENT_IMPROV");
            builder.Property(i => i.PrePaidRent).HasColumnName("PRE_PAID_RENT");
            builder.Property(i => i.PreOpeningCost).HasColumnName("PRE_OPENING_COST");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.FreezeId).HasColumnName("FREEZE_ID");
            builder.Property(i => i.CreateBy).HasColumnName("CREATE_BY");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
            builder.Property(i => i.Id).HasColumnName("ID");
            builder.Property(i => i.TypeOfProjection).HasColumnName("TYPE_OF_PROJECTION");
            builder.Property(i => i.RepCotizUsd).HasColumnName("REP_COTIZ_USD");
            builder.Property(i => i.CapStaffCosts).HasColumnName("CAP_STAFF_COSTS");
        }
    }
}

