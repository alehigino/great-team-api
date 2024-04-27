using GreatTeamApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreatTeamApi.Infra.Data.EntityTypesConfiguration
{
    public class WarningCardConfig : BaseEntityConfig<WarningCard>, IEntityConfig
    {
        public override void Configure(EntityTypeBuilder<WarningCard> builder)
        {
            builder.ToTable("warning_card");

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
                .Property(e => e.CardType)
                .HasColumnName("card_type")
                .IsRequired();

            builder
                .HasOne(e => e.Player)
                .WithMany()
                .HasForeignKey(e => e.PlayerId);
        }
    }
}
