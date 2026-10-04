//Cálculos varios de dos números
using System; 

class CalculoNumeros
{
	static void Main(string[] args)
	{
		//Declaración de variables
		
		float primernumero = 0;
		float segundonumero = 0;
		float suma = 0;
		float resta = 0;
		float multiplicacion = 0;
		float division = 0;
		
		//Mostrar mensaje y leer el primer número
		Console.Write ("Primer número: ");
		primernumero = Convert.ToSingle (Console.ReadLine ());
		
		//Mostrar mensaje y leer el segundo número
		Console.Write ("Segundo número: ");
		segundonumero = Convert.ToSingle (Console.ReadLine ());
		
		//Hacer los cálculos
		suma = primernumero + segundonumero;
		resta = primernumero - segundonumero;
		multiplicacion = primernumero * segundonumero;
		division = primernumero / segundonumero;
		
		//Mostrar los resultados
		Console.WriteLine ("Suma: {0} ", suma);
		Console.WriteLine ("Resta: {0} ", resta);
		Console.WriteLine ("Multiplicación: {0} ", multiplicacion);
		Console.WriteLine ("División: {0} ", division);
	}
}
		
		
		
		
		
		
		
