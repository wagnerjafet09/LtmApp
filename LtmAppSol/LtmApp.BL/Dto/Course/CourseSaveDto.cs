using LtmApp.BL.Core;
using System;

namespace LtmApp.BL.Dto.Course
{
    public class CourseSaveDto : CourseBaseEntity
    {
        public int CreationUser { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
