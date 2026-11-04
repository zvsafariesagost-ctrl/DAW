//Determina el precio de un parking según el tiempo de estancia y el dinero gastado en la compra.
using System;

class Parking
{
    static void Main()
    {
        //Declaración de variables

        double total = 0;
        int minutos = 0;
        double pagar = 0;

        Console.Write("Total: ");
        total = double.Parse(Console.ReadLine());

        Console.Write("Minutos: ");
        minutos = Convert.ToInt32(Console.ReadLine());

        if (total == 0)
        {
            pagar = minutos * 0.10;
        }
        else if (total > 20)
        {
            if (minutos <= 120)
            {
                pagar = 0;
            }
            else
            {
                pagar =(minutos - 120) * 0.05;
            }

        }
        else
        {
            pagar = minutos * 0.05;
        }
        Console.WriteLine("Pagar: " + pagar + " euros");
    }
}
