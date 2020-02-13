using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaket
{
    class Account
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string surname;

		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}

		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		private string login;

		public string Login
		{
			get { return login; }
			set { login = value; }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		List<WorldSet> ws = new List<WorldSet> { };

		public Account(string name, string surname, int age,
			string login, string password, WorldSet w)
		{
			this.Name = name;
			this.Surname = surname;
			this.Age = age;
			this.Login = login;
			this.Password = Password;
			ws.Add(w);
		}

		public override string ToString()
		{
			string st = this.name + " " + this.ws[0].ToString();
			return st;
		}
	}
}
