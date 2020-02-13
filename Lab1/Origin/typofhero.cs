using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Typofhero
    {
        string hero;
        int health ;
        int reservatio ;
        int level;

        public Typofhero(string hero, int health, int reservatio, int level)
        {
            this.hero = hero;
            this.health = health;
            this.reservatio = reservatio;
            this.level = level;
        }

        public string Hero { get => hero; set => hero = value; }
        public int Reservatio { get => reservatio; set => reservatio = value; }
        public int Level { get => level; set => level = value; }

    }
}
