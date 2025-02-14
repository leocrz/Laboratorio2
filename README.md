#GH
cuestionario 
¿Para qué crees que se usan los operadores lógicos en programación?
Para evaluar múltiples condiciones y tomar decisiones más complejas en el código.

¿Por qué es importante declarar correctamente el tipo de dato de una variable?
Para evitar errores, ahorrar memoria y asegurar cálculos precisos.

------------------------------------------------------------------------------------
Enunciado 1
```csharp
           {
        Console.Write("Ingresa la edad de la persona: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad < 12)
        {
            Console.WriteLine("Niño");
        }
        else if (edad >= 12 && edad <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else if (edad >= 18 && edad <= 59)
        {
            Console.WriteLine("Adulto");
        }
        else
        {
            Console.WriteLine("Adulto mayor");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

```

-------------------------------------------------------------------------------------------

Enunciado 2
```csharp
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
```

---------------------------------------------------------------------------------------------

Enunciado 3
```csharp

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
```

----------------------------------------------------------------------------------------------------
