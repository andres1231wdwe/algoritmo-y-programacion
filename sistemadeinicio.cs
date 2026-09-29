sing System;

public class programa
{
    public static void Main(string[] args)
    {
        /* crea un programa que simule un sistemas de inicios de seccion el usuario debe ingresar un correo con dominio unicaribe.edu.co y su contraseña el 
          usuario tendra como datos correctos:
         
        usuario: youremail.unicaribe.edu.co 
        contraseña: ny12345@

        - el programa debe de permitir maximo 3 intentos, si los datos son correctos debe de mostrar " Bienvenido a la plataforma de UNICARIBE "
        - Despues de 3 intentos incorrectos, debe mostrar 
        "usuario Bloqueado - Comunicate con T.I UNICARIBE 
        */

        string correoCorrecto = "aestivenfernandez@unicaribe.edu.co";
        string passCorrecta = "ny12345@";

        string email = "";
        string pass = "";

        int intentos = 0;
        while (intentos < 3)
        {
            Console.WriteLine("Ingrese su correo");
            email = Console.ReadLine();

            Console.WriteLine("Ingrese la contraseña");
            pass = Console.ReadLine();

            if (email == correoCorrecto && pass == passCorrecta)
            {
                Console.WriteLine("!!BIENVENIDO A LA PLATAFORMA DE UNICARIBE¡¡");
                break;
            } else{
                intentos++;
                Console.WriteLine("Correo o contrraseña INCORRECTOS!!");
                Console.WriteLine("Intentos Restantes: " + (3 - intentos));
            }
            if (intentos == 3) {
                Console.WriteLine("Usuario bloqueado - por favor comunicate con T.I "); }

        }

      }
  }

