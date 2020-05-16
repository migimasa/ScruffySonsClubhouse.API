using ScruffySonsClubhouse.Core.Entities.Configuration;
using System.Collections.Generic;

namespace ScruffySonsClubhouse.Core.Entities.Lookups
{
    public class Species : BaseLookupEntity
    {
        public string PhysiologyDescription { get; set; }
        public string SocietyDescription { get; set; }
        public string HomeworldDescription { get; set; }
        public string LanguageDescription { get; set; }
        public string LifeOnTheFringeDescription { get; set; }
        public int StartingBrawn { get; set; }
        public int StartingAbility { get; set; }
        public int StartingIntellect { get; set; }
        public int StartingCunning { get; set; }
        public int StartingWillpower { get; set; }
        public int StartingPresence { get; set; }
        public int WoundThreshold { get; set; }
        public int StrainThreshold { get; set; }
        public int StartingExperience { get; set; }
        public List<SpeciesSkill> StartingSkills { get; set; }
        public List<SpeciesTalent> StartingTalents { get; set; }
        public int CyberneticImplantCap { get; set; }
        public int StartingCareerSkillsCap { get; set; }
        public int StartingSpecialitzationSkillsCap { get; set; }
    }
}
