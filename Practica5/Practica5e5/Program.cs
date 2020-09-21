//Práctica 5 Ejercicio 5.
//Nota : Programa capaz de calcular el producto vectorial de dos
//       vectores.
//
// 
//                                         © Anthony Reyes Duran

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5e5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Columna;
            int Producto1;
            int Producto2;
            int TotalVector1 = 0;
            int TotalVector2 = 0;
            int TotalVector3 = 0;

            //Arreglo.
            int[,] Matriz = { { 2, 4, 6}, { 1, 3, 5} };

            //Lógica.
            Columna = 0;

            if (Columna < 3)
            {
                if (Matriz[0, Columna] == Matriz[0, 0])
                {
                    Producto1 = Matriz[0, 1] * Matriz[1, 2];
                    Producto2 = Matriz[1, 1] * Matriz[0, 2];
                    TotalVector1 = Producto1 + Producto2;
                    Columna++;
                    if (Matriz[0, Columna] == Matriz[0, 1])
                    {
                        Producto1 = Matriz[0, 0] * Matriz[1, 2];
                        Producto2 = Matriz[1, 0] * Matriz[0, 2];
                        TotalVector2 = Producto1 + Producto2;
                        Columna++;
                        if (Matriz[0, Columna] == Matriz[0, 2])
                        {
                            Producto1 = Matriz[0, 0] * Matriz[1, 1];
                            Producto2 = Matriz[1, 0] * Matriz[0, 1];
                            TotalVector3 = Producto1 + Producto2;
                        }
                    }
                }
            }
            Console.WriteLine("El Producto Vectorial Es : <{0}, {1}, {2}>", TotalVector1, TotalVector2, TotalVector3);
            Console.ReadKey();
        }
    }
}
