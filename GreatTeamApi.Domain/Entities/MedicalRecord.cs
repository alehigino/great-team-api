using GreatTeamApi.Domain.Enums;

namespace GreatTeamApi.Domain.Entities
{
    public class MedicalRecord : BaseEntity
    {
        public Guid PlayerId { get; set; }
        public InjuryTypeEnum InjuryType { get; set; }

        public required virtual Player Player { get; set; }
    }
}
