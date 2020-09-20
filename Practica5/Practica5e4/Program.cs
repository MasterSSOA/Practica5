//Práctica 5 Ejercicio 4.
//Nota : Programa capaz permitir almacenar diferente valores en 
//       una sola variable y luego asignar valores en dicha ca-
//       cantidad.
//
// 
//                                         © Anthony Reyes Duran

using System;
using System.Collections.Generic;

namespace Practica5e4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglo.
            Console.Write("Cantidad de Longitud de su Arreglo: ");
            int[] Valores = new int[int.Parse(Console.ReadLine())];

            //Lógica.
            for (int i = 0; i < Valores.Length; i++)
            {
                Console.Write("Valor {0} : ", i + 1);
                Valores[i] = int.Parse(Console.ReadLine());
            }
           
            Console.Write("\nValores Guardados\n");
            foreach (var i in Valores)
            {
                if(i != Valores.Length)
                    Console.Write(i + ", ");
                else
                    Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
