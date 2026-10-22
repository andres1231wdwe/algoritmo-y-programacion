using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadArchivos = 0;
            do
            {
                Console.WriteLine("Ingrese la cantidad de archivos a descargar: ");
                if (!int.TryParse(Console.ReadLine(), out cantidadArchivos))
                {
                    cantidadArchivos = 0;
                }
            } while (cantidadArchivos <= 0);

            // 1. Solicitar el espacio total disponible en disco (en MB) usando do-while
            double espacioDisponible = 0;
            do
            {
                Console.WriteLine("Ingrese el espacio total disponible en disco (MB): ");
                if (!double.TryParse(Console.ReadLine(), out espacioDisponible))
                {
                    espacioDisponible = 0;
                }
            } while (espacioDisponible <= 0);

            int archivosDescargados = 0;
            double totalMB = 0;

            for (int i = 1; i <= cantidadArchivos; i++)
            {
                Console.WriteLine($"\nArchivo #{i} - Nombre (escriba 'salir' para detener): ");
                string nombre = Console.ReadLine().Trim();

                if (nombre.ToLower() == "salir")
                {
                    Console.WriteLine(">> Proceso de descarga cancelado!!!");
                    break;
                }

                // 2. Validar el nombre del archivo (vacío o más de 20 caracteres)
                if (string.IsNullOrEmpty(nombre) || nombre.Length > 20)
                {
                    Console.WriteLine(">> Nombre de archivo inválido. Omitido.");
                    continue;
                }

                Console.WriteLine("Tamaño en MB: ");
                double tamanio = 0;

                if (!double.TryParse(Console.ReadLine(), out tamanio) || tamanio <= 0)
                {
                    Console.WriteLine(">> Tamaño inválido. Archivo omitido");
                    continue;
                }

                // 1. Verificar si el archivo cabe en el espacio restante
                if (tamanio > espacioDisponible)
                {
                    Console.WriteLine(">> Espacio insuficiente en disco. Descarga detenida.");
                    break;
                }

                // Restar el tamaño del espacio disponible
                espacioDisponible -= tamanio;

                // 3. Clasificar cada archivo descargado por tamaño
                string categoria = "";
                if (tamanio < 1)
                {
                    categoria = "Pequeño";
                }
                else if (tamanio <= 10)
                {
                    categoria = "Mediano";
                }
                else
                {
                    categoria = "Grande";
                }

                Console.WriteLine($">> Descargando '{nombre}' ({tamanio} MB) - Categoría: {categoria}... OK");

                archivosDescargados++;
                totalMB += tamanio;
            }

            Console.WriteLine("\n======= RESUMEN DE DESCARGA =======");
            Console.WriteLine($"Archivos Descargados: {archivosDescargados}");
            Console.WriteLine($"Total descargado: {totalMB} MB");
            Console.WriteLine($"Espacio restante en disco: {espacioDisponible} MB");
            Console.WriteLine("===================================================");
        }
    }
}
