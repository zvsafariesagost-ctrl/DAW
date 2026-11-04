//Declara la suma de dos números como peligrosa si ésta tiene el mismo resultado.
using System;
class Numeros
{
    static void Main()
    {
        //Declaración de variables

        int numero1 = 0;
        int numero2 = 0;
        int suma1 = 0;
        int suma2 = 0;

        Console.Write("Introduce un número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce otro número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());

        suma1 = (numero1 / 10) + (numero1 % 10);
        suma2 = (numero2 / 10) + (numero2 % 10);

        if (suma1 == suma2)
        {
            Console.WriteLine("Los números son peligrosos");
        }
        else
        {
            Console.WriteLine("No son peligrosos");
        }
    }
}
