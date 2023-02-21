using LtmApp.DAL.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.DAL.Models
{
    public class StudentModel : PersonModel
    {
        public int ID { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
