using System;
using System.Collections.Generic;
using System.Linq;

namespace Chloe.Server.Models
{
    public class Customer: BaseEntity
    {
        
        public string DefaultProfileName { get { return this.Profiles.FirstOrDefault()?.Name; } }
        public ICollection<Profile> Profiles { get; set; } = new HashSet<Profile>();
    }
}
