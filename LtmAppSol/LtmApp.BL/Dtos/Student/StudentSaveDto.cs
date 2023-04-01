using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.BL.Dtos.Student
{
    public class StudentSaveDto : StudentBaseDto
    {
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
    }
}
