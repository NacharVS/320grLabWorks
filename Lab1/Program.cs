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
            int[] m1 = new int[4];
            int[] m2 = new int[4];
            int[] m3 = new int[4];

            int sum = 0;
            int otv;

            Random rnd = new Random();
            Task write = Task.Run(() =>
            {
                Console.WriteLine("начало");

                for (int i = 0; i < 4; i++)
                {
                    m1[i] = rnd.Next(-10, 10);
                    Console.Write(m1[i]+",");
                    m2[i] = rnd.Next(-10, 10);
                    Console.Write(m2[i] + ",");
                    m3[i] = rnd.Next(-10, 10);
                    Console.Write(m3[i] + ",");
                    Console.WriteLine();
                    
                }

            });

            Task Sum = Task.Run(() =>
            {

                for (int i = 0; i < 4; i++)
                {
                    Thread.Sleep(500);
                    sum = m1[i] + m2[i];
                    Console.WriteLine("сложение: " + sum);

                }
            });

            Task Raz = Task.Run(() =>
            {

                for (int i = 0; i < 4; i++)
                {
                    Thread.Sleep(750);
                    otv = sum - m3[i];
                    Console.WriteLine("вычитание: " + otv);
                }
            }
            );
            Raz.Wait();

            Console.ReadKey();
        }
    }

}

