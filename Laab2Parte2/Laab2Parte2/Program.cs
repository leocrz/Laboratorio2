using System;

class Program
{
    static void Main()
    {
        // Operaciones con int
        Console.Write("Porfavor Ingrese el primer número entero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Porfavor Ingrese el segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nOperaciones con int:");
        Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"División: {num1} / {num2} = {(num2 != 0 ? (num1 / (double)num2).ToString() : "No se puede dividir entre 0")}\n");

        // Operaciones con float
        Console.Write("Porfavor Ingrese el primer número flotante (Float): ");
        float num3 = float.Parse(Console.ReadLine());

        Console.Write("Porfavor Ingrese el segundo número flotante (Float): ");
        float num4 = float.Parse(Console.ReadLine());

        Console.WriteLine("\nOperaciones con float:");
        Console.WriteLine($"Suma: {num3} + {num4} = {num3 + num4}");
        Console.WriteLine($"Resta: {num3} - {num4} = {num3 - num4}");
        Console.WriteLine($"Multiplicación: {num3} * {num4} = {num3 * num4}");
        Console.WriteLine($"División: {num3} / {num4} = {(num4 != 0 ? (num3 / num4).ToString() : "No se puede dividir entre 0")}\n");
        Console.WriteLine("diferencia float y decimal, float 7 digitos de presicion y decimal 28-29 ");
        
        // Operaciones con decimal
        Console.Write("\nPorfavor Ingrese el primer número decimal (decimal): ");
        decimal num5 = decimal.Parse(Console.ReadLine());

        Console.Write("Porfavor Ingrese el segundo número decimal (decimal): ");
        decimal num6 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nOperaciones con decimal:");
        Console.WriteLine($"Suma: {num5} + {num6} = {num5 + num6}");
        Console.WriteLine($"Resta: {num5} - {num6} = {num5 - num6}");
        Console.WriteLine($"Multiplicación: {num5} * {num6} = {num5 * num6}");
        Console.WriteLine($"División: {num5} / {num6} = {(num6 != 0 ? (num5 / num6).ToString() : "No se puede dividir entre 0")}\n");

        // Operaciones con Int16
        Console.Write("Porfavor Ingrese el primer número (Int16): ");
        short num7 = short.Parse(Console.ReadLine());

        Console.Write("Porfavor Ingrese el segundo número (Int16): ");
        short num8 = short.Parse(Console.ReadLine());

        Console.WriteLine("\nOperaciones con Int16:");
        Console.WriteLine($"Suma: {num7} + {num8} = {num7 + num8}");
        Console.WriteLine($"Resta: {num7} - {num8} = {num7 - num8}");
        Console.WriteLine($"Multiplicación: {num7} * {num8} = {num7 * num8}");
        Console.WriteLine($"División: {num7} / {num8} = {(num8 != 0 ? (num7 / (double)num8).ToString() : "No se puede dividir entre 0")}\n");

        // Operaciones con byte
        Console.Write("Porfavor Ingrese el primer número (byte): ");
        byte num9 = byte.Parse(Console.ReadLine());

        Console.Write("Porfavor Ingrese el segundo número (byte): ");
        byte num10 = byte.Parse(Console.ReadLine());

        Console.WriteLine("\nOperaciones con byte:");
        Console.WriteLine($"Suma: {num9} + {num10} = {num9 + num10}");
        Console.WriteLine($"Resta: {num9} - {num10} = {num9 - num10}");
        Console.WriteLine($"Multiplicación: {num9} * {num10} = {num9 * num10}");
        Console.WriteLine($"División: {num9} / {num10} = {(num10 != 0 ? (num9 / (double)num10).ToString() : "No se puede dividir entre 0")}");
    }
}
