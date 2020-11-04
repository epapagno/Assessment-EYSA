using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class RepStoreDetailProjectionsETC : IEntityTypeConfiguration<RepStoreDetailProjections>
    {
        public void Configure(EntityTypeBuilder<RepStoreDetailProjections> builder)
        {
            // Generación tabla: REP_STORE_DETAIL_PROJECTIONS
            builder.ToTable("REP_STORE_DETAIL_PROJECTIONS", "REP").HasKey(i => new
            {
                i.PaisId,
                i.Id,
                i.MonthsYears,
                i.TypeOfProjection
            });
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
            builder.Property(i => i.CreateBy).HasColumnName("CREATE_BY");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
            builder.Property(i => i.Id).HasColumnName("ID");
            builder.Property(i => i.TypeOfProjection).HasColumnName("TYPE_OF_PROJECTION");
            builder.Property(i => i.CapStaffCosts).HasColumnName("CAP_STAFF_COSTS");
            builder.Property(i => i.ReCostsReal).HasColumnName("RE_COSTS_REAL")
                .HasConversion(i => i ? "S" : "N", i => i == "S");
            builder.Property(i => i.KeyMoneyReal).HasColumnName("KEY_MONEY_REAL")
                .HasConversion(i => i ? "S" : "N", i => i == "S");
            builder.Property(i => i.LandReal).HasColumnName("LAND_REAL")
                .HasConversion(i => i ? "S" : "N", i => i == "S");
            builder.Property(i => i.BudgetReal).HasColumnName("BUDGET_REAL")
                .HasConversion(i => i ? "S" : "N", i => i == "S");
            builder.Property(i => i.CapStaffCostsReal).HasColumnName("CAP_STAFF_COSTS_REAL")
                .HasConversion(i => i ? "S" : "N", i => i == "S");
            builder.Property(i => i.InitialFranchiseFeeReal).HasColumnName("INITIAL_FRANCHISE_FEE_REAL")
                .HasConversion(i => i ? "S" : "N", i => i == "S");
            builder.Property(i => i.EquipmentImprovReal).HasColumnName("EQUIPMENT_IMPROV_REAL")
                .HasConversion(i => i ? "S" : "N", i => i == "S");
            builder.Property(i => i.PrePaidRentReal).HasColumnName("PRE_PAID_RENT_REAL")
                .HasConversion(i => i ? "S" : "N", i => i == "S");
            builder.Property(i => i.PreOpeningCostReal).HasColumnName("PRE_OPENING_COST_REAL")
                .HasConversion(i => i ? "S" : "N", i => i == "S");

            builder.HasOne(i => i.RepStores)
                .WithMany(i => i.RepStoreDetailProjections)
                .HasForeignKey(i => new { i.Id, i.PaisId })
                .HasPrincipalKey(i => new { i.Id, i.PaisId });
        }
    }
}
