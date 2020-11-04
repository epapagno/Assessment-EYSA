using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class HistRepStoresETC : IEntityTypeConfiguration<HistRepStores>
    {
        public void Configure(EntityTypeBuilder<HistRepStores> builder)
        {
            // Generación tabla: HIST_REP_STORES
            builder.ToTable("HIST_REP_STORES", "REP");
            builder.Property(i => i.Id).HasColumnName("ID");
            builder.Property(i => i.StoreName).HasColumnName("STORE_NAME");
            builder.Property(i => i.MarketId).HasColumnName("MARKET_ID");
            builder.Property(i => i.PodId).HasColumnName("POD_ID");
            builder.Property(i => i.CorpId).HasColumnName("CORP_ID");
            builder.Property(i => i.Acronym).HasColumnName("ACRONYM");
            builder.Property(i => i.StoreTypeId).HasColumnName("STORE_TYPE_ID");
            builder.Property(i => i.OperatorId).HasColumnName("OPERATOR_ID");
            builder.Property(i => i.RepId).HasColumnName("REP_ID");
            builder.Property(i => i.ProjectManagerId).HasColumnName("PROJECT_MANAGER_ID");
            builder.Property(i => i.TypeOfDealId).HasColumnName("TYPE_OF_DEAL_ID");
            builder.Property(i => i.RePriceCost).HasColumnName("RE_PRICE_COST");
            builder.Property(i => i.BudgCost).HasColumnName("BUDG_COST");
            builder.Property(i => i.ApprovedCost).HasColumnName("APPROVED_COST");
            builder.Property(i => i.EquipCost).HasColumnName("EQUIP_COST");
            builder.Property(i => i.ArchitectId).HasColumnName("ARCHITECT_ID");
            builder.Property(i => i.BrokerId).HasColumnName("BROKER_ID");
            builder.Property(i => i.ConstructorId).HasColumnName("CONSTRUCTOR_ID");
            builder.Property(i => i.AproxVol).HasColumnName("APROX_VOL");
            builder.Property(i => i.SigningDate).HasColumnName("SIGNING_DATE");
            builder.Property(i => i.SigningOk).HasColumnName("SIGNING_OK");
            builder.Property(i => i.BreakDate).HasColumnName("BREAK_DATE");
            builder.Property(i => i.BreakOk).HasColumnName("BREAK_OK");
            builder.Property(i => i.KeyDate).HasColumnName("KEY_DATE");
            builder.Property(i => i.KeyOk).HasColumnName("KEY_OK");
            builder.Property(i => i.ConstructionTime).HasColumnName("CONSTRUCTION_TIME");
            builder.Property(i => i.ConstructOk).HasColumnName("CONSTRUCT_OK");
            builder.Property(i => i.OpeningDate).HasColumnName("OPENING_DATE");
            builder.Property(i => i.Remarks).HasColumnName("REMARKS");
            builder.Property(i => i.AuditUser).HasColumnName("AUDIT_USER");
            builder.Property(i => i.AuditDate).HasColumnName("AUDIT_DATE");
            builder.Property(i => i.RePriceCost1).HasColumnName("RE_PRICE_COST1");
            builder.Property(i => i.RePriceCost2).HasColumnName("RE_PRICE_COST2");
            builder.Property(i => i.RePriceCost3).HasColumnName("RE_PRICE_COST3");
            builder.Property(i => i.OpeningOk).HasColumnName("OPENING_OK");
            builder.Property(i => i.RegionId).HasColumnName("REGION_ID");
            builder.Property(i => i.SkStartDate).HasColumnName("SK_START_DATE");
            builder.Property(i => i.SkEndDate).HasColumnName("SK_END_DATE");
            builder.Property(i => i.PjtStartDate).HasColumnName("PJT_START_DATE");
            builder.Property(i => i.PjtEndDate).HasColumnName("PJT_END_DATE");
            builder.Property(i => i.BidStartDate).HasColumnName("BID_START_DATE");
            builder.Property(i => i.BidReceptionDate).HasColumnName("BID_RECEPTION_DATE");
            builder.Property(i => i.PermStartDate).HasColumnName("PERM_START_DATE");
            builder.Property(i => i.ObtPermDate).HasColumnName("OBT_PERM_DATE");
            builder.Property(i => i.RemarksConstr).HasColumnName("REMARKS_CONSTR");
            builder.Property(i => i.Status).HasColumnName("STATUS");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.Frozen).HasColumnName("FROZEN");
            builder.Property(i => i.PercentageSalesSegment).HasColumnName("PERCENTAGE_SALES_SEGMENT");
            builder.Property(i => i.CompletedDate).HasColumnName("COMPLETED_DATE");
            builder.Property(i => i.ClosingDate).HasColumnName("CLOSING_DATE");
            builder.Property(i => i.ChangingOwnershipDate).HasColumnName("CHANGING_OWNERSHIP_DATE");
            builder.Property(i => i.NewOperatorId).HasColumnName("NEW_OPERATOR_ID");
            builder.Property(i => i.CostCenter).HasColumnName("COST_CENTER");
            builder.Property(i => i.KeyMoney).HasColumnName("KEY_MONEY");
            builder.Property(i => i.OthersCost).HasColumnName("OTHERS_COST");
            builder.Property(i => i.LandCost).HasColumnName("LAND_COST");
            builder.Property(i => i.Plan).HasColumnName("PLAN");
            builder.Property(i => i.GeographicDivisionId).HasColumnName("GEOGRAPHIC_DIVISION_ID");
            builder.Property(i => i.ProySequence).HasColumnName("PROY_SEQUENCE");
            builder.Property(i => i.TypeOfInvestment).HasColumnName("TYPE_OF_INVESTMENT");
            builder.Property(i => i.ReferenceDollarDate).HasColumnName("REFERENCE_DOLLAR_DATE");
            builder.Property(i => i.AmountProject1).HasColumnName("AMOUNT_PROJECT_1");
            builder.Property(i => i.AmountProject2).HasColumnName("AMOUNT_PROJECT_2");
            builder.Property(i => i.StoreId).HasColumnName("STORE_ID");
            builder.Property(i => i.StateProvinceId).HasColumnName("STATE_PROVINCE_ID");
            builder.Property(i => i.MinimarketId).HasColumnName("MINIMARKET_ID");
            builder.Property(i => i.DecorId).HasColumnName("DECOR_ID");
            builder.Property(i => i.FacadeId).HasColumnName("FACADE_ID");
            builder.Property(i => i.FamilySegmentId).HasColumnName("FAMILY_SEGMENT_ID");
        }
    }
}
