using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    public class Equipment : Invention
    {
        public string equipmentName { get; set; }
        public string equipmentDegreeProtection { get; set; }
        public new static List<Equipment> equipment = new List<Equipment>();

        public Equipment(string EquipmentName, string EquipmentDegreeProtection, Weapon Weapon, Equipment Equipment) : base(Weapon, Equipment)
        {
            equipmentName = EquipmentName;
            equipmentDegreeProtection = EquipmentDegreeProtection;
            equipment.Add(this);
        }
    }
}
