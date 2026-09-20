// Comentario:
using System;

class CalculoMediaConErrores
{
	static void Main (string[] args)
	{
		//Declaración de variables
		
		float evaluacion1 = 0;
		float evaluacion2 = 0;
		float evaluacion3 = 0;
		float media = 0;
		
		// Mostrar mensaje y leer la evaluación 1
		Console.Write ("Introduce la nota de la primera evaluación: ");
		// Convertir la entrada de string a int.
		evaluacion1 = Convert.ToSingle (Console.ReadLine());
		
		//Mostrar mensaje y leer la evaluación 2
		Console.Write ("Introduce la nota de la segunda evaluación: ");
		evaluacion2 = Convert.ToSingle (Console.ReadLine());
		
		//Mostrar mensaje y leer la evaluación 3
		Console.Write ("Introduce la nota de la tercera evaluación: ");
		evaluacion3 = Convert.ToSingle (Console.ReadLine());
		
		// Calcular la media
		media = (evaluacion1 + evaluacion2 + evaluacion3) / 3;
		
		// Mostrar el resultado
		Console.WriteLine (" La nota media es {0}.",media);
		
		
		 }
}	
