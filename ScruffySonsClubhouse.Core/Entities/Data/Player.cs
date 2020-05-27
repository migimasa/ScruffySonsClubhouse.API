using System;
using System.Collections.Generic;
using ScruffySonsClubhouse.SharedKernel;

namespace ScruffySonsClubhouse.Core.Entities.Data
{
    public class Player : BaseGuidEntity
    {
        public string Name { get; set; }
        public List<Character> Characters { get; set; }
    }
}
