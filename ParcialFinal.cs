using System;

class Program
{
    static void Main()
    {
        const string usuarioCorrecto = "soporteDB";
        const string claveCorrecta = "Sistemas2025";
        const int maxIntentos = 3;
        int intentos = 0;
        bool conectado = false;

        do
        {
            Console.Write("Ingrese su usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Ingrese su Contraseña: ");
            string clave = Console.ReadLine();

            if (usuario == "admin")
            {
                
                Console.WriteLine("Servidor no disponible. Reintente más tarde.");
            }
            else if (usuario == usuarioCorrecto && clave == claveCorrecta)
            {
                
                Console.WriteLine("Conexión establecida con la base de datos.");
                conectado = true;
            }
            else
            {
                
                intentos++;
                Console.WriteLine($"Error de autenticación. Intento {intentos} de {maxIntentos}.");
            }

        } while (!conectado && intentos < maxIntentos);

        
        if (!conectado)
        {
            Console.WriteLine("Conexión bloqueada por seguridad.");
            Console.WriteLine("Comuníquese con el administrador del sistema.");
        }
    }
}
