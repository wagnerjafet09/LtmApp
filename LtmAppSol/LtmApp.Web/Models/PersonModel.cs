using LtmApp.Web.Exceptions;

namespace LtmApp.Web.Models
{
    public class PersonModel
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
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
                    firstName = value;
                }
            }
        }


        private string lastName;
        public string LastName 
        {
            get { return lastName; }
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
                    lastName = value;
                }
            } 
        }
    }
}
