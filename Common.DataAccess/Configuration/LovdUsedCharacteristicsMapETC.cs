using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class LovdUsedCharacteristicsMapETC : IEntityTypeConfiguration<LovdUsedCharacteristicsMap>
    {
        public void Configure(EntityTypeBuilder<LovdUsedCharacteristicsMap> builder)
        {
        
            builder.ToTable("LOVD_USED_CHARACTERISTICS_MAP", "CARAC")
                .HasKey(i => new { i.PaisId,  i.ValueListId, i.UsedCharId });

            builder.Property(i => i.ListId).HasColumnName("LIST_ID");
            builder.Property(i => i.UsedCharId).HasColumnName("USED_CHAR_ID");
            builder.Property(i => i.ValueListId).HasColumnName("VALUE_LIST_ID");
            builder.Property(i => i.Description).HasColumnName("DESCRIPTION");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.PmoValueId).HasColumnName("PMO_VALUE_ID");
            builder.Property(i => i.PmoCharValueId).HasColumnName("PMO_CHAR_VALUE_ID");
            builder.Property(i => i.DescriptionRoip).HasColumnName("DESCRIPTION_ROIP");
            builder.Property(i => i.ListOrder).HasColumnName("LIST_ORDER");
            builder.Property(i => i.DescriptionShort).HasColumnName("DESCRIPTION_SHORT");
            builder.Property(i => i.ListIdFather).HasColumnName("LIST_ID_FATHER");
            builder.Property(i => i.ValueListIdFather).HasColumnName("VALUE_LIST_ID_FATHER");
            builder.Property(i => i.IsActive).HasColumnName("ACTIVE")
                .HasConversion(i => i ? "Y" : "N", i => i == "Y");
            builder.Property(i => i.PmoRelation).HasColumnName("PMO_RELATION");

            //builder.HasOne(i => i.ListOfValues)
            //    .WithMany(i => i.ListOfValueDetails)
            //    .HasForeignKey(i => new { i.PaisId, i.ListId });

            builder.HasOne(i => i.UsedCharacteristics)
                .WithMany(i => i.LovdUsedCharacteristicsMap)
                .HasForeignKey(i => new { i.PaisId, i.ListId });

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<ProjectManagers>((int)UsedCharacteristics.UsedCharacteristicsIDs.ProjectManager);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<Reps>((int)UsedCharacteristics.UsedCharacteristicsIDs.Rep);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<Cities>((int)UsedCharacteristics.UsedCharacteristicsIDs.City);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<Brokers>((int)UsedCharacteristics.UsedCharacteristicsIDs.Broker);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<Architects>((int)UsedCharacteristics.UsedCharacteristicsIDs.Architect);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<Contractors>((int)UsedCharacteristics.UsedCharacteristicsIDs.Contractor);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<Minimarkets>((int)UsedCharacteristics.UsedCharacteristicsIDs.Minimaket);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<StoreTypes>((int)UsedCharacteristics.UsedCharacteristicsIDs.StoreType);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<TypeOfDeals>((int)UsedCharacteristics.UsedCharacteristicsIDs.TypeOfDeal);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<Ownerships>((int)UsedCharacteristics.UsedCharacteristicsIDs.Ownership);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<Decores>((int)UsedCharacteristics.UsedCharacteristicsIDs.Decor);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<Facades>((int)UsedCharacteristics.UsedCharacteristicsIDs.Facade);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<FamilySegmentations>((int)UsedCharacteristics.UsedCharacteristicsIDs.FamilySegmentation);

            builder.HasDiscriminator(i => i.UsedCharId)
                    .HasValue<Regions>((int)UsedCharacteristics.UsedCharacteristicsIDs.Region);

            builder.HasOne(i => i.UserRep)
                      .WithOne()
                      .HasForeignKey<UsersProjectManagersReps>(i => new
                      {
                          i.PaisId,
                          Id = i.RepId
                      })
                      .HasPrincipalKey<LovdUsedCharacteristicsMap>(i => new
                      {
                          i.PaisId,
                          i.ValueListId
                      });

            builder.HasOne(i => i.UserProjectManager)
                  .WithOne()
                  .HasForeignKey<UsersProjectManagersReps>(i => new { i.PaisId, Id = i.ProjectManagerId })
                  .HasPrincipalKey<LovdUsedCharacteristicsMap>(i => new { i.PaisId, i.ValueListId });

        }
    }
}
