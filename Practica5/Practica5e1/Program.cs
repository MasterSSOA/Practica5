//Práctica 5 Ejercicio 1.
//Nota : Programa capaz contener una clase llamada padre con cie-
//       rtas funciones y es heredada por la clase hijo.
//
// 
//                                         © Anthony Reyes Duran

using System;

namespace Practica5e1
{
    class Program
    {
        static void Main(string[] args)
        {
            Padre padre = new Padre();
            padre.ShowMessage();

            Hija hija = new Hija();
            hija.ShowMessage();

            Console.ReadKey();
        }
    }
}
