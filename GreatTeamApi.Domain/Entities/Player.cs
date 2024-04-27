using GreatTeamApi.Domain.Enums;

namespace GreatTeamApi.Domain.Entities
{
    public class Player : BaseEntity
    {
        public required string Name { get; set; }
        public ContractStatusEnum ContractStatus { get; set; }
    }
}
