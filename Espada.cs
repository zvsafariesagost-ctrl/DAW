//Determina los puntos necesarios para mejorar la espada del jugador.
using System;

class Espada
{
    static void Main()
    {

        //Declaración de variables

        string nombre = "";
        int saldo = 0;
        int diamantes = 0;
        int rocas = 0;
        int necesario = 0;
        int saldorestante = 0;

        Console.Write("¿Cómo te llamas? ");
         nombre = Console.ReadLine();

        Console.Write("Introduce tu saldo: ");
         saldo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el número de diamantes que necesitas: ");
         diamantes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el número de rocas que quieres: ");
        rocas = Convert.ToInt32(Console.ReadLine());

        //Comprobación de si el jugador tiene suficiente saldo para comprar los diamantes y las rocas.
        necesario = (diamantes * 5) + (rocas * 3);

        //Calcular el saldo restante después de la compra
        saldorestante = saldo - necesario;

        if (necesario > saldo)
        {
            Console.WriteLine("{0}, vas a necesitar {1} puntos. No tienes suficiente. Toca esperar para ganas más puntos.", nombre, necesario);
             
        }
        else if (necesario <= saldo)
        {
            Console.WriteLine("{0}, vas a necesitar {1} puntos. Espada mejorada. Tu saldo ahora es {2} ", nombre, necesario, saldorestante);
        }
    }
}
