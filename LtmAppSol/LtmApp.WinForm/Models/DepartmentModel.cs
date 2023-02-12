using System;
using LtmApp.WinForm.Exceptions;

namespace LtmApp.WinForm.Models
{
    public class DepartmentModel
    {
        private int departmentId;
        public int DepartmentId
        {
            get { return this.departmentId; }
            set
            {
                if ((value) == null)
                {
                    throw new StudentException("El campo Id es requerido");
                }
            }
        }

        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new StudentException("El campo name es requerido");
                }
                else if (value.Length > 50)
                {
                    throw new StudentException("La longitud del name es invalida");
                }
            }
        }

        private int budget;
        public int Budget
        {
            get { return this.budget; }
            set
            {
                if ((value) == null)
                {
                    throw new StudentException("El campo budget es requerido");
                }
            }
        }

        private DateTime startDate;
        public DateTime StartDate
        {
            get { return this.startDate; }
            set
            {
                if ((value) == null)
                {
                    throw new StudentException("El campo Id es requerido");
                }
            }
        }
    }
}
