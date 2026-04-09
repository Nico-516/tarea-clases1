using System;

public class Persona
{
	string _nombre { get; }
	string _email { get; }
	
	public Persona(string nombre, string email)
	{
		_email = email;
		_nombre = nombre;
	}

	public static virtual void presentarse()
	{
		Console.WriteLine($"Hola, soy {_nombre}");
	}

	public class Alumno : Persona
	{
		int _legajo { get; }

		list<string> _materias = new list<string>();

		public Alumno(int legajo)
		{
			_legajo = legajo;
		}

		public static override void presentarse()
		{
			Console.Writeline($"Alumno {_nombre}, legajo {_legajo}");
		}

		public static void inscribirse(int cantMaterias)
		{
			for (int i = 0; i < cantMaterias+1; i++)
			{
				string nuevaMateria = Console.Readline($"Ingrese el nombre de la materia {i+1}: ");
				_materias.Add(nuevaMateria);
			}
		}
    }
}
