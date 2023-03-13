using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.BL.Dtos.Student
{
    public class StudentSaveDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
    }
}
