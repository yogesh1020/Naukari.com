using System;
using System.Collections.Generic;

namespace Naukari.Models
{
    public partial class Educations
    {
        public Educations()
        {
            }

        public int EducationId { get; set; }
        public int UserId { get; set; }
        public string HighestQualification { get; set; }
        public string Course { get; set; }
        public string Specialization { get; set; }
        public string University { get; set; }
        public string CourseType { get; set; }
        public string PassingYear { get; set; }
        public string Skill { get; set; }


    }
}
