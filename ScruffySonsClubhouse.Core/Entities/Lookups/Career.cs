using ScruffySonsClubhouse.SharedKernel;
using System.Collections.Generic;

namespace ScruffySonsClubhouse.Core.Entities.Lookups
{
    public class Career : BaseEntity
    {
        public List<Specialization> Specializations { get; set; }
    }
}
