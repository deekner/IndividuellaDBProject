using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuellaDBProject.Models
{
    public partial class StudentTbl
    {
        public StudentTbl()
        {
            EnrollmentTbl = new HashSet<EnrollmentTbl>();
            GradesTbl = new HashSet<GradesTbl>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ClassId { get; set; }

        public virtual ClassTbl Class { get; set; }
        public virtual ICollection<EnrollmentTbl> EnrollmentTbl { get; set; }
        public virtual ICollection<GradesTbl> GradesTbl { get; set; }
    }
}
