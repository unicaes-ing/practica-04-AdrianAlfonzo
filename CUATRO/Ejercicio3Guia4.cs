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
    class Ejercicio3Guia4
    {
        static void Main(string[] args)
        {
            //Base
            string name;
            int con = 0;
            //Consula
            Console.WriteLine("¿Cuál es tu nombre?");
            name = Console.ReadLine();
            //Proceso en FOR
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'á' || name[i] == 'A' || name[i] == 'Á')
                {
                    con++;
                }
                if (name[i] == 'e' || name[i] == 'é' || name[i] == 'E' || name[i] == 'É')
                {
                    con++;
                }
                if (name[i] == 'i' || name[i] == 'í' || name[i] == 'I' || name[i] == 'Í')
                {
                    con++;
                }
                if (name[i] == 'o' || name[i] == 'ó' || name[i] == 'O' || name[i] == 'Ó')
                {
                    con++;
                }
                if (name[i] == 'u' || name[i] == 'ú' || name[i] == 'U' || name[i] == 'Ú')
                {
                    con++;
                }
            }
            //Mostrar
            Console.WriteLine("Hay {0} vocales en tu nombre", con);
            Console.ReadKey();

        }
    }
}
