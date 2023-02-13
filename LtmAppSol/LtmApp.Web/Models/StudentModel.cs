using System;
using LtmApp.Web.Exceptions;

namespace LtmApp.Web.Models
{
    public class StudentModel : PersonModel
    {
        public int StudentId { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
