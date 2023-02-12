using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuellaDBProject.Models
{
    public partial class GradesTbl
    {
        public int GradesId { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public int? EmployeeId { get; set; }
        public int? EnrollmentId { get; set; }
        public string Grade { get; set; }
        public DateTime? GradesDateSet { get; set; }

        public virtual CourseTbl Course { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
        public virtual EnrollmentTbl Enrollment { get; set; }
        public virtual StudentTbl Student { get; set; }
    }
}
