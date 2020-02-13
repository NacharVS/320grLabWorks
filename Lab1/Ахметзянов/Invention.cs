using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    public class Invention
    {
        public Weapon weapon { get; set; }
        public Equipment equipment { get; set; }

        public Invention(Weapon Weapon, Equipment Equipment) 
        {
            weapon = Weapon;
            equipment = Equipment;
        }
    }
}
