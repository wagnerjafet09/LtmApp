using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.BL.Models
{
    public class CourseResultModel
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationDateDisplay
        {
            get { return this.CreationDate.ToString("dd/MM/yyyy"); }
        }
    }
}
