using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = new int[10];
            int[] mas2 = new int[10];
            int[] mas3 = new int[10];
            int[] mas4 = new int[10]; 
            Random rnd = new Random();
           
            Task task1 = Task.Run(() =>
            {
                Console.Write("mas1: ");

                for (int i = 0; i < mas1.Length; i++)
                {
                    mas1[i] = rnd.Next(1, 30);
                    Console.Write("[" + mas1[i] + "]" + " ");
                }

                Console.Write("\n");
                Console.Write("mas2: "); 

                for (int i = 0; i < mas2.Length; i++)
                {
                    mas2[i] = rnd.Next(-10, 40);
                    Console.Write("[" + mas2[i] + "]" + " ");
                }

                Console.Write("\n");
                Console.Write("mas3: "); 

                for (int i = 0; i < mas3.Length; i++)
                {
                    mas3[i] = rnd.Next(1, 30);
                    Console.Write("[" + mas3[i] + "]" + " ");
                }

                Console.Write("\n");
                Console.Write("mas1 + mas2: ");
            });

            Task task2 = Task.Run(() =>
            { 
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(980);
                    mas4[i] = mas1[i] + mas2[i];
                    Console.Write("[" + mas4[i] + "]" + " ");
                }

                Console.Write("\n");
                Console.Write("(mas1 + mas2) - mas3: ");
            });

            Task task3 = Task.Run(() =>
            {
                Thread.Sleep(9500); 
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(980);
                    mas4[i] = mas4[i] - mas3[i];
                    Console.Write("[" + mas4[i] + "]" + " ");
                }
            });

            Console.ReadKey();
        }
    }
}
