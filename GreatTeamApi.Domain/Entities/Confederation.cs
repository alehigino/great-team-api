namespace GreatTeamApi.Domain.Entities
{
    public class Confederation : BaseEntity
    {
        public Guid PlayerId { get; set; }
        public required string Team { get; set; }
        public DateTime CreatedAt { get; set; }

        public required virtual Player Player { get; set; }
    }
}
