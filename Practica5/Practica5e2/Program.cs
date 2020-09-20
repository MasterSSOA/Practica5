//Práctica 5 Ejercicio 1.
//Nota : Programa capaz registrar 4 notas a traves de un arreglo.
//
// 
//                                         © Anthony Reyes Duran

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5e2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> Notas = new List<double>
            {
                90, 88, 92, 79
            };

            for (int i = 0; i < Notas.Count; i++)
            {
                Console.WriteLine("La Nota {0} es : {1}\n", i + 1, Notas[i]);
            }
            Console.ReadKey();
        }
    }

    
}
