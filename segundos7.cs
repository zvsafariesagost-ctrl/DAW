//Calculo conversión de segundos 
using System;

class CalculoSegundos
{
	static void Main(string[] args)
	{
		//Declaración de variables
		
		int segundos = 0;
		int horas = 0;
		int minutos = 0;
		int restosegundos = 0;
		
		//Mostrar mensaje y leer los segundos
		Console.Write ("Introduce segundos: ");
		segundos = Convert.ToInt32 (Console.ReadLine ());
		
		//Calcular el resultado
		 horas = segundos / 3600;
		 minutos = (segundos % 3600) / 60;
		 restosegundos = segundos % 60;
		 
		 //Mostrar el resultado
		 Console.WriteLine ("Son {0} horas, {1} minutos y {2} segundos", horas, minutos, restosegundos);
	 }
 }
		
