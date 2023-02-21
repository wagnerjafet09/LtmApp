using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.DAL.Models
{
    public class CourseModel
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
