using System;

class Program
{
    static void Main()
    {
        int dia;

        
        Console.Write("Ingresa un número entre 1 y 7 para el día de la semana: ");
        dia = Convert.ToInt32(Console.ReadLine());


        if (dia >= 1 && dia <= 1) // Lunes
        {
            Console.WriteLine("Lunes");
        }
        else if (dia >= 2 && dia <= 2) // Martes
        {
            Console.WriteLine("Martes");
        }
        else if (dia >= 3 && dia <= 3) // Miércoles
        {
            Console.WriteLine("Miércoles");
        }
        else if (dia >= 4 && dia <= 4) // Jueves
        {
            Console.WriteLine("Jueves");
        }
        else if (dia >= 5 && dia <= 5) // Viernes
        {
            Console.WriteLine("Viernes");
        }
        else if (dia >= 6 && dia <= 6) // Sábado
        {
            Console.WriteLine("Sábado");
        }
        else if (dia >= 7 && dia <= 7) // Domingo
        {
            Console.WriteLine("Domingo");
        }
        else 
        {
            Console.WriteLine("Número inválido. Debes ingresar un número entre 1 y 7.");
        }
    }
}
