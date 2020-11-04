using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class StoresMoreETC  : IEntityTypeConfiguration<StoresMore>
    {
        public void Configure(EntityTypeBuilder<StoresMore> builder)
        {
            // Generación tabla: STORES_MORE
            builder.ToTable("STORES_MORE", "WHOUSE").HasKey(i => new
            {
                i.PaisId,
                i.StoreId
            });
            builder.Property(i => i.StoreId).HasColumnName("STORE_ID");
            builder.Property(i => i.Entity).HasColumnName("ENTITY");
            builder.Property(i => i.Acronym).HasColumnName("ACRONYM");
            builder.Property(i => i.Phone).HasColumnName("PHONE");
            builder.Property(i => i.StoreTypeId).HasColumnName("STORE_TYPE_ID");
            builder.Property(i => i.MailUser).HasColumnName("MAIL_USER");
            builder.Property(i => i.GroupId).HasColumnName("GROUP_ID");
            builder.Property(i => i.CostCenter).HasColumnName("COST_CENTER");
            builder.Property(i => i.OakStoreId).HasColumnName("OAK_STORE_ID");
            builder.Property(i => i.JournalSegment5).HasColumnName("JOURNAL_SEGMENT5");
            builder.Property(i => i.SendMail).HasColumnName("SEND_MAIL");
            builder.Property(i => i.AproxVol).HasColumnName("APROX_VOL");
            builder.Property(i => i.JournalSegment6).HasColumnName("JOURNAL_SEGMENT6");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.DcrId).HasColumnName("DCR_ID");
            builder.Property(i => i.ManagerName).HasColumnName("MANAGER_NAME");
            builder.Property(i => i.PhoneAreaCode).HasColumnName("PHONE_AREA_CODE");
            builder.Property(i => i.StoresPhone).HasColumnName("STORES_PHONE");
            builder.Property(i => i.District).HasColumnName("DISTRICT");
            builder.Property(i => i.Markup).HasColumnName("MARKUP");
            builder.Property(i => i.PhoneExtension).HasColumnName("PHONE_EXTENSION");
            builder.Property(i => i.PhonePrefixNumber).HasColumnName("PHONE_PREFIX_NUMBER");
            builder.Property(i => i.ObjEmployeeFood).HasColumnName("OBJ_EMPLOYEE_FOOD");
            builder.Property(i => i.ObjCompleteWaste).HasColumnName("OBJ_COMPLETE_WASTE");
            builder.Property(i => i.ObjIncompleteWaste).HasColumnName("OBJ_INCOMPLETE_WASTE");
            builder.Property(i => i.ObjCondimento).HasColumnName("OBJ_CONDIMENTO");
            builder.Property(i => i.ObjStat).HasColumnName("OBJ_STAT");
            builder.Property(i => i.ObjRendimiento).HasColumnName("OBJ_RENDIMIENTO");
            builder.Property(i => i.ObjDiferenciaInexplicable).HasColumnName("OBJ_DIFERENCIA_INEXPLICABLE");
            builder.Property(i => i.CompanyOakId).HasColumnName("COMPANY_OAK_ID");
            builder.Property(i => i.OakCompanyId).HasColumnName("OAK_COMPANY_ID");
            builder.Property(i => i.GbalPersId).HasColumnName("GBAL_PERS_ID");
            builder.Property(i => i.RestOprtEffDt).HasColumnName("REST_OPRT_EFF_DT");
            builder.Property(i => i.RestOprtEndDt).HasColumnName("REST_OPRT_END_DT");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.CreationUser).HasColumnName("CREATION_USER");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
            builder.Property(i => i.ModifyUser).HasColumnName("MODIFY_USER");
        }
    }
}
