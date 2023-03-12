using System;

namespace LtmApp.BL.Dtos
{
    public abstract class DepartmentBaseDto 
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }

    }
}
