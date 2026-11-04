// Da los buenos días, tardes o noches según la hora ingresada por el usuario.
using System;

class Reloj
{
    static void Main()
    {

        //Declaración de variables

        string nombre = "";
        int hora = 0;
        int minutos = 0;

        Console.Write("Nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Hora: ");
        hora = Convert.ToInt32(Console.ReadLine());

        Console.Write("Minutos: ");
        minutos = Convert.ToInt32(Console.ReadLine());

        if (hora >= 5 && hora < 12)
        {
            Console.WriteLine("{0}, buenos días.", nombre);
        }
        else if (hora >= 12 && hora < 17)
        {
            Console.WriteLine("{0}, buenas tardes.", nombre);
        }
        else
        {
            Console.WriteLine("{0}, buenas noches.", nombre);
        }
    }
}
