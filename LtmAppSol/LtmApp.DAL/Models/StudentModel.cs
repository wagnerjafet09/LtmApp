using LtmApp.DAL.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.DAL.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
