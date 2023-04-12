
using System;

namespace LtmApp.BL.Dtos
{
    public class DepartmentAddDto : DepartmentBaseDto
    {
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
    }
}
