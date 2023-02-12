using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuellaDBProject.Models
{
    public partial class ClassTbl
    {
        public ClassTbl()
        {
            JunctionTbl = new HashSet<JunctionTbl>();
            StudentTbl = new HashSet<StudentTbl>();
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<JunctionTbl> JunctionTbl { get; set; }
        public virtual ICollection<StudentTbl> StudentTbl { get; set; }
    }
}
