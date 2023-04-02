using System;

namespace LtmApp.Web.Models.Responses
{
    public class CourseUpdateRequest
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public DateTime ModifyDate { get; set; }
        public int UserMod { get; set; }
    }
}
