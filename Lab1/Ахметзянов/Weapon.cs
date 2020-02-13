using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    public class Weapon : Invention
    {
        public string weaponName { get; set; }
        public string weaponDamage { get; set; }
        public new static List<Weapon> weapon = new List<Weapon>();

        public Weapon(string WeaponDamage, string WeaponName, Weapon Weapon, Equipment Equipment) : base(Weapon, Equipment)
        {        
            weaponName = WeaponName;
            weaponDamage = WeaponDamage;
            weapon.Add(this);
        }
    }
}
