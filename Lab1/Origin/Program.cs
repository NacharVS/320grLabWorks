using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParallelPotock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = new int[2];
            int[] mas2 = new int[2];
            int[] mas3 = new int[2];
            
            int sum=0;
            int otv;

            Random rnd = new Random();
            Task write = Task.Run(() =>
            {
                Console.WriteLine("привет");
                
                for (int i = 0; i < 2; i++)
                {
                    mas1[i] = rnd.Next(-10, 10);
                    mas2[i] = rnd.Next(-10, 10);
                    mas3[i] = rnd.Next(-10, 10);
                    Console.WriteLine();
                }

            });
           
            Task Sum = Task.Run(() =>
            {
                
                for (int i = 0; i < 2; i++)
                {
                    Thread.Sleep(500);
                    sum = mas1[i] + mas2[i];
                    Console.WriteLine("сложение: "+sum);
                   
                }
            });
           
            Task Raz = Task.Run(() =>
            {
               
                for (int i = 0; i < 2; i++)
                {
                    Thread.Sleep(750);
                    otv = sum - mas3[i];
                    Console.WriteLine("вычитание: "+otv);
                }
            }
            );
            Raz.Wait();

            Console.ReadKey();
        }
    }

}
