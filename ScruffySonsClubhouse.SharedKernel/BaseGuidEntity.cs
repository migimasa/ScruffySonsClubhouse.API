using System;
using System.Collections.Generic;

namespace ScruffySonsClubhouse.SharedKernel
{
    public class BaseGuidEntity
    {
        public Guid Id { get; set; }
        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}