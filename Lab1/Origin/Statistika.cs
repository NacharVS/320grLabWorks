using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Statistika
    {
        Account id;
        Typofhero hero;
        int health;
        int reservatio;
        int level;

       
        public Typofhero Hero { get => hero; set => hero = value; }
        public int Health { get => health; set => health = value; }
        public int Reservatio { get => reservatio; set => reservatio = value; }
        public int Level { get => level; set => level = value; }
        public Account Id { get => id; set => id = value; }

        public Statistika(Account id, Typofhero hero, int health, int reservatio, int level)
        {
            this.id = id;
            this.hero = hero;
            this.health = health;
            this.reservatio = reservatio;
            this.level = level;
        }

    }
}
