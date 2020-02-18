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
        static void Str()
        {
            string result = "";
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("*");
            }
            Thread.Sleep(8000);
            Console.WriteLine(result);
        }
        static void Str2()
        {
            string result = "";
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("#");
            }
            Thread.Sleep(8000);
            Console.WriteLine(result);
        }
        // определение асинхронного метода
        static async void StrAsync()
        {
            Console.WriteLine("Начало метода FactorialAsync"); // выполняется синхронно
            await Task.Run(() => Str());
            await Task.Run(() => Str2());
            // выполняется асинхронно
            Console.WriteLine("Конец метода FactorialAsync");
        }

        static void Main(string[] args)
        {
            StrAsync();   // вызов асинхронного метода
            Console.Read();
        }
    }
}
