// Comentario: Autor y qué hace el programa
using System; // Necesario para Console y otros tipo básicos 

class ProgramaEdades
{
     static void Main (string []  args)
     {
          // Declaración de variables
          // string se usa para texto, int para números enteros.
          string nombre = "";
          int edad = 0;
          
          // Mostrar mensaje y leer entrada del usuario
          Console.Write ("	Introduce tu nombre: ");
          nombre = 	Console.ReadLine();
          
          Console.Write ("Introduce tu edad: ");
          edad = Convert.ToInt32 (Console.ReadLine ()) ;
          
          // Mostrar el resultado
          // que es una forma más moderna y legible.
          Console.WriteLine ("{0}, has vivido {1} dias, aproximadamente", nombre, edad*365) ;
          
          
       }
}
 
 
        
          
