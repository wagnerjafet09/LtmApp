using LtmApp.Web.Exceptions;
using System;


namespace LtmApp.Web.Models
{
    public class CourseModel
    {
        private int courseId;
        public int CourseId
        {
            get { return courseId; }
            set
            {
                if (value == 0)
                {
                    throw new CourseException("CourseId no puede ser nulo");
                }
                else
                {
                    courseId = value;
                }
            }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new CourseException("El campo titulo es requerido");
                }
                else if (value.Length > 100)
                {
                    throw new CourseException("La longitud del titulo es inválida");
                }
                else
                {
                    title = value;
                }
            }
        }
        private int credits;
        public int Credits
        {
            get { return credits; }
            set
            {
                if (value == 0)
                {
                    throw new CourseException("Credits no puede ser nulo");
                }
                else
                {
                    credits = value;
                }
            }
        }
        private int departmentId;
        public int DepartmentId
        {
            get { return departmentId; }
            set
            {
                if (value == 0)
                {
                    throw new CourseException("DepartmentId no puede ser nulo");
                }
                else
                {
                    departmentId = value;
                }
            }
        }
        public DateTime CreationDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public int CreationUser { get; set; }
        public int UserMod { get; set; }
        public int UserDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }




}
