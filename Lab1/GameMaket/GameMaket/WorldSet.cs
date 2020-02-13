using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaket
{
    class WorldSet
    {
		private string nameHero;

		public string NameHero
		{
			get { return nameHero; }
			set { nameHero = value; }
		}

		protected List<Location> locations = new List<Location> { };
		protected List<NPC> NPCs = new List<NPC> { };
		protected List<Bot> bots = new List<Bot> { };
		protected List<Inventionary> inventionaries = new List<Inventionary> { };

		public WorldSet(string nameHero)
		{
			this.NameHero = nameHero;
		}
		
		protected WorldSet()
		{

		}

		public void AddLocation(string name)
		{
			Location l = new Location(name);
			this.locations.Add(l);
		}

		public void AddNPC(string name, int usefull)
		{
			NPC npc = new NPC(name, usefull);
			this.NPCs.Add(npc);
		}

		public void AddBot(string name, int damage)
		{
			Bot bot = new Bot(name, damage);
			this.bots.Add(bot);
		}

		public void AddInventionary(string name, int power)
		{
			Inventionary inv= new Inventionary(name, power);
			this.inventionaries.Add(inv);
		}

		public override string ToString()
		{
			string st = nameHero + " " + locations[0].Name;
			return st;
		}
	}
}
