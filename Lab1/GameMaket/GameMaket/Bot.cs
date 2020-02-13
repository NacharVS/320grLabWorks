using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaket
{
    class Bot
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int damage;

		public int Damage
		{
			get { return damage; }
			set { damage = value; }
		}

		public Bot(string name, int damage)
		{
			this.Name = name;
			this.Damage = damage;
		}
	}
}
