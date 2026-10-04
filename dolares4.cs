//Comentario: Calcula el cambio de euros a dólares
using System;

class CambioDolaresAEuros
{
	static void Main(string[] args)
	{
		//Declaración de variables
		
		float euros = 0;
		float dolares = 0;
		
		//Mostrar mensaje y leer el número de euros
		Console.Write ("Dinero en euros que vas a cambiar a dólares: ");
		euros = Convert.ToSingle (Console.ReadLine ());
		
		
		//Calcular la conversión de euros a dólares
		dolares = euros * 1.09f;
		
		
		//Mostrar el resultado
		Console.WriteLine ("Los {0} euros que tienes son {1} $", euros, dolares);
		
	}
}
		
	
