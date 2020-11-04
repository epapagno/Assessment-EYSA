using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class RepStoresETC : IEntityTypeConfiguration<RepStores>
    {
        public void Configure(EntityTypeBuilder<RepStores> builder)
        {
            // Generación tabla: REP_STORES
            builder.ToTable("REP_STORES", "REP").HasKey(i => new { i.PaisId, i.Id });
            builder.Property(i => i.Id).HasColumnName("ID");
            builder.Property(i => i.StoreName).HasColumnName("STORE_NAME");
            builder.Property(i => i.MarketId).HasColumnName("MARKET_ID");
            builder.Property(i => i.PodId).HasColumnName("POD_ID");
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
            builder.Property(i => i.SigningOk).HasColumnName("SIGNING_OK")
                .HasConversion(i => i != null ? "Y" : "N", i => i == "Y");
            builder.Property(i => i.BreakDate).HasColumnName("BREAK_DATE");
            builder.Property(i => i.BreakOk).HasColumnName("BREAK_OK")
                .HasConversion(i => i != null ? "Y" : "N", i => i == "Y");
            builder.Property(i => i.KeyDate).HasColumnName("KEY_DATE");
            builder.Property(i => i.KeyOk).HasColumnName("KEY_OK")
                .HasConversion(i => i != null ? "Y" : "N", i => i == "Y");
            builder.Property(i => i.ConstructionTime).HasColumnName("CONSTRUCTION_TIME");
            builder.Property(i => i.ConstructOk).HasColumnName("CONSTRUCT_OK")
                .HasConversion(i => i != null ? "Y" : "N", i => i == "Y");
            builder.Property(i => i.OpeningDate).HasColumnName("OPENING_DATE");
            builder.Property(i => i.Remarks).HasColumnName("REMARKS");
            builder.Property(i => i.AuditUser).HasColumnName("AUDIT_USER");
            builder.Property(i => i.AuditDate).HasColumnName("AUDIT_DATE");
            builder.Property(i => i.OpeningOk).HasColumnName("OPENING_OK")
                .HasConversion(i => i != null ? "Y" : "N", i => i == "Y");
            builder.Property(i => i.RegionId).HasColumnName("REGION_ID");
            builder.Property(i => i.PodIdOk).HasColumnName("POD_ID_OK")
                .HasConversion(i => i != null ? "Y" : "N", i => i == "Y");
            builder.Property(i => i.Warehouse).HasColumnName("WAREHOUSE");
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
            builder.Property(i => i.Pod2).HasColumnName("POD2");
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
            builder.Property(i => i.CreateBy).HasColumnName("CREATE_BY");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
            builder.Property(i => i.Frozen).HasColumnName("FROZEN");
            builder.Property(i => i.ReferenceDollarDate).HasColumnName("REFERENCE_DOLLAR_DATE");
            builder.Property(i => i.SalesGap).HasColumnName("SALES_GAP");
            builder.Property(i => i.TypeOfDc).HasColumnName("TYPE_OF_DC");
            builder.Property(i => i.TypeOfDealDc).HasColumnName("TYPE_OF_DEAL_DC");
            builder.Property(i => i.YrsPrimaryLeaseDc).HasColumnName("YRS_PRIMARY_LEASE_DC");
            builder.Property(i => i.LeaseOptionTermsDc).HasColumnName("LEASE_OPTION_TERMS_DC");
            builder.Property(i => i.ApprovedDate).HasColumnName("APPROVED_DATE");
            builder.Property(i => i.YrsPrimaryLease).HasColumnName("YRS_PRIMARY_LEASE");
            builder.Property(i => i.LeaseOptionTerms).HasColumnName("LEASE_OPTION_TERMS");
            builder.Property(i => i.LocalCurrency).HasColumnName("LOCAL_CURRENCY");
            builder.Property(i => i.Currency).HasColumnName("CURRENCY");
            builder.Property(i => i.PreOpeningCost).HasColumnName("PRE_OPENING_COST");
            builder.Property(i => i.InitialFranchiseFee).HasColumnName("INITIAL_FRANCHISE_FEE");
            builder.Property(i => i.ApprovedOk).HasColumnName("APPROVED_OK")
                .HasConversion(i => i != null ? "Y" : "N", i => i == "Y");
            builder.Property(i => i.RePriceCost1).HasColumnName("RE_PRICE_COST1");
            builder.Property(i => i.RePriceCost2).HasColumnName("RE_PRICE_COST2");
            builder.Property(i => i.RePriceCost3).HasColumnName("RE_PRICE_COST3");
            builder.Property(i => i.AdjustClause).HasColumnName("ADJUST_CLAUSE");
            builder.Property(i => i.CorpId).HasColumnName("CORP_ID");
            builder.Property(i => i.OpeningDateAproved).HasColumnName("OPENING_DATE_APROVED");
            builder.Property(i => i.CompletedDateAproved).HasColumnName("COMPLETED_DATE_APROVED");
            builder.Property(i => i.IdSessionCapex).HasColumnName("ID_SESSION_CAPEX");
            builder.Property(i => i.RepEstado).HasColumnName("REP_ESTADO");
            builder.Property(i => i.Publicable).HasColumnName("PUBLICABLE")
                .HasConversion(i => i ? "S" : "N", i => i == "Y" || i == "S");
            builder.Property(i => i.LatitudeDegrees).HasColumnName("LATITUDE_DEGREES");
            builder.Property(i => i.LatitudeMinutes).HasColumnName("LATITUDE_MINUTES");
            builder.Property(i => i.LatitudeSecond).HasColumnName("LATITUDE_SECOND");
            builder.Property(i => i.LatitudeHemisphere).HasColumnName("LATITUDE_HEMISPHERE");
            builder.Property(i => i.LongitudeDegrees).HasColumnName("LONGITUDE_DEGREES");
            builder.Property(i => i.LongitudeMinutes).HasColumnName("LONGITUDE_MINUTES");
            builder.Property(i => i.LongitudeSecond).HasColumnName("LONGITUDE_SECOND");
            builder.Property(i => i.LongitudeHemisphere).HasColumnName("LONGITUDE_HEMISPHERE");
            builder.Property(i => i.CapStaffCosts).HasColumnName("CAP_STAFF_COSTS");
            builder.Property(i => i.RePriceCost3Gap).HasColumnName("RE_PRICE_COST3_GAP");
            builder.Property(i => i.PreOpeningCostGap).HasColumnName("PRE_OPENING_COST_GAP");
            builder.Property(i => i.OthersCostGap).HasColumnName("OTHERS_COST_GAP");
            builder.Property(i => i.KeyMoneyGap).HasColumnName("KEY_MONEY_GAP");
            builder.Property(i => i.LandCostGap).HasColumnName("LAND_COST_GAP");
            builder.Property(i => i.BudgCostGap).HasColumnName("BUDG_COST_GAP");
            builder.Property(i => i.CapStaffCostsGap).HasColumnName("CAP_STAFF_COSTS_GAP");
            builder.Property(i => i.InitialFranchiseFeeGap).HasColumnName("INITIAL_FRANCHISE_FEE_GAP");
            builder.Property(i => i.EquipCostGap).HasColumnName("EQUIP_COST_GAP");
            builder.Property(i => i.IdProject).HasColumnName("ID_PROJECT");
            builder.Property(i => i.StoreId).HasColumnName("STORE_ID");
            builder.Property(i => i.StateProvinceId).HasColumnName("STATE_PROVINCE_ID");
            builder.Property(i => i.MinimarketId).HasColumnName("MINIMARKET_ID");
            builder.Property(i => i.LatitudeDecimal).HasColumnName("LATITUDE_DECIMAL");
            builder.Property(i => i.LongitudeDecimal).HasColumnName("LONGITUDE_DECIMAL");
            builder.Ignore(i => i.UserApprovedTibco);
            builder.Ignore(i => i.DateRequiredTibco);
            builder.Property(i => i.DecorId).HasColumnName("DECOR_ID");
            builder.Property(i => i.FacadeId).HasColumnName("FACADE_ID");
            builder.Property(i => i.FamilySegmentId).HasColumnName("FAMILY_SEGMENT_ID");
            builder.HasOne(i => i.ProjectManager)
                           .WithMany()
                           .HasForeignKey(i => new
                           {
                               i.PaisId,
                               ValueListId = i.ProjectManagerId
                           })
                           .HasPrincipalKey(i => new
                           {
                               i.PaisId,
                               i.ValueListId
                           });

            builder.HasOne(i => i.Reps)
                .WithMany()
                .HasForeignKey(i => new { i.PaisId, ValueListId = i.RepId })
                .HasPrincipalKey(i => new { i.PaisId, i.ValueListId });

            builder.HasOne(i => i.RepStoreProjections).WithOne(i => i.RepStores)
                .HasForeignKey<RepStoreProjections>(i => new { i.PaisId, i.Id })
                .HasPrincipalKey<RepStores>(i => new { i.PaisId, i.Id });

            builder.HasMany(i => i.RepStoreDetailProjections)
                .WithOne(i => i.RepStores)
                .HasForeignKey(i => new { i.Id, i.PaisId })
                .HasPrincipalKey(i => new { i.Id, i.PaisId });

            builder.HasOne(i => i.RepStoreROI)
                   .WithOne()
                   .HasForeignKey<RepStoresRoi>(i => new { i.PaisId, Id = i.RepStoreId })
                   .HasPrincipalKey<RepStores>(i => new { i.PaisId, i.Id });

            builder.HasMany(i => i.ParRepStoresRelated)
                  .WithOne(i => i.ParRepStores)
                  .HasForeignKey(i => new { i.PaisId, Id = i.ParRepId })
                  .HasPrincipalKey(i => new { i.PaisId, i.Id });

            builder.HasMany(i => i.RepStoresRelated)
                  .WithOne(i => i.RepStores)
                  .HasForeignKey(i => new { i.PaisId, Id = i.RepId })
                  .HasPrincipalKey(i => new { i.PaisId, i.Id });

            builder.HasOne(i => i.RepStoresHistStatus)
                  .WithOne()
                  .HasForeignKey<RepStoresHistStatus>(i => new { i.PaisId, Id = i.RepId })
                  .HasPrincipalKey<RepStores>(i => new { i.PaisId, i.Id });

            builder.HasOne(i => i.RepStoresFreeze)
                  .WithOne()
                  .HasForeignKey<RepStoresFreeze>(i => new { i.PaisId, Id = i.Id })
                  .HasPrincipalKey<RepStores>(i => new { i.PaisId, i.Id });

            builder.HasOne(i => i.RepStoresDatesAudit)
                  .WithOne()
                  .HasForeignKey<RepStoresDatesAudit>(i => new { i.PaisId, Id = i.Id })
                  .HasPrincipalKey<RepStores>(i => new { i.PaisId, i.Id });

            builder.HasOne(i => i.LogProcessTibcoRep)
                  .WithOne()
                  .HasForeignKey<LogProcessTibcoRep>(i => new { i.PaisId, Id = i.IdRep })
                  .HasPrincipalKey<RepStores>(i => new { i.PaisId, i.Id });

            builder.HasOne(i => i.HistRepStores)
                  .WithOne()
                  .HasForeignKey<HistRepStores>(i => new { i.PaisId, Id = i.Id })
                  .HasPrincipalKey<RepStores>(i => new { i.PaisId, i.Id });

            builder.HasMany(i => i.RepStoreDetProjFreeze)
                  .WithOne()
                  .HasForeignKey(i => new { i.PaisId, Id = i.Id })
                  .HasPrincipalKey(i => new { i.PaisId, i.Id });

            builder.HasOne(i => i.RepStoreProjFreeze)
                  .WithOne()
                  .HasForeignKey<RepStoreProjFreeze>(i => new { i.PaisId, Id = i.Id })
                  .HasPrincipalKey<RepStores>(i => new { i.PaisId, i.Id });

            builder.HasOne(i => i.CapexInit)
                  .WithOne(i => i.RepStores)
                  .HasForeignKey<CapexInit>(i => new { i.PaisId, Id = i.RepStoresId })
                  .HasPrincipalKey<RepStores>(i => new { i.PaisId, Id = i.Id });
        }
    }
}
