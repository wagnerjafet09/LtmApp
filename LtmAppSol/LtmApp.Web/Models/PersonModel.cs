using LtmApp.Web.Exceptions;

namespace LtmApp.Web.Models
{
    public class PersonModel
    {
        private string _firstName;
        public string firstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new StudentException("El campo apellido es requerido");
                }
                else if (value.Length > 50)
                {
                    throw new StudentException("La longitud del apellido es inválida");
                }
                else
                {
                    _firstName = value;
                }
            }
        }


        private string _lastName;
        public string lastName 
        {
            get { return _lastName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new StudentException("El campo apellido es requerido");
                }
                else if (value.Length > 50) 
                {
                    throw new StudentException("La longitud del apellido es inválida");
                }
                else
                {
                    _lastName = value;
                }
            } 
        }
    }
}
