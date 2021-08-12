using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasepractica
{
    class Program
    {
        static void Main(string[] args)

        {

            loops();
            Console.ReadLine();
        }

        public static void loops()
        {
            {

                int[] arraynumbers = new int[10];

                int a = 0;
                int sumatoria = 0;
                int promedio = 0;

                while (x < arraynumbers.Length)
                {
                    Console.WriteLine(" Ingrese el dato para la posición {0} ", a);
                    arraynumbers[a] = Convert.ToInt32(Console.ReadLine());
                    a++;
                }
                Console.WriteLine();



                int b = 0;

                Console.WriteLine(" Datos ingresados, utilizando el ciclo While:");
                while (b < arraynumbers.Length)
                {
                    Console.WriteLine(arraynumbers[b]);
                    b++;


               
                    promedio = sumatoria / a;


                    sumatoria += arraynumbers[b];
                }

                Console.WriteLine("El valor promedio es de: {0}", sumatoria);

            }

        }
    }
}