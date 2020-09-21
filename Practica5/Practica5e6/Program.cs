//Práctica 5 Ejercicio 6.
//Nota : Programa capaz de calcular el producto escalar de dos
//       vectores.
//
// 
//                                         © Anthony Reyes Duran

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5e6
{
    class Program
    {
        static void Main(string[] args)
        {
            int subTotal;
            int Total = 0;

            //Arreglo.
            int[] VectorA = { 2, 4, 6 };
            int[] VectorB = { 1, 3, 5 };

            //Lógica.
            for (int i = 0; i < VectorA.Length; i++)
            {
                subTotal = VectorA[i] * VectorB[i];
                Total += subTotal;
            }

            Console.WriteLine("El Producto Escalar Es : {0}", Total);
            Console.ReadKey();
        }
    }
}
