using GreatTeamApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GreatTeamApi.Infra.Data.EntityTypesConfiguration
{
    public class PlayerConfig : BaseEntityConfig<Player>, IEntityConfig
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("player");

            builder.HasKey(e => e.Id);

            builder
                .Property(e => e.Id)
                .HasColumnName("id")
                .IsRequired();

            builder
                .Property(e => e.Name)
                .HasColumnName("name")
                .HasMaxLength(128)
                .IsRequired();

            builder
                .Property(e => e.ContractStatus)
                .HasColumnName("contract_status")
                .IsRequired();
        }
    }
}
