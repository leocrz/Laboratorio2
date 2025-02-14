using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        // Solicitar los dos números
        Console.Write("Por favor, ingresa el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Por favor, ingresa el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Comparaciones de mayor, menor, igual
        if (num1 > num2)
        {
            Console.WriteLine($"{num1} es mayor que {num2}.");
        }
        else if (num1 < num2)
        {
            Console.WriteLine($"{num1} es menor que {num2}.");
        }
        else
        {
            Console.WriteLine($"{num1} es igual a {num2}.");
        }

        // Uso de AND (&&) y OR (||)
        if (num1 > 0 && num2 > 0)
        {
            Console.WriteLine("Ambos números son positivos.");
        }
        else if (num1 < 0 || num2 < 0)
        {
            Console.WriteLine("Al menos uno de los números es negativo.");
        }
        else
        {
            Console.WriteLine("Ambos números son cero.");
        }

        // Explicación final
        Console.WriteLine("\n--- Explicación del programa ---");
        Console.WriteLine("Este programa solicita dos números enteros y realiza comparaciones.");
        Console.WriteLine("1. Determina cuál número es mayor, menor o si son iguales.");
        Console.WriteLine("2. Evalúa si ambos números son positivos, si al menos uno es negativo o si ambos son ceros.");
        Console.WriteLine("Utiliza estructuras condicionales (if-else) y operadores lógicos (&&, ||) para hacer estas verificaciones.");

       
    }
}
