using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Async
{
    class Program
    {
        static async void Z(int[] m1, int[] m2)
        {
            await Task.Run(() =>
            {
                Random rnd = new Random();
                for (int i = 0; i < 20; i++)
                {
                    m1[i] = rnd.Next(0, 10);
                    m2[i] = rnd.Next(0, 10);
                }
            });
        }
        static async void R(int[] m1, int[] m2, int[] m3)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                for (int i = 0; i < 20; i++)
                {
                    m3[i] = m1[i] + m2[i];
                }
            });
        }
        static void Main(string[] args)
        {
            int[] mas1 = new int[20];
            int[] mas2 = new int[20];
            int[] mas3 = new int[20];

            Z(mas1, mas2);

            R(mas1, mas2, mas3);

            Console.WriteLine("Выберите сортировку: 0 - по возрастанию; 1 - по убыванию.");
            int v = Convert.ToInt32(Console.ReadLine());
            int mas = 0;
            while (v != 1 && v != 0)
            {
                Console.WriteLine("Выберите сортировку: 0 - по возрастанию; 1 - по убыванию.");
                v = Convert.ToInt32(Console.ReadLine());
            }
            if (v == 0)
            {
                Console.WriteLine("Ответ:");
                for (int i = 0; i < mas3.Length - 1; i++)
                {
                    for (int j = i + 1; j < mas3.Length; j++)
                    {
                        if (mas3[i] > mas3[j])
                        {
                            mas = mas3[i];
                            mas3[i] = mas3[j];
                            mas3[j] = mas;
                        }
                    }
                }
                for (int i = 0; i < mas3.Length - 1; i++)
                {
                    Console.WriteLine(mas3[i]);
                }
            }
            else
            {
                Console.WriteLine("Ответ:");
                for (int i = 0; i < mas3.Length - 1; i++)
                {
                    for (int j = i + 1; j < mas3.Length; j++)
                    {
                        if (mas3[i] < mas3[j])
                        {
                            mas = mas3[i];
                            mas3[i] = mas3[j];
                            mas3[j] = mas;
                        }
                    }
                }
                for (int i = 0; i < mas3.Length - 1; i++)
                {
                    Console.WriteLine(mas3[i]);
                }
            }

            Console.Read();
        }
    }
}
