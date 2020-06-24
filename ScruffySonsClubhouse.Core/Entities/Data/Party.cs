using ScruffySonsClubhouse.SharedKernel;
using System.Collections.Generic;

namespace ScruffySonsClubhouse.Core.Entities.Data
{
    public class Party : BaseEntity
    {
        public string Name { get; set; }
        public List<Character> Characters { get; set; }
    }
}
