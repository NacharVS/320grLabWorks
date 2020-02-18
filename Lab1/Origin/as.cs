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
       static async void ALIAsync(int[] m1 ,int [] m2,int [] m3)
       {
            await Task.Run(() =>
            {
                for (int i=0;i<10;i++)
                {
                    m3[i] = m3[i] + m2[i];
                }
            });
       }
        static async void ILSAsync(int[] m1, int[] m2)
        {
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500);
                m1[i] = rnd.Next(-10, 10);
                Console.Write(m1[i] + ",");
                m2[i] = rnd.Next(-10, 10);
                Console.Write(m2[i] + ",");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[] m1 = new int[10];
            int[] m2 = new int[10];
            int[] m3 = new int[10];

            ALIAsync(m1, m2, m3);
            ILSAsync(m1, m2);
            Console.WriteLine("Сортировка: 1-по возр,2-по убыв");
            int n = Convert.ToInt32(Console.ReadLine());
            int m;
            while(n!=1 && n!=2)
            {
                Console.WriteLine("Сортировка: 1-по возр,2-по убыв");
                n = Convert.ToInt32(Console.ReadLine());
            }
            if (n==1)
            {
                Console.WriteLine("Результат");
                for(int i=0;i<m3.Length-1;i++)
                {
                    for (int j = i+1; j < m3.Length; j++)
                    {
                        if (m3[i]>m3[j])
                        {
                            m = m3[i];
                            m3[i] = m3[j];
                            m3[j] = m;
                            Console.WriteLine(m3[i]);
                        }
                    }
                }
                for (int i = 0; i < m3.Length - 1; i++)
                {
                    Console.WriteLine(m3[i]);
                }
            }
            else
            {
                Console.WriteLine("Результат");
                for (int i = 0; i < m3.Length - 1; i++)
                {
                    for (int j = i + 1; j < m3.Length; j++)
                    {
                        if (m3[i] < m3[j])
                        {
                            m = m3[i];
                            m3[i] = m3[j];
                            m3[j] = m;
                            Console.WriteLine(m3[i]);
                        }
                    }
                }
                for (int i = 0; i < m3.Length - 1; i++)
                {
                    Console.WriteLine(m3[i]);
                }
            }
            Console.ReadKey();
        }
    }

}

