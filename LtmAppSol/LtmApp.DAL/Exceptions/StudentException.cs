using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.DAL.Exceptions
{
    public class StudentException : Exception
    {
        public StudentException(string message) : base(message) 
        {
            //Logica para guardar la excepcion
        }
    }
}
