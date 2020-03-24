using System;
using System.Collections.Generic;

namespace Naukari.Models
{
    public partial class Users
    {
        public Users()
        {
            Educations = new Educations();
            Employments = new Employments();
            UserObjectType = new HashSet<UserObjectType>();
        }

        public int UserId { get; set; }
        public int Name { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string CurrentLocation { get; set; }
        public string Country { get; set; }
        public string CityName { get; set; }
        public string Resume { get; set; }


        public Educations Educations { get; set; }
        public Employments Employments { get; set; }
        public ICollection<UserObjectType> UserObjectType { get; set; }
    }
}
