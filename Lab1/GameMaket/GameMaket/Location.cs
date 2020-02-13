using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaket
{
    class Location
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public Location(string name)
		{
			this.Name = name;
		}
	}
}
