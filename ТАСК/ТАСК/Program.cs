using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ТАСК
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = new int[20];
            int[] mas2 = new int[20];
            int[] mas3 = new int[20];
            int f = 0;
            int s = 0;
            Random rnd = new Random();

            Task write = Task.Run(() =>
              {
                  for (int i = 0; i < 20; i++)
                  {
                      mas1[i] = rnd.Next(0, 10);
                      mas2[i] = rnd.Next(0, 10);
                      mas3[i] = rnd.Next(0, 10);
                  }
              });

            Task fold = Task.Run(() =>
            {
                Thread.Sleep(500);
                for (int i = 0; i < 20; i++)
                {
                    Thread.Sleep(500);
                    f = mas1[i] + mas2[i];
                    Console.WriteLine(i + 1 + "). Сложение: " + f);
                }
            });
            Task subtract = Task.Run(() =>
            {
                Thread.Sleep(750);
                for (int i = 0; i < 20; i++)
                {
                    Thread.Sleep(500);
                    s = f - mas3[i];
                    Console.WriteLine(i + 1 + "). Вычитание: " + s);
                }
            });
            subtract.Wait();
        }
    }
}
