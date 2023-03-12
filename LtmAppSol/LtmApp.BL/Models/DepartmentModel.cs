using System;

namespace LtmApp.BL.Models
{
    public class DepartmentModel
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string StartDateDisplay 
        {
            get { return this.StartDate.ToString("dd/MM/yy"); }
        }
        public string CreationDateDisplay 
        {
            get { return this.CreateDate.ToString("dd/MM/yy"); } 
        }
    }
}
