using System;

class Program
{
    static void Main()
    {
        string nombreUsuario;
        string contrasena;

        // Solicitar el nombre de usuario y la contraseña
        Console.Write("Ingresa tu nombre de usuario: ");
        nombreUsuario = Console.ReadLine();
        Console.Write("Ingresa tu contraseña: ");
        contrasena = Console.ReadLine();

        // Definir nombre y contraseña correctos
        string nombreCorrecto = "Leonel";
        string contrasenaCorrecta = "5231";

        // Evaluación con if-else
        if (nombreUsuario == nombreCorrecto && contrasena == contrasenaCorrecta)
        {
            Console.WriteLine("Acceso concedido");
        }
        else if (nombreUsuario == nombreCorrecto && contrasena != contrasenaCorrecta)
        {
            Console.WriteLine("Contraseña incorrecta");
        }
        else
        {
            Console.WriteLine("Usuario no registrado");
        }
    }
}
