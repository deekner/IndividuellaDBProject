using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuellaDBProject.Models
{
    public partial class CourseTbl
    {
        public CourseTbl()
        {
            EnrollmentTbl = new HashSet<EnrollmentTbl>();
            GradesTbl = new HashSet<GradesTbl>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int? EmployeeId { get; set; }
        public bool IsActive { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual ICollection<EnrollmentTbl> EnrollmentTbl { get; set; }
        public virtual ICollection<GradesTbl> GradesTbl { get; set; }
    }
}
