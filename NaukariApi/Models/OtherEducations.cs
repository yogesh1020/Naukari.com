using System;
using System.Collections.Generic;

namespace Naukari.Models
{
    public partial class OtherEducations
    {
        public int OtherEducationId { get; set; }
        public int EducationId { get; set; }
        public string Qualification { get; set; }
        public string Course { get; set; }
        public string Specialization { get; set; }
        public string University { get; set; }
        public string PassingYear { get; set; }

        public Educations Education { get; set; }
    }
}
