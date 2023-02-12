using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuellaDBProject.Models
{
    public partial class EmployeeTbl
    {
        public EmployeeTbl()
        {
            CourseTbl = new HashSet<CourseTbl>();
            GradesTbl = new HashSet<GradesTbl>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? DateOfEmployment { get; set; }
        public string Role { get; set; }

        public virtual ICollection<CourseTbl> CourseTbl { get; set; }
        public virtual ICollection<GradesTbl> GradesTbl { get; set; }
    }
}
