using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsnSys
{
    class Program
    {
        public static void Resh()
        {
            Console.WriteLine("#");
        }

        public static void Star()
        {
            Console.WriteLine("*");
        }

        public static async void ReshAsync(int count)
        {
            Console.WriteLine("asyn resh begin");

            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(1000);
                await Task.Run(() => Resh());
            }
            
            Console.WriteLine("asyn resh end");
        }

        public static async void StarAsync(int count)
        {
            Console.WriteLine("asyn star begin");

            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(1000);
                await Task.Run(() => Star());
            }
            
            Console.WriteLine("asyn star end");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("main start");

            Console.Write("count: ");
            int count = Convert.ToInt32(Console.ReadLine());

            ReshAsync(count);
            StarAsync(count);

            Console.WriteLine("Main end");
            Console.ReadKey();
        }
    }
}
