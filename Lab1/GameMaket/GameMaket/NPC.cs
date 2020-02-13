using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaket
{
    class NPC
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int usefull;

		public int Usefull
		{
			get { return usefull; }
			set { usefull = value; }
		}

		public NPC(string name, int usefull)
		{
			this.Name = name;
			this.Usefull = usefull;
		}
	}
}
