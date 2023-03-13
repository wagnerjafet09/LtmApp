using LtmApp.BL.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.BL.Dto.Course
{
    public class CourseRemoveDto
    {
        public int CourseID { get; set; }
        public int? UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
