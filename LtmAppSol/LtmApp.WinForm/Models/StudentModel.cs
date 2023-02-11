using System;
using LtmApp.WinForm.Exceptions;

namespace LtmApp.WinForm.Models
{
    public class StudentModel
    {
        private int studentId;
        public int StudentId
        {
            get { return this.studentId; }
            set
            {
                if ((value) == null)
                {
                    throw new StudentException("El campo Id es requerido");
                }
            }
        }
        private DateTime enrollmentDate;
        public DateTime EnrollmentDate
        {
            get { return this.enrollmentDate; }
            set
            {
                if ((value) == null)
                {
                    throw new StudentException("El campo nombre es requerido");
                }
            }
        }
    }
}
