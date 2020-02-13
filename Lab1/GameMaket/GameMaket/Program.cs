using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaket
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldSet w = new WorldSet("Julia");
            w.AddBot("Goblin", 25);
            w.AddInventionary("Knife", 30);
            w.AddInventionary("Zoom", 5);
            w.AddLocation("Forest");
            w.AddNPC("Old Fura", 60);
            w.AddNPC("Fairy", 77);

            Account first = new Account("Rufina", "Ermeeva", 18, 
                "login", "password", w);

            Console.WriteLine(first.ToString());

            Console.ReadKey();
        }
    }
}
