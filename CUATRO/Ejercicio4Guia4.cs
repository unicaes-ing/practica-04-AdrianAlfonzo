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
    class Ejercicio4Guia4
    {
        static void Main(string[] args)
        {
            //Base
            double sell;
            double tot = 0;
            int con = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----SUPER SELECTOS-----");
            Console.ForegroundColor = ConsoleColor.White;
            //Consulta en DO
            do
            {
                Console.Write("¿De cuánto fue la venta realizada? $ ");
                sell = Convert.ToDouble(Console.ReadLine());
                //Proceso en IF
                if (sell == -1)
                {

                }
                else
                {
                    tot += sell;
                    con++;
                }
            } while (sell != -1);
            //Mostrar
            Console.WriteLine("Cantidad de ventas: {0}", con);
            Console.WriteLine("Dinero en ventas: {0:C2}", tot);
            Console.WriteLine("Ventas + 5% de bono: {0:C2}", (tot + (tot * 0.05)));
            Console.ReadKey();
        }
    }
}
