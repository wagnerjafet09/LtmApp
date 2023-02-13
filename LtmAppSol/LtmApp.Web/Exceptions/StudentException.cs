using System;

namespace LtmApp.Web.Exceptions
{
    public class StudentException : Exception
    {
        public StudentException(string message) : base(message)
        {
        }
    }
}
