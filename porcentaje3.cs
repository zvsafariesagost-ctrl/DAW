//Calcula el porcentaje de chicos y chicas
using System;
 
class Porcentajechicoschicas

{
	static void Main(string[] args)
	{
		//Declaración de variables
		
		int chicos = 0;
		int chicas = 0;
		float porcentajeChicos = 0;
		float porcentajeChicas = 0;
		
		//Mostrar mensaje y leer número de chicos
		Console.Write ("Introduce el número de chicos en clase: ");
		chicos = Convert.ToInt32 (Console.ReadLine ());
		
		//Mostrar mensaje y leer número chicas
		Console.Write ("Introduce el número de chicas en clase: ");
		chicas = Convert.ToInt32 (Console.ReadLine ());
		
		//Calcular el porcentaje de chicos y chicas
		porcentajeChicos = (chicos * 100) / (chicos + chicas);
		porcentajeChicas = (chicas * 100) / (chicos + chicas);
	    
		
		//Mostrar el resultado
		Console.WriteLine ("El porcentaje de chicos es: {0}", porcentajeChicos + "%");
		Console.WriteLine ("El porcentaje de chicas es: {0}", porcentajeChicas + "%");
	}
}

	
		
		
	


