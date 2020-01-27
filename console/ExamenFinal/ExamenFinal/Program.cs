using System;
using System.Collections;

namespace ExamenFinal
{
    class Program
    {
     static void Main(string[] args)
        {

            Stack pila = new Stack();
            pila.Push(1);
            pila.Push(1);
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            Stack pila2 = new Stack();
            pila2.Push(4);
            pila2.Push(3);
            pila2.Push(2);
            Stack pila3 = new Stack();
            pila3.Push(1);
            pila3.Push(4);
            pila3.Push(1);
            pila3.Push(1);

            Console.WriteLine("Tamaño de las pilas: ");
            Console.WriteLine(pila.Count);
            Console.WriteLine(pila2.Count);
            Console.WriteLine(pila3.Count);

            int cant1 = pila.Count;
            int cant2 = pila2.Count;
            int cant3 = pila3.Count;

            int cantidad = 0;
            int suma = 0;

            for (int i = 0; i < cant1; i++)
            {
                cantidad = (int)pila.Pop();
                suma += cantidad;
                if (suma == pila.Count)
                {
                    Console.WriteLine(": ");
                    Console.WriteLine(suma);
                    break;
                }


                for (int j = 0; j < cant2; j++)
                {
                    
                    suma += cantidad;
                    if (suma == pila2.Count)
                    {
                        Console.WriteLine(": ");
                        Console.WriteLine(suma);
                        break;
                    }
                }

                for (int k = 0; k < cant3; k++)
                {
                    
                    suma += cantidad;
                    if (suma == pila3.Count)
                    {
                        Console.WriteLine(": ");
                        Console.WriteLine(suma);
                        break;
                    }
                }

            }
        }
    }
}