
using System;

namespace LtmApp.BL.Dtos
{
    public class DepartmentAddDto : DepartmentBaseDto
    {
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
    }
}
