using System;
//solicita al usuario que igrese una contraseña. usando un Do-while, sigue
//pidiendo la contraseña hasta que coincida con una predefinida ("admin123").
// Al finalizar, muestra cuantos intentos faliidos realizo antes de acercarse.

public class helloworld
{
    public static void Main(String[] args)
    {
        const string passCorrecta = "Andres311850";
        string clave;
        int intentosFallido = 0;

        do {
            Console.WriteLine("Ingrese la contraseña");
            clave = Console.ReadLine();

            if (clave != passCorrecta)
            {
                intentosFallido++;
                Console.WriteLine("Contraseña incorrecta. intentalo de nuevo");
            }

        } while (clave != passCorrecta );
        Console.WriteLine(" Acceso concedido");
        Console.WriteLine($"intentos fallidos: {intentosFallido}");

    }
}
