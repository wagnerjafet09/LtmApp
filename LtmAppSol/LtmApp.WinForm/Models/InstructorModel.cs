using System;
using LtmApp.WinForm.Exceptions;

namespace LtmApp.WinForm.Models
{
    public class InstructorModel : PersonModel
    {
        private int instructorId;
        public int InstructorId
        {
            get { return this.instructorId; }
            set
            {
                if ((value) == null)
                {
                    throw new StudentException("El campo Id es requerido");
                }
            }
        }

        public DateTime HireDate { get; set; }
    }
}
