using System;

namespace LtmApp.DAL.Exceptions
{
    public class DepartmentException : Exception
    {
        public DepartmentException(string message) : base(message)
        {
        }
    }

}