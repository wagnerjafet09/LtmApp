using System;

namespace LtmApp.Web.Models.Requests
{
    public class StudentUpdateRequest
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public DateTime EnrollmentDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public int UserMod { get; set; }
    }
}
