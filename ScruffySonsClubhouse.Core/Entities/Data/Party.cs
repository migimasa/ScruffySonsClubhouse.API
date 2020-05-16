using ScruffySonsClubhouse.SharedKernel;
using System.Collections.Generic;

namespace ScruffySonsClubhouse.Core.Entities.Data
{
    public class Party : BaseEntity
    {
        public string PartyName { get; set; }
        public int MaxNumberOfPlayers { get; set; }
        public Gamemaster Gamemaster { get; set; }
        public List<Character> Characters { get; set; }
    }
}
