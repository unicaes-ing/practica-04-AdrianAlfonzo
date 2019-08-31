using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUATRO
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 30.08.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio5Guia4
    {
        static void Main(string[] args)
        {
            //Base
            string password = "MAQUINADEGUERRAESLAONDA";
            string answer;
            Console.WriteLine("Bienvenido a juegos.com");
            Console.Write("Se ha encontrado una cuenta, guardada en la computadora, con el usuario ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("NoobMaster69");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            //Consulta en FOR
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingresar la contraseña para comprobar su identidad");
                answer = Console.ReadLine();
                //Proceso en IF
                if (answer != password)
                {
                    Console.WriteLine();
                    Console.WriteLine("Aquí te va una pista:");
                    Console.WriteLine(password[i] + "\n");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Bienvenido NoobMaster69");
                    Environment.Exit(1);
                }
            }
            //Mostrar
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Llamando al FBI, no has ingresado la contraseña correctamente.");
            Console.ReadKey();
        }
    }
}
