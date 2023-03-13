using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.BL.Exceptions
{
    public class CourseExceptions : Exception
    {
        public CourseExceptions(string message) : base(message)
        {
            //Usted agrega x logica: enviar una notificacion, persistir local file system, bd, etc.../
        }
    }
}
