using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class RepDefaultDetailProjectionsETC : IEntityTypeConfiguration<RepDefaultDetailProjections>
    {
        public void Configure(EntityTypeBuilder<RepDefaultDetailProjections> builder)
        {
            // Generación tabla: REP_DEFAULT_DETAIL_PROJECTIONS
            builder.ToTable("REP_DEFAULT_DETAIL_PROJECTIONS", "REP").HasKey(i => new { i.PaisId, i.TypeOfProjection, i.SeqMonth });
            builder.Property(i => i.TypeOfProjection).HasColumnName("TYPE_OF_PROJECTION");
            builder.Property(i => i.SeqMonth).HasColumnName("SEQ_MONTH");
            builder.Property(i => i.ReCosts).HasColumnName("RE_COSTS");
            builder.Property(i => i.KeyMoney).HasColumnName("KEY_MONEY");
            builder.Property(i => i.Land).HasColumnName("LAND");
            builder.Property(i => i.Budget).HasColumnName("BUDGET");
            builder.Property(i => i.InitialFranchiseFee).HasColumnName("INITIAL_FRANCHISE_FEE");
            builder.Property(i => i.EquipmentImprov).HasColumnName("EQUIPMENT_IMPROV");
            builder.Property(i => i.PrePaidRent).HasColumnName("PRE_PAID_RENT");
            builder.Property(i => i.PreOpeningCost).HasColumnName("PRE_OPENING_COST");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.CreateBy).HasColumnName("CREATE_BY");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
            builder.Property(i => i.CapStaffCosts).HasColumnName("CAP_STAFF_COSTS");
        }
    }
}
