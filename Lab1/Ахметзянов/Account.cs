using System;
using System.Collections.Generic;

namespace Account
{
    public class Account
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime dateOfCreate { get; set; }
        public string character { get; set; }
        public Invention invention { get; set; }
        public Stats stats { get; set; }
        public List<string> skills { get; set; }

        public Account(int ID, string Name, string Surname, string Email, string Login, string Password, 
                       DateTime DateOfCreate, string Character, Invention Invention, Stats Stats, List<string> Skills)
        {
            id = ID;
            name = Name;
            surname = Surname;
            email = Email;
            login = Login;
            password = Password;
            dateOfCreate = DateOfCreate;
            character = Character;
            invention = Invention;
            stats = Stats;
            skills = skills;
        }
    }
}
