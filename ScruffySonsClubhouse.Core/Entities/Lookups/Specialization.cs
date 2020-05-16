using ScruffySonsClubhouse.Core.Entities.Configuration;
using System.Collections.Generic;

namespace ScruffySonsClubhouse.Core.Entities.Lookups
{
    public class Specialization : BaseLookupEntity
    {
        public List<SpecializationSkill> Skills { get; set; }
        public List<SpecializationTalent> TalentTree { get; set; }
    }
}
