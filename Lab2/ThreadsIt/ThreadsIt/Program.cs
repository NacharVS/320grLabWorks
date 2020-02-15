using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsIt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = new int[5];
            int[] mas2 = new int[5];
            int[] mas3 = new int[5];
            Random rnd = new Random();
            int number = 0;

            Task t1 = Task.Run(() =>
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int y= rnd.Next(1, 10);
                        mas1[i] = y;
                        Console.WriteLine("mas1[{0}]={1}", i, y);
                        y= rnd.Next(1, 10);
                        mas2[i] = y;
                        Console.WriteLine("mas2[{0}]={1}", i, y);
                        y= rnd.Next(1, 10);
                        mas3[i] = y;
                        Console.WriteLine("mas3[{0}]={1}", i, y);

                    }
                });

            Task t2 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(600);
                    number = mas1[i] + mas2[i];
                    Console.WriteLine("mas1[{0}]+mas2[{0}]={1}",i,number);
                }
            });

            Task t3 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(600);
                    int minus = number - mas3[i];
                    Console.WriteLine("{0}-mas[{1}]={2}", number, i, minus);
                }
            });

            Console.ReadKey();
        }
    }
}
