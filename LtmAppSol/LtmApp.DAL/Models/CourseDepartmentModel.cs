using System;

namespace LtmApp.DAL.Models
{
    public class CourseDepartmentModel
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public string Department { get; set; }
        public DateTime CreationDate { get; set; }
    }
}