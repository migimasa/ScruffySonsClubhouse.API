using ScruffySonsClubhouse.Core.Entities.Lookups;
using ScruffySonsClubhouse.SharedKernel;

namespace ScruffySonsClubhouse.Core.Entities.Data
{
    public class CharacterSkill : BaseEntity
    {
        public Character Character { get; set; }
        public Skill Skill { get; set; }
        public int Rank { get; set; }
        public bool IsCareerSkill { get; set; }
    }
}
