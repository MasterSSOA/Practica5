//Práctica 5 Ejercicio 2.
//Nota : Programa capaz permitir ordenar elementos a traves de 
//       un arreglo.
//
// 
//                                         © Anthony Reyes Duran

using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica5e3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            double Promedio;

            //Arreglo.
            int[] Elementos = new int[] 
            {
                9, 15, 1, 14, 8, 7, 6, 5
            };
            Array.Sort(Elementos);

            for (int i = 0; i < Elementos.Length; i++)
            {
                Console.WriteLine(Elementos[i]);
                Sum += Elementos[i];
            }
            Promedio = (double)Sum / Elementos.Length;
            Console.WriteLine("\nLa Suma es     : {0}", Sum);
            Console.WriteLine("El Promedio es : {0:n}", Promedio);
            Console.ReadKey();

        }
    }
}
