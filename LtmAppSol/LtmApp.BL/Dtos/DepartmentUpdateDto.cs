using System;

namespace LtmApp.BL.Dtos
{
    public class DepartmentUpdateDto : DepartmentBaseDto 
    {
        public int DepartmentId { get; set; }
        public DateTime ModifyDate { get; set; }
        public int ModifyUser { get; set; }
    }
}
