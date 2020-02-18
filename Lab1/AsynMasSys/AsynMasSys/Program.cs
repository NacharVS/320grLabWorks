using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsynMasSys
{
    class Program
    {
        public static List<int> sum = new List<int> { };

        public static void AddRandom(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int num = rnd.Next(1, 10);
                a[i] = num;
                //Console.WriteLine("mas[{0}]={1}", i, num);
            }
            Console.WriteLine("generaed");
        }

        public static void SumMas(int[]a1, int[] a2)
        {
            for (int i = 0; i < 5; i++)
            {
                int num = a1[i] + a2[i];
                //Console.WriteLine("a1[{0}] + a2[{0}]={1}", i, num);
                sum.Add(num);
            }
            Console.WriteLine("summ ready");
        }

        public static void SortMas(List<int> a, bool choose)
        {
            a.Sort();
            Console.WriteLine("Sort:");

            if (choose == true)
            {
                foreach (var k in a)
                {
                    Console.WriteLine(k);
                }
            }
            else
            {
                a.Reverse();

                foreach (var k in a)
                {
                    Console.WriteLine(k);
                }
            }
            
        }

        public static async void AddRandomAsync(int[] a)
        {
            await Task.Run(() => AddRandom(a));
        }

        public static async void SumMasAsync(int[] a1, int[] a2)
        {
            Thread.Sleep(500);
            await Task.Run(() => SumMas(a1, a2));
        }

        //public static /*async*/ void SortMasAsync(List<int> a, bool choose)
        //{
        //    Thread.Sleep(500);
        //    await Task.Run(() => SortMas(a, choose));
        //}

        static void Main(string[] args)
        {
            int[] mas1 = new int[5];
            int[] mas2 = new int[5];

            Console.Write("Choose up: ");
            Console.WriteLine();

            AddRandomAsync(mas1);
            AddRandomAsync(mas2);

            SumMasAsync(mas1, mas2);

            bool choose = Convert.ToBoolean(Console.ReadLine());

            SortMas(sum, choose);

            Console.ReadKey();
        }
    }
}
