public class Helloword
{
    public static void Main(string[] args)
    {
        Console.WriteLine("MENU");
        Console.WriteLine("1. Saludar");
        Console.WriteLine("2. Mostrar fecha");
        Console.WriteLine("3. Salir");
        Console.WriteLine("Seleccione una opcion: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("¡HOLA! Bienvenido ¡!");
                break;
            case 2:
                Console.WriteLine(("La Fecha actual es:") + DateTime.Now);
                break;
            case 3:
                Console.WriteLine("programa Finalizado!!!");
                break;
            default:
                Console.WriteLine("¡Opcion no valida!");
                break;
        }
    }
}
