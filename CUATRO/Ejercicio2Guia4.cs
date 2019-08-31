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
    class Ejercicio2Guia4
    {
        static void Main(string[] args)
        {
            //Base
            double grade;
            double come;
            int yes = 0;
            int no = 0;
            //Consulta
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sistema de calificaciones y asistencia 2019");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            //Proceso en FOR
            for (int con = 1; con <= 10; con++)
            {
                Console.WriteLine("¿Cuál es la nota del alumno # {0}?", con);
                grade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("¿En porcentaje, que tanto asistía a clases el alumno # {0}?", con);
                come = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                //Proceso en IF
                if (grade >= 7.0 && come >= 75)
                {
                    yes++;
                }
                else
                {
                    no++;
                }
            }
            //Mostrar
            Console.WriteLine("La cantidad de aprobados son: {0} alumnos", yes);
            Console.WriteLine("La cantidad de reprobados son: {0} alumnos", no);
            Console.ReadKey();
        }
    }
}
