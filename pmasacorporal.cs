//Calcula el índice de masa corporal
using System;

class CalculoIMC
{
	static void Main(string[] args)
	{
		//Declaración de variables
		
		string nombre = "";
		float altura = 0;
		float peso = 0;
		float IMC = 0;
		
		//Mostrar mensaje e introducir tu nombre
		Console.Write ("¿Cómo te llamas?: ");
		nombre = Console.ReadLine();
		
		//Mostrar mensaje e introducir la altura
		Console.Write ("¿Tu altura?: ");
		altura = Convert.ToSingle (Console.ReadLine());
		
		//Mostrar mensaje e introducir el peso
		Console.Write ("¿Tu peso?: ");
		peso = Convert.ToSingle (Console.ReadLine());
		
		//Calcular el IMC
		IMC = peso / (altura * altura);
		
		//Mostrar el resultado
		Console.WriteLine ("{0}, tu IMC es {1}", nombre, IMC);
	}
}
		
		
	

