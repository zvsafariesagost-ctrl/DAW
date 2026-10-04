//Comentario: Calcula dinero necesario.
using System;

class DineroNecesario
{
	static void Main (string[] args)
	{
		//Declaración de variables
		
		int yo = 1;
		int numeroAmigos = 0;
		float dineroMenu = 0;
		float necesitas = 0;
		
		//Mostrar mensaje y leer número de amigos
		Console.Write ("Introduce el número de amigos invitados: ");
		numeroAmigos = Convert.ToInt32 (Console.ReadLine ());
		
		//Mostrar mensaje y leer el coste del menú
		Console.Write ("Introduce cuanto cuesta el menú: ");
		dineroMenu = Convert.ToSingle (Console.ReadLine ());
		
		//Calcular el dinero necesario
		necesitas = dineroMenu * (numeroAmigos + yo);
		
		//Mostrar el resultado
		Console.WriteLine ("Necesitas {0}", necesitas);
	}
}
		
		
		
		
		

		
		
