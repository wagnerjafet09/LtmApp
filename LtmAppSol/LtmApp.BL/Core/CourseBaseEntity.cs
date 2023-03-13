using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.BL.Core
{
    public abstract class CourseBaseEntity
    {
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
    }
}
