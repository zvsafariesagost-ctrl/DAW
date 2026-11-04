//Juego de dados: Se lanzan dos dados y se determina cuál es el mayor. Si son iguales, se indica que hay empate.
using System;

class Dado
{
    static void Main()
    {
        Console.Write("Dado 1: ");
        int dado1 = int.Parse(Console.ReadLine());
        
        Console.Write("Dado 2: ");
        int dado2 = int.Parse(Console.ReadLine());

        if (dado1 > dado2)
        {
            Console.WriteLine ("El primero gana");
        }
        else if (dado2 > dado1)
        {
            Console.WriteLine("El segundo gana");
        }
        else
        {
            Console.WriteLine("Empate");
        }



    }
}