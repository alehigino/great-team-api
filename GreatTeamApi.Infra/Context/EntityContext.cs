using GreatTeamApi.Infra.Data.EntityTypesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace GreatTeamApi.Infra.Data.Context
{
    public class EntityContext(DbContextOptions<EntityContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ApplyEntityConfiguration(modelBuilder);
        }

        private void ApplyEntityConfiguration(ModelBuilder modelBuilder)
        {
            var entityConfigTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(e => e.GetTypes())
                .Where(w => typeof(IEntityConfig).IsAssignableFrom(w) && !w.IsInterface && !w.IsAbstract)
                .ToList();

            var entityConfigInstances = entityConfigTypes.Select(ec => (IEntityConfig)Activator.CreateInstance(ec));

            foreach (var entityConfig in entityConfigInstances) { entityConfig.ApplyConfiguration(modelBuilder); }
        }
    }
}
