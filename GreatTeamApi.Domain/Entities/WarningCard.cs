using GreatTeamApi.Domain.Enums;

namespace GreatTeamApi.Domain.Entities
{
    public class WarningCard : BaseEntity
    {
        public Guid PlayerId { get; set; }
        public CardTypeEnum CardType { get; set; }

        public required virtual Player Player { get; set; }
    }
}
