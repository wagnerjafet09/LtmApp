using LtmApp.Web.Exceptions;
using System;
using System.Diagnostics;

namespace LtmApp.Web.Models
{
    public class CourseModel
    {
        //private int courseId
        public int CourseId { get; set; }
        //            courseId = value;
        //        }
        //    }
        //}
        //private string title;
        public string Title { get; set; }  
        //{
        //    get { return title; }
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            throw new CourseException("El campo titulo es requerido");
        //        }
        //        else if (value.Length > 100)
        //        {
        //            throw new CourseException("La longitud del titulo es inválida");
        //        }
        //        else
        //        {
        //            title = value;
        //        }
        //    }
        //}

        //private int credits;
        public int Credits { get; set; }
        //{
        //    get { return credits; }
        //    set
        //    {
        //        if (value == 0)
        //        {
        //            throw new CourseException("Credits no puede ser nulo");
        //        }
        //        else
        //        {
        //            credits = value;
        //        }
        //    }
        //}
        //private int departmentId;
        public int DepartmentId { get; set; }
        //{
        //    get { return departmentId; }
        //    set
        //    {
        //        if (value == 0)
        //        {
        //            throw new CourseException("DepartmentId no puede ser nulo");
        //        }
        //        else
        //        {
        //            departmentId = value;
        //        }
        //    }
        //}

        public DateTime CreationDate { get; set; }

    }
}
