using System;


namespace Practica5e1
{
    class Padre
    {
        //Atributos.

        //Constructor.

        //Funciones
        public void ShowMessage()
        {
            Console.WriteLine("Hola desde la clase {0}", this.GetType().Name);
        }

    }
}
