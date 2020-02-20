using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncMass
{
    class Program
    {
        public static int[] massSum = new int[15];

        public static void FillingMass(int[] mass1, int[] mass2)
        {
            Random rnd = new Random();

            for (int i = 0; i < mass1.Length; i++)
            {
                mass1[i] = rnd.Next(-10, 40);
            }

            for (int i = 0; i < mass2.Length; i++)
            {
                mass2[i] = rnd.Next(-10, 40);
            }

            Console.WriteLine("Массивы заполнены.");
        }

        public static int[] SummingMass(int[] mass1, int[] mass2)
        {
            for (int i = 0; i < 15; i++)
            {
                massSum[i] = mass1[i] + mass2[i];
            }

            Console.WriteLine("Сумма массивов подсчитана.");
            return massSum;
        }

        public static void SortMass(int[] mass, int methodSort)
        {
            int temp;

            switch (methodSort)
            {
                case 1:
                    for (int i = 0; i < mass.Length; i++)
                    {
                        for (int j = 0; j < mass.Length - 1; j++)
                        {
                            if (mass[j] > mass[j + 1])
                            {
                                temp = mass[j];
                                mass[j] = mass[j + 1];
                                mass[j + 1] = temp;
                            }
                        }
                    }
                    Console.Write("Отсортированный массив по возрастанию: ");
                    for (int i = 0; i < mass.Length; i++)
                    {
                        Console.Write("[" + mass[i] + "]" + " ");
                    }
                    break;

                case 2:
                    for (int i = 0; i < mass.Length; i++)
                    {
                        for (int j = 0; j < mass.Length - 1; j++)
                        {
                            if (mass[j] < mass[j + 1])
                            {
                                temp = mass[j];
                                mass[j] = mass[j + 1];
                                mass[j + 1] = temp;
                            }
                        }
                    }
                    Console.Write("Отсортированный массив по убыванию: ");
                    for (int i = 0; i < mass.Length; i++)
                    {
                        Console.Write("[" + mass[i] + "]" + " ");
                    }
                    break;
            }
        }

        public static async void FillingMassAsync(int[] mass1, int[] mass2)
        {

            await Task.Run(() => FillingMass(mass1, mass2));
        }

        public static async void SummingMassAsync(int[] mass1, int[] mass2)
        {

            await Task.Run(() => SummingMass(mass1, mass2));
        }

        public static void Main(string[] args)
        {
            int[] mas1 = new int[15];
            int[] mas2 = new int[15];
            
            Console.WriteLine("Выберите способ сортировки массива.");
            Console.WriteLine("1. По возрастанию");
            Console.WriteLine("2. По убыванию.");
            Console.Write("> ");
            int item = int.Parse(Console.ReadLine());
            if (item < 1 || item > 2)
            {
                Console.Write("Некорректно. Повторите ввод: ");
                item = int.Parse(Console.ReadLine());
            }

            FillingMassAsync(mas1, mas2);
            SummingMassAsync(mas1, mas2);
            SortMass(massSum, item);

            Console.ReadKey();
        }
    }
}
