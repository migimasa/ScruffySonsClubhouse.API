using ScruffySonsClubhouse.SharedKernel;
using System;

namespace ScruffySonsClubhouse.Core.Entities.Lookups
{
    public class BaseLookupEntity : BaseEntity
    {
        public string Name { get; set; }
        public string NameKey { get; set; }
        public string DetailDescription { get; set; }
        public int SortOrder { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateUser { get; set; }

    }
}
