using ScruffySonsClubhouse.Core.Entities.Lookups;
using ScruffySonsClubhouse.SharedKernel;
using System.Collections.Generic;

namespace ScruffySonsClubhouse.Core.Entities.Data
{
    public class Character : BaseEntity
    {
        public Player Player { get; set; }
        public string Name { get; set; }
        public List<Obligation> Obligations { get; set; }
        public Species Species { get; set; }
        public Career Career { get; set; }
        public List<Specialization> Specializations { get; set; }
        public int SoakValue { get; set; }
        public int WoundThreshold { get; set; }
        public int CurrentWounds { get; set; }
        public int StrainThreshold { get; set; }
        public int CurrentStrain { get; set; }
        public int RangedDefense { get; set; }
        public int MeleeDefense { get; set; }
        public int Brawn { get; set; }
        public int Agility { get; set; }
        public int Intellect { get; set; }
        public int Cunning { get; set; }
        public int Willpower { get; set; }
        public int Presence { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Weapon> Weapons { get; set; }
    }
}
