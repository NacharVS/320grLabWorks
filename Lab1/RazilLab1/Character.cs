using System;
using System.Collections.Generic;
using System.Text;

namespace ClassEr
{
     class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string ClassCharacter { get; set; }
        public string Speciality { get; set; }
        public int LvL { get; set; }

        public Character(int id, string name, string race, string classCharacter, string speciality, int lvl)
        {
            Id = id;
            Name = name;
            Race = race;
            ClassCharacter = classCharacter;
            Speciality = speciality;
            LvL = lvl;
        }

        public virtual void displayCharacter()
        {
            Console.WriteLine($"Идентификатор: {Id}, \nИмя: {Name}, \nРасса: {Race}, \nКласс: {ClassCharacter}, \nСпециализация: {Speciality}, \nУровень: {LvL}. \n");
        }

    }
}
