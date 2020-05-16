using ScruffySonsClubhouse.Core.Entities.Lookups;
using ScruffySonsClubhouse.SharedKernel;

namespace ScruffySonsClubhouse.Core.Entities.Data
{
    public class CharacterObligation : BaseEntity
    {
        public Character Character { get; set; }
        public Obligation Obligation { get; set; }
        public int ObligationValue { get; set; }
    }
}
