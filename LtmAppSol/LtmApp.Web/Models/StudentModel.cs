using LtmApp.Web.Exceptions;
using System;

namespace LtmApp.Web.Models
{
    public class StudentModel : PersonModel
    {
        private int _studentId;
        public int studentId
        { 
            get { return _studentId; }
            set 
            {
                if (value == 0)
                {
                    throw new StudentException("StudentId no puede ser null");
                }
                else 
                {
                    _studentId = value;
                }
            }
        }

        public DateTime enrollmentDate { get; set; }
    }
}
