//Cálculo del área de un triángulo
using System;

class CalculoAreaTriangulo
{
	static void Main (string[] args)
	{
		//Declaración de variables
		
		float basse = 0;
		float altura = 0;
		float area = 0;
		
		//Mostrar mensaje y leer la base
		Console.Write ("Introduce la base del triángulo: ");
		basse = Convert.ToSingle (Console.ReadLine ());
		
		//Mostrar mensaje y leer la altura del triángulo
		Console.Write ("Introduce la altura del triángulo: ");
		altura = Convert.ToSingle (Console.ReadLine ());
		
		//Calcular el resultado
		area = (basse * altura) / 2;
		
		//Mostrar el resultado
		Console.WriteLine ("El área del triángulo es: {0}", area);
	}
}
	
		
		
		
