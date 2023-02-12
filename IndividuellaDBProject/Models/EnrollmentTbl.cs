using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuellaDBProject.Models
{
    public partial class EnrollmentTbl
    {
        public EnrollmentTbl()
        {
            GradesTbl = new HashSet<GradesTbl>();
            JunctionTbl = new HashSet<JunctionTbl>();
        }

        public int EnrollmentId { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public int? EmployeeId { get; set; }

        public virtual CourseTbl Course { get; set; }
        public virtual StudentTbl Student { get; set; }
        public virtual ICollection<GradesTbl> GradesTbl { get; set; }
        public virtual ICollection<JunctionTbl> JunctionTbl { get; set; }
    }
}
