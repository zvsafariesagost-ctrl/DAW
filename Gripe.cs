//Determina si un paciente tiene gripe según sus síntomas.
using System;

class Gripe
{
    static void Main ()
    {
        //Declaración de variables
        
        string nombre = "";
        string respiratorias = "";
        string fiebre = "";

        Console.WriteLine("Bienvenido al sistema de autodiagnóstico de gripe.");
        
        Console.Write("Escribe su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("¿Tiene usted dificultades respiratorias? ");
        respiratorias = Console.ReadLine();
        
        if (respiratorias.ToLower() == "si")
        {
            Console.Write("{0}, visite usted su centro de salud más cercano. ", nombre);
        }
        else
        {
            Console.Write("¿Tiene usted fiebre? ");
            fiebre = Console.ReadLine();

            if (fiebre.ToLower() == "si")
            {
                Console.Write("{0}, debería ponerse en contacto con su centro de salud porque aunque no parece que padezca gripe puede que padezca un proceso infeccioso. ", nombre);
            }
            else
            {
                Console.Write("{0}, tranquilo/a porque no tienes la gripe A", nombre);
            }
        }
    }
}
