//Comentario: Calcula la diferencia de edad.
using System; // Necesario para Console y otros tipos básicos

class DiferenciaEdades

{
	static void Main (string[] args)
	{ 
		// Declaración de variables
		
		int edadMadre = 0;
		int edadHijo = 0;
		int diferencia = 0;
		
		//Mostrar mensaje y leer la edad de la madre
		Console.Write ("Introduce la edad de tu madre: ");
		//Convertir la entrada de string a int.
		edadMadre = Convert.ToInt32 ( Console.ReadLine ());
		
		//Mostrar mensaje y leer la edad del hijo/a
		Console.Write("Introduce tu edad: ");
		edadHijo = Convert.ToInt32 (Console.ReadLine());
		
		//Calcular la diferencia de edad
		diferencia = edadMadre -edadHijo;
		
		//Mostrar el resultado utilizando interpolación de strings para mayor claridad
		Console.WriteLine ("Tu madre tiene {0} años más que tú.",diferencia);
     }
}
		
