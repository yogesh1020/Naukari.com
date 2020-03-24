using System;
using System.Collections.Generic;

namespace Naukari.Models
{
    public partial class UserObjectType
    {
        public UserObjectType()
        {
            UserObject = new HashSet<UserObject>();
        }

        public int UserObjectTypeId { get; set; }
        public int UserId { get; set; }

        public Users User { get; set; }
        public ICollection<UserObject> UserObject { get; set; }
    }
}
