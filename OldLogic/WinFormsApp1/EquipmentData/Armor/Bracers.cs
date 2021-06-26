using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.EquipmentData.Armor
{
    public class Bracers : ArmorClass
    {
        public Bracers(int id, string itemClass, int carryMinLevel, int carryMaxLevel, int armor, string name, int strength, int stamina, int endurance, int intellect, int agility, string image)
        {
            ID = id;
            ItemClass = itemClass;
            CarryMinLevel = carryMinLevel;
            CarryMaxLevel = carryMaxLevel;
            ArmorValue = armor;
            Name = name;
            Strength = strength;
            Stamina = stamina;
            Endurance = endurance;
            Intellect = intellect;
            Agility = agility;
            ImageUrl = image;
        }
    }
}
