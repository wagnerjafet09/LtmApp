using System;

namespace LtmApp.BL.Dtos
{
    public class DepartmentRemoveDto 
    {
        public int DepartmentId { get; set; }
        public DateTime RemoveDate { get; set; }
        public int RemoveUser { get; set; }
    }
}
