//Cálculo de pulsaciones máximas
using System;

class CalculoPulsaciones
{
	static void Main(string[] args)
	{
		//Declaración de variables
		
		int edad = 0;
		double frecuencia = 0;
		
		//Mostrar mensaje y leer la edad
		Console.Write ("Introduce tu edad: ");
		edad = Convert.ToInt32(Console.ReadLine());
		
		//Calcular el resultado
		frecuencia = 208 - (0.7 * edad);
		
		//Mostrar el resultado
		Console.WriteLine ("Tu frecuencia cardíaca máxima es: {0}", frecuencia);
	}
}

