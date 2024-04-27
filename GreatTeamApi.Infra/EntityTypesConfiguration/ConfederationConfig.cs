using GreatTeamApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreatTeamApi.Infra.Data.EntityTypesConfiguration
{
    public class ConfederationConfig : BaseEntityConfig<Confederation>, IEntityConfig
    {
        public override void Configure(EntityTypeBuilder<Confederation> builder)
        {
            builder.ToTable("confederation");

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
                .Property(e => e.Team)
                .HasColumnName("team")
                .HasMaxLength(128)
                .IsRequired();

            builder
                .Property(e => e.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired();

            builder
                .HasOne(e => e.Player)
                .WithMany()
                .HasForeignKey(e => e.PlayerId);
        }
    }
}
