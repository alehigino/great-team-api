using Microsoft.EntityFrameworkCore;

namespace GreatTeamApi.Infra.Data.EntityTypesConfiguration
{
    public interface IEntityConfig
    {
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}
