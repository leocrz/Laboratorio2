using System;

class Program
{
    static void Main()
    {

        Console.Write("Ingrese un número entero: ");
        int entero = int.Parse(Console.ReadLine());

        Console.Write("Ingrese un número decimal: ");
        double decimalNum = double.Parse(Console.ReadLine());

        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        Console.Write("Ingrese un valor booleano (true/false): ");
        bool booleano = bool.Parse(Console.ReadLine());

        Console.WriteLine("\nValores ingresados:");
        Console.WriteLine($"El numero Entero Ingresado es: {entero}");
        Console.WriteLine($"El numero Decima ingresado esl: {decimalNum}");
        Console.WriteLine($"El Texto ingresado es: {texto}");
        Console.WriteLine($"El valor Booleano Ingresado es : {booleano}");
    }
}