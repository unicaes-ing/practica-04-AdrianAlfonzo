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
    class Ejercicio6Guia4
    {
        static void Main(string[] args)
        {
            //Base
            int cont = 1;
            int cant;
            double price;
            //Consulta
            Console.WriteLine("¿Cuántas sucursales existen?");
            cant = Convert.ToInt32(Console.ReadLine());
            //Proceso en WHILE
            while (cant != 0)
            {
                //Proceso en DO
                do
                {
                    //Proceso en FOR
                    for (int i = 1; i <= cant; i++)
                    {
                        //Proceso en FOR
                        for (int j = 1; j <= 3; j++)
                        {
                            Console.WriteLine("¿Cuánto se generó de venta #{0} en la sucursal #{1}?", j, i);
                            price = Convert.ToDouble(Console.ReadLine());
                            //Proceso en IF
                            if (price == 0)
                            {
                                j = 4;
                                i = cant + 1;
                            }
                        }
                        //Mostrar
                    }
                    cont--;
                } while (cont != 0);
                cant = 0;
            }
        }
    }
}
