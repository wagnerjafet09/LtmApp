using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.BL.Dtos.Student
{
    public abstract class StudentBaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? EnrollmentDate { get; set; }
    }
}
