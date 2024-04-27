using GreatTeamApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreatTeamApi.Infra.Data.EntityTypesConfiguration
{
    public class MedicalRecordConfig : BaseEntityConfig<MedicalRecord>, IEntityConfig
    {
        public override void Configure(EntityTypeBuilder<MedicalRecord> builder)
        {
            builder.ToTable("medical_record");

            builder.HasKey(e => e.Id);

            builder
                .Property(e => e.Id)
                .HasColumnName("id")
                .IsRequired();

            builder
                .Property(e => e.PlayerId)
                .HasColumnName("player_id")
                .IsRequired();

            builder
                .Property(e => e.InjuryType)
                .HasColumnName("injury_type")
                .IsRequired();

            builder
                .HasOne(e => e.Player)
                .WithMany()
                .HasForeignKey(e => e.PlayerId);
        }
    }
}
