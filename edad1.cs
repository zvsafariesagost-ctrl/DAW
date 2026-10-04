//Comentario:Calcula los años de una persona
using System;

class CalculoEdad
{
	static void Main (string[] args)
	{
		// Declaración de variables
		
		string nombre = "";
		int añoNacimiento = 0;
		int añoActual = 0;
		int diferencia = 0;
		
		// Mostrar mensaje y leer la entrada del usuario
		Console.Write ("Introduce tu nombre: ");
		nombre = Console.ReadLine ();
		
		//Mostrar mensaje y leer el año de nacimiento
		Console.Write ("Introduce tu año de nacimiento: ");
		añoNacimiento = Convert.ToInt32 (Console.ReadLine ());
		
		//Mostrar mensaje y leer el año actual
		Console.Write ("Introduce el año actual: ");
		añoActual = Convert.ToInt32 (Console.ReadLine ());
		
		//Calcular la diferencia de años
		diferencia = añoActual - añoNacimiento;
		
		//Mostrar el resultado utilizando interpolación de strings para mayor claridad
		Console.WriteLine ("{0}, este año cumplirás {1} años", nombre, añoActual-añoNacimiento);
		Console.WriteLine ("Bye!");
	}
}
		
		
		
		
		
		
		
		
		
