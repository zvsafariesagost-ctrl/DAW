//Calcula el precio de un billete de ferrocarril.
using System;

class BilleteFerrocarril
{
    static void Main()
    {
        Console.Write("Distancia a recorrer (km): ");
        double km = double.Parse(Console.ReadLine());

        Console.Write("Días de estancia: ");
        int dias = Convert.ToInt32(Console.ReadLine());

        double precio = km * 1.5;

        if (dias >7 && km > 800)
        {
            precio = precio * 0.7;
        }
        Console.WriteLine("El precio del billete es: " + precio + " euros");

    }
}

