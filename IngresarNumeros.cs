using System;
//INGRESAR NUMEROS. 
//pide numeros enteros y acomula su suma hasta que ingrese 0. muestra la suma total
//cuantos numeros se ingresaron y el promedio.
public class helloworld
{
    public static void Main(String[] args)
    {
        int numero;
        int suma = 0;
        int contador = 0;

        do
        {
            Console.WriteLine("Ingrese un numero (0 para salir)");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                suma += numero;
                contador++;
            }

        } while (numero != 0);

        Console.WriteLine($"\nSuma total: {suma}");
        Console.WriteLine($"Cantidad de numero es: {contador}");

        if (contador > 0)
        {
            Console.WriteLine($"promedio: {(double)suma / contador:F2}");
        }
        else
        {
            Console.WriteLine($"No se ingresaron numeros.");



        }

    }
}
