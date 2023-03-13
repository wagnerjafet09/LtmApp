using LtmApp.BL.Core;
using System;

namespace LtmApp.BL.Dto.Course
{
    public class CourseUpdateDto : CourseBaseEntity
    {
        public int CourseID { get; set; }
        public int UserMod { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
