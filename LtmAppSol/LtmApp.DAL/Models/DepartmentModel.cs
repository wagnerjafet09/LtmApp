using System;

namespace LtmApp.DAL.Models
{
    public class DepartmentModel
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
    }
}
