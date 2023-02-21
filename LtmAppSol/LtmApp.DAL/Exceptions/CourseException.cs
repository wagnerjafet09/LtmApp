using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.DAL.Exceptions
{
    public class CourseException : Exception
    {
        public CourseException(string message): base(message)
        {
            
        }
    }
}