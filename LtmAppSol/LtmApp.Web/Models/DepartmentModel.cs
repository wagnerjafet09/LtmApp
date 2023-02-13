using LtmApp.Web.Exceptions;
using System;

namespace LtmApp.Web.Models
{
    public class DepartmentModel
    {
        private int departmentId;
        public int DepartmentID
        {
            get { return departmentId; }
            set
            {
                if (value == 0)
                {
                    throw new DepartmentException("DepartmentId no puede ser nulo");
                }
                else
                {
                    departmentId = value;
                }
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new DepartmentException("El campo nombre es requerido");
                }
                else if (value.Length > 50)
                {
                    throw new DepartmentException("La longitud del nombre es inválida");
                }
                else
                {
                    name = value;
                }
            }
        }

        private double budget;
        public double Budget
        {
            get { return budget; }
            set
            {
                if (value == 0)
                {
                    throw new DepartmentException("El campo Budget no puede ser nulo");
                }
                else
                {
                    budget = value;
                }
            }
        }

        public DateTime StartDate { get; set; }
        public int Administrator { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public int CreationUser { get; set; }
        public int UserMod { get; set; }
        public int UserDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
