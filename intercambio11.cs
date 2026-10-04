//Intercambio de valores
using System;

class IntercambioValores
{
	static void Main(string[] args)
	{
		//Declaración de valores 
		
		int a = 0;
		int b = 0;
		int c = 0;
		int aux = 0;
		
		//Mostrar el mensaje y leer números
		Console.Write ("Introduce a: ");
		a = Convert.ToInt32(Console.ReadLine());
		
		Console.Write ("Introduce b: ");
		b = Convert.ToInt32(Console.ReadLine());
		
		Console.Write ("Introduce c: ");
		c = Convert.ToInt32(Console.ReadLine());
		
		//Intercambiar los valores
		aux = c;
		c = b;
		b = a;
		a = aux;
		
		//Mostrar el resultado
		Console.WriteLine("a = {0}", a);
		Console.WriteLine("b = {0}", b);
		Console.WriteLine("c = {0}", c);
	}
}
		
		
		
		
	
