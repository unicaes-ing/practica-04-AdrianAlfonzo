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
    class Program
    {
        static void Main(string[] args)
        {
            //Base
            double money;
            double tot = 0.0;
            Console.WriteLine("-->SISTEMA DE SALARIOS<--");
            //Consulta en FOR
            for (int cont = 1; cont <= 20; cont++)
            {
                Console.WriteLine("¿Cuánto gana, trabajador # {0}?", cont);
                money = Convert.ToDouble(Console.ReadLine());
                tot += money;
            }
            //Mostrar
            Console.WriteLine("El total de los sueldos es: {0:C2}", tot);
            Console.WriteLine("El promedio de los sueldos es: {0:C2}", tot/20);
            Console.ReadKey();
        }
    }
}
