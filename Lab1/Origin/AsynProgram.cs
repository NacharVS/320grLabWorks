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
    
        static async void InputMas(int[] mas,int[]mas1)
        {
            await Task.Run(() =>
            {
                Random rnd = new Random();
                for (int i = 0; i < 2; i++)
                {
                    mas[i] = rnd.Next(0, 10);
                    mas1[i] = rnd.Next(0, 10);

                }
            });
        }

        static async void SumMas(int[] mas, int[] mas1,int []mas2)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                for (int i = 0; i < 2; i++)
                {
                    mas2[i] = mas[i] + mas1[i];
                }
            });
        }
        static void Main(string[] args)
        {
            int[] m = new int[2];
            int[] m1 = new int[2];
            int[] m2 = new int[2];

            SumMas(m,m1,m2);
            InputMas(m,m1);

            Console.WriteLine("сортировка : по возрастанию(1), по убыванию(2)");
            int var = Convert.ToInt32(Console.ReadLine());
            int massiv = 0;
            while (var != 1 && var != 2)
            {
                Console.WriteLine("сортировка : по возрастанию(1), по убыванию(2)");
                var = Convert.ToInt32(Console.ReadLine());
            }
            if (var == 1)
            {
                Console.WriteLine("ответ:");
                for (int i = 0; i < m2.Length - 1; i++)
                {
                    for (int j = i + 1; j < m2.Length; j++)
                    {
                        if (m2[i] > m2[j])
                        {
                            massiv = m2[i];
                            m2[i] = m2[j];
                            m2[j] = massiv;
                        }
                    }
                }
                for (int i = 0; i < m2.Length - 1; i++)
                {
                    Console.WriteLine(m2[i]);
                }
            }
            else
            {
                Console.WriteLine("ответ:");
                for (int i = 0; i < m2.Length - 1; i++)
                {
                    for (int j = i + 1; j < m2.Length; j++)
                    {
                        if (m2[i] < m2[j])
                        {
                            massiv = m2[i];
                            m2[i] = m2[j];
                            m2[j] = massiv;
                        }
                    }
                }
                for (int i = 0; i < m2.Length - 1; i++)
                {
                    Console.WriteLine(m2[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
