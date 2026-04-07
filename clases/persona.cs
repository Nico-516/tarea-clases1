namespace Clases
{
    class Persona 
    {
        public string _nombre{get};
        public string _email{get};

        public Persona (string nombre, string email)  //Constructor
        {
            this._nombre = nombre;
            this._email = email;
        }

        public virtual void presentarse()
        {
            Console.writeline($"Hola soy {_nombre}")
        }


        class Alumno : Persona 
            {
                int legajo {get};
            }
    }
}

