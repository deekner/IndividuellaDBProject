using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuellaDBProject.Models
{
    public partial class JunctionTbl
    {
        public int JunctionId { get; set; }
        public int? ClassId { get; set; }
        public int? EnrollmentId { get; set; }

        public virtual ClassTbl Class { get; set; }
        public virtual EnrollmentTbl Enrollment { get; set; }
    }
}
