using ScruffySonsClubhouse.Core.Entities.Lookups;
using ScruffySonsClubhouse.SharedKernel;
using System.Collections.Generic;

namespace ScruffySonsClubhouse.Core.Entities.Data
{
    public class Character : BaseEntity
    {
        public Player Player { get; set; }
        public string Name { get; set; }
    }
}
