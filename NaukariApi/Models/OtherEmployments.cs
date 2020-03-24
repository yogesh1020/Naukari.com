using System;
using System.Collections.Generic;

namespace Naukari.Models
{
    public partial class OtherEmployments
    {
        public int OtherEmploymentId { get; set; }
        public int EmploymentId { get; set; }
        public string Designation { get; set; }
        public string Company { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Employments Employment { get; set; }
    }
}
