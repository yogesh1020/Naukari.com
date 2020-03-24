using System;
using System.Collections.Generic;

namespace Naukari.Models
{
    public partial class Employments
    {
        public Employments()
        {
            
        }

        public int EmploymentId { get; set; }
        public int UserId { get; set; }
        public string CurrentDesignation { get; set; }
        public string CurrentCompany { get; set; }
        public string AnnualSalary { get; set; }
        public DateTime WorkStart { get; set; }
        public DateTime WorkEnd { get; set; }
        public string CurrentLocation { get; set; }
        public string Contry { get; set; }
        public string CityName { get; set; }
        public string NoticePeriod { get; set; }
        public string Skill { get; set; }
        public string Industry { get; set; }
        public string FunctionalArea { get; set; }
        public string Role { get; set; }


    }
}
