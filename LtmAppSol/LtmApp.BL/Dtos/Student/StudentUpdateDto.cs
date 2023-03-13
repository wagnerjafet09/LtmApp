using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.BL.Dtos.Student
{
    public class StudentUpdateDto
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public int? UserMod { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
