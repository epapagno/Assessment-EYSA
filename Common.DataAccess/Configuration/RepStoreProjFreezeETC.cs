using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class RepStoreProjFreezeETC : IEntityTypeConfiguration<RepStoreProjFreeze>
    {
        public void Configure(EntityTypeBuilder<RepStoreProjFreeze> builder)
        {
            // Generación tabla: REP_STORE_PROJ_FREEZE
            builder.ToTable("REP_STORE_PROJ_FREEZE", "REP").HasKey(i => new { i.PaisId, i.TypeOfProjection, i.Id, i.SeqId, i.FreezeId });
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.TypeOfProjection).HasColumnName("TYPE_OF_PROJECTION");
            builder.Property(i => i.Id).HasColumnName("ID");
            builder.Property(i => i.SeqId).HasColumnName("SEQ_ID");
            builder.Property(i => i.FreezeId).HasColumnName("FREEZE_ID");
            builder.Property(i => i.TotalGcs).HasColumnName("TOTAL_GCS");
            builder.Property(i => i.AverageCheck).HasColumnName("AVERAGE_CHECK");
            builder.Property(i => i.CashMarginFst).HasColumnName("CASH_MARGIN_FST");
            builder.Property(i => i.GcGrowth).HasColumnName("GC_GROWTH");
            builder.Property(i => i.AverageCheckGrowth).HasColumnName("AVERAGE_CHECK_GROWTH");
            builder.Property(i => i.CashMarginSnd).HasColumnName("CASH_MARGIN_SND");
            builder.Property(i => i.Monday).HasColumnName("MONDAY");
            builder.Property(i => i.Tuesday).HasColumnName("TUESDAY");
            builder.Property(i => i.Wednesday).HasColumnName("WEDNESDAY");
            builder.Property(i => i.Thursday).HasColumnName("THURSDAY");
            builder.Property(i => i.Friday).HasColumnName("FRIDAY");
            builder.Property(i => i.Saturday).HasColumnName("SATURDAY");
            builder.Property(i => i.Sunday).HasColumnName("SUNDAY");
            builder.Property(i => i.SalesJanFirstYear).HasColumnName("SALES_JAN_FIRST_YEAR");
            builder.Property(i => i.SalesFebFirstYear).HasColumnName("SALES_FEB_FIRST_YEAR");
            builder.Property(i => i.SalesMarFirstYear).HasColumnName("SALES_MAR_FIRST_YEAR");
            builder.Property(i => i.SalesAprFirstYear).HasColumnName("SALES_APR_FIRST_YEAR");
            builder.Property(i => i.SalesMayFirstYear).HasColumnName("SALES_MAY_FIRST_YEAR");
            builder.Property(i => i.SalesJunFirstYear).HasColumnName("SALES_JUN_FIRST_YEAR");
            builder.Property(i => i.SalesJulFirstYear).HasColumnName("SALES_JUL_FIRST_YEAR");
            builder.Property(i => i.SalesAugFirstYear).HasColumnName("SALES_AUG_FIRST_YEAR");
            builder.Property(i => i.SalesSepFirstYear).HasColumnName("SALES_SEP_FIRST_YEAR");
            builder.Property(i => i.SalesOctFirstYear).HasColumnName("SALES_OCT_FIRST_YEAR");
            builder.Property(i => i.SalesNovFirstYear).HasColumnName("SALES_NOV_FIRST_YEAR");
            builder.Property(i => i.SalesDecFirstYear).HasColumnName("SALES_DEC_FIRST_YEAR");
            builder.Property(i => i.SalesJanSecondYear).HasColumnName("SALES_JAN_SECOND_YEAR");
            builder.Property(i => i.SalesFebSecondYear).HasColumnName("SALES_FEB_SECOND_YEAR");
            builder.Property(i => i.SalesMarSecondYear).HasColumnName("SALES_MAR_SECOND_YEAR");
            builder.Property(i => i.SalesAprSecondYear).HasColumnName("SALES_APR_SECOND_YEAR");
            builder.Property(i => i.SalesMaySecondYear).HasColumnName("SALES_MAY_SECOND_YEAR");
            builder.Property(i => i.SalesJunSecondYear).HasColumnName("SALES_JUN_SECOND_YEAR");
            builder.Property(i => i.SalesJulSecondYear).HasColumnName("SALES_JUL_SECOND_YEAR");
            builder.Property(i => i.SalesAugSecondYear).HasColumnName("SALES_AUG_SECOND_YEAR");
            builder.Property(i => i.SalesSepSecondYear).HasColumnName("SALES_SEP_SECOND_YEAR");
            builder.Property(i => i.SalesOctSecondYear).HasColumnName("SALES_OCT_SECOND_YEAR");
            builder.Property(i => i.SalesNovSecondYear).HasColumnName("SALES_NOV_SECOND_YEAR");
            builder.Property(i => i.SalesDecSecondYear).HasColumnName("SALES_DEC_SECOND_YEAR");
            builder.Property(i => i.CreateBy).HasColumnName("CREATE_BY");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
        }
    }
}
