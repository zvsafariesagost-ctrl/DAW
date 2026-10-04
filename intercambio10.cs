//Intercambio de valor de números
using System;

class IntercambioNumeros
{
	static void Main(string[] args)  
	{
		//Declaración de variables
		
		int num1 = 0;
		int num2 = 0;
		int aux = 0;
		
		//Mostrar mensaje y leer números
		Console.Write ("Introduce núm1: ");
		num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write ("Introduce núm2: ");
		num2 = Convert.ToInt32(Console.ReadLine());
		
		//Intercambiar los números
		aux = num1;
		num1 = num2;
		num2 = aux;
		
		//Mostrar el resultado
		Console.WriteLine ("*** Intercambiados ***");
		Console.WriteLine("El número 1 vale ahora {0}", num1);
		Console.WriteLine("El número 2 vale ahora {0}", num2);
	}
}

		
		
		
