# LABORATORIO 02
cuestionario 
¿Para qué crees que se usan los operadores lógicos en programación?
Para evaluar múltiples condiciones y tomar decisiones más complejas en el código.

¿Por qué es importante declarar correctamente el tipo de dato de una variable?
Para evitar errores, ahorrar memoria y asegurar cálculos precisos.

------------------------------------------------------------------------------------
Enunciado 1
```csharp
     {
    // Solicitar la edad de la persona
    Console.Write("Ingresa la edad de la persona: ");
    int edad = Convert.ToInt32(Console.ReadLine());

    // Verificar si la persona es un niño (menos de 12 años)
    if (edad < 12)
    {
        Console.WriteLine("Niño");
    }
    // Verificar si la persona es un adolescente (entre 12 y 17 años)
    else if (edad >= 12 && edad <= 17)
    {
        Console.WriteLine("Adolescente");
    }
    // Verificar si la persona es un adulto (entre 18 y 59 años)
    else if (edad >= 18 && edad <= 59)
    {
        Console.WriteLine("Adulto");
    }
    // Si la persona es mayor de 59 años, se considera adulto mayor
    else
    {
        Console.WriteLine("Adulto mayor");
    }

   
}

```

Usé el if para clasificar la edad de la persona en diferentes grupos según su rango. Luego, usé el operador lógico && para combinar condiciones, como en edad >= 12 && edad <= 17, para verificar si la edad está dentro de un rango específico.

-------------------------------------------------------------------------------------------

Enunciado 2
```csharp
   {
    int dia;

    // Solicitar que ingrese un número entre 1 y 7 para seleccionar el día de la semana
    Console.Write("Ingresa un número entre 1 y 7 para el día de la semana: ");
    dia = Convert.ToInt32(Console.ReadLine());

    // Verificar si el número corresponde al día Lunes (1)
    if (dia >= 1 && dia <= 1) // Lunes
    {
        Console.WriteLine("Lunes");
    }
    // Verificar si el número corresponde al día Martes (2)
    else if (dia >= 2 && dia <= 2) // Martes
    {
        Console.WriteLine("Martes");
    }
    // Verificar si el número corresponde al día Miércoles (3)
    else if (dia >= 3 && dia <= 3) // Miércoles
    {
        Console.WriteLine("Miércoles");
    }
    // Verificar si el número corresponde al día Jueves (4)
    else if (dia >= 4 && dia <= 4) // Jueves
    {
        Console.WriteLine("Jueves");
    }
    // Verificar si el número corresponde al día Viernes (5)
    else if (dia >= 5 && dia <= 5) // Viernes
    {
        Console.WriteLine("Viernes");
    }
    // Verificar si el número corresponde al día Sábado (6)
    else if (dia >= 6 && dia <= 6) // Sábado
    {
        Console.WriteLine("Sábado");
    }
    // Verificar si el número corresponde al día Domingo (7)
    else if (dia >= 7 && dia <= 7) // Domingo
    {
        Console.WriteLine("Domingo");
    }
    // Si el número ingresado no es válido (no está entre 1 y 7)
    else 
    {
        Console.WriteLine("Número inválido. Debes ingresar un número entre 1 y 7.");
    }
}

```
Usé el if para verificar el número que el usuario ingresa y mostrar el día de la semana correspondiente. Para cada día, utilicé el operador lógico && (aunque aquí no es necesario, porque solo comparo el número exacto) para asegurarme de que el número esté dentro de un rango específico. De todos modos, se podría simplificar solo comparando el valor directamente.


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

Usé el if para verificar si el nombre de usuario y la contraseña son correctos. Primero, comparé ambos valores usando el operador lógico && para asegurarme de que ambos, el nombre y la contraseña, coincidan con los correctos. Si solo uno es incorrecto, se usa un else if para mostrar un mensaje adecuado, como "Contraseña incorrecta". Si ambos son incorrectos, el else se encarga de mostrar "Usuario no registrado".

----------------------------------------------------------------------------------------------------
