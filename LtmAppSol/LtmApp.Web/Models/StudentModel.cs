using LtmApp.Web.Exceptions;
using System;

namespace LtmApp.Web.Models
{
    public class StudentModel : PersonModel
    {
        private int studentId;
        public int StudentId
        { 
            get { return studentId; }
            set 
            {
                if (value == 0)
                {
                    throw new StudentException("StudentId no puede ser null");
                }
                else 
                {
                    studentId = value;
                }
            }
        }

        public DateTime EnrollmentDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public int CreationUser { get; set; }
        public int UserMod { get; set; }
        public int UserDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
