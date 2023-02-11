using LtmApp.WinForm.Exceptions;

namespace LtmApp.WinForm.Models
{
    internal class CourseModel
    {
        private int courseId;
        public int CourseId
        {
            get { return this.courseId; }
            set
            {
                if ((value) == null)
                {
                    throw new StudentException("El campo CourseId es requerido");
                }
            }
        }
        private string title;
        public string Title
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new StudentException("El campo titulo es requerido");
                }
                else if (value.Length > 100)
                {
                    throw new StudentException("La longitud del titulo es invalida");
                }
            }
        }
        private int credits;
        public int Credits
        {
            get { return this.credits; }
            set
            {
                if ((value) == null)
                {
                    throw new StudentException("El campo Credits es requerido");
                }
            }
        }
        private int departmentId;
        public int DepartmentId
        {
            get { return this.departmentId; }
            set
            {
                if ((value) == null)
                {
                    throw new StudentException("El campo DepartmentId es requerido");
                }
            }
        }
    }
}
