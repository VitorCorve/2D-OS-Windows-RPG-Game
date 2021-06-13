using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.EquipmentData
{
    public class EquipmentBaseClass
    {
        public int ID { get; set; }

        public int CarryMinLevel { get; set; }
        public int CarryMaxLevel { get; set; }
        public string Name { get; set; }
        public int Durability { get; set; }
        
        public string ItemClass { get; set; }

        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Endurance { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
        public int ArmorValue { get; set; }

        public int DamageValue { get; set; }

        public double AttackSpeed { get; set; }

        public string ImageUrl { get; set; }

        public EquipmentBaseClass()
        {
            Durability = 100;
        }
    }
}
