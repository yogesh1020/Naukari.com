using System;
using System.Collections.Generic;

namespace Naukari.Models
{
    public partial class UserObject
    {
        public int UserObjectId { get; set; }
        public int UserObjectTypeId { get; set; }
        public string UserObjectName { get; set; }

        public UserObjectType UserObjectType { get; set; }
    }
}
