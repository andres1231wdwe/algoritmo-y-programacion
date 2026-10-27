using System;

class Program
{
    static void Main()
    {
        string opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ DE EJERCICIOS =====");
            Console.WriteLine("1. Rectángulo hueco (tamaño a elegir)");
            Console.WriteLine("2. Triángulo rectángulo invertido");
            Console.WriteLine("3. Pirámide centrada");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción (1-4): ");

            opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    RectanguloHueco();
                    break;
                case "2":
                    TrianguloInvertido();
                    break;
                case "3":
                    PiramideCentrada();
                    break;
                case "4":
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Debes escribir un número del 1 al 4.");
                    break;
            }

        } while (opcion != "4");
    }

  
    static void RectanguloHueco()
    {
        int n = LeerNumeroPositivo("Ingresa la altura (n): ");
        int m = LeerNumeroPositivo("Ingresa el ancho (m): ");
        Console.WriteLine();
        +
        for (int i = 0; i < n; i++)             
        {
            for (int j = 0; j < m; j++)         
            {
                if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    
    static int LeerNumeroPositivo(string mensaje)
    {
        int numero;
        Console.Write(mensaje);

        while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.Write("Valor no válido. Escribe un número entero mayor que 0: ");
        }

        return numero;
    }

    
    static void TrianguloInvertido()
    {
        int altura = 5;

        for (int i = 0; i < altura; i++)
        {
            for (int j = 0; j < altura - i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

   
    static void PiramideCentrada()
    {
        int altura = 5;

        for (int i = 0; i < altura; i++)
        {
            for (int j = 0; j < altura - 1 - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
