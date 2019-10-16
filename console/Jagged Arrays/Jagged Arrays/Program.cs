using System;

namespace Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            String alum;
            int alumnos
            int num = 8;
            double not = 0;
            double promedio = 0
            int grupo;
            int cont;
            int[] jaggedArray = new int[8];
            for (int j = 0; jaggedArray.Length; j++)
            {
                int v = cont++;
                Console.WriteLine("cuantos alumnos hay en "+cont);
                alumnos = int.Parse(Console.ReadLine));
            }
            
            Console.WriteLine("ingresa el nombre del alumno");
            alum = string.Format(Console.ReadLine());

            for(int i=0;i<=num; i++)
            {
                Console.WriteLine("Ingresa la nota del alumno: "+(i+1));{
                    not = double.Parse(Console.ReadLine());
                    promedio = promedio + not;
            }
                Console.WriteLine("el promedio del alumno " + alum + "es: " + (promedio));
                Console.ReadKey();
        }
        }
    }
}
