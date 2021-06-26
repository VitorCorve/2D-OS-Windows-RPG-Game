using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.EquipmentData.Weapons;

namespace WinFormsApp1.EquipmentData.Items.Weapons
{
    public static class InitializeWeapons
    {
        public static void Initialize()
        {
            OneHandedWeapons id1 = new OneHandedWeapons(1, "OneHanded", 1, 3, 1, 1, "Rusty sword", 3, 2, 0, 0, 0, "images\\combatText\\attack.png");
            OneHandedWeapons id2 = new OneHandedWeapons(2, "OneHanded", 1, 3, 2, 1, "Bastard sword", 2, 1, 0, 0, 0, "images\\combatText\\attack.png");
            OneHandedWeapons id3 = new OneHandedWeapons(3, "OneHanded", 1, 3, 1, 1, "Wooden sword", 1, 1, 0, 0, 0, "images\\combatText\\attack.png");
            OneHandedWeapons id4 = new OneHandedWeapons(4, "OneHanded", 1, 3, 2, 1, "Forged sword", 4, 2, 0, 0, 0, "images\\combatText\\attack.png");
            OneHandedWeapons id5 = new OneHandedWeapons(5, "OneHanded", 1, 3, 1, 1, "Bloody knife", 1, 1, 0, 0, 2, "images\\combatText\\attack.png");

            TwoHandedWeapons id6 = new TwoHandedWeapons(6, "TwoHanded", 1, 3, 3, 2, "Zweihander", 2, 1, 0, 0, 0, "images\\combatText\\attack.png");
            TwoHandedWeapons id7 = new TwoHandedWeapons(7, "TwoHanded", 1, 3, 2, 2, "Appollon", 3, 2, 0, 0, 0, "images\\combatText\\attack.png");
            TwoHandedWeapons id8 = new TwoHandedWeapons(8, "TwoHanded", 1, 3, 3, 2, "Sharpened sword", 2, 3, 0, 0, 0, "images\\combatText\\attack.png");
            TwoHandedWeapons id9 = new TwoHandedWeapons(9, "TwoHanded", 1, 3, 5, 3, "Heavy sword", 2, 2, 0, 0, 0, "images\\combatText\\attack.png");
            TwoHandedWeapons id10 = new TwoHandedWeapons(10, "TwoHanded", 1, 3, 3, 2, "Blackmarked sword", 3, 1, 0, 0, 0, "images\\combatText\\attack.png");

            Staffs id11 = new Staffs(11, "Staff", 1, 3, 1, 3, "Magic staff", 0, 1, 0, 1, 0, "images\\combatText\\attack.png");
            Staffs id12 = new Staffs(12, "Staff", 1, 3, 1, 2, "Enchanted staff", 0, 1, 0, 2, 0, "images\\combatText\\attack.png");
            Staffs id13 = new Staffs(13, "Staff", 1, 3, 1, 2, "Strange staff", 0, 0, 0, 3, 0, "images\\combatText\\attack.png");
            Staffs id14 = new Staffs(14, "Staff", 1, 3, 1, 3, "Blessed staff", 0, 2, 0, 1, 0, "images\\combatText\\attack.png");
            Staffs id15 = new Staffs(15, "Staff", 1, 3, 1, 3, "Cursed sword", 0, 0, 0, 4, 0, "images\\combatText\\attack.png");

            Books id16 = new Books(16, "Book", 1, 3, 1, 1, "Magic Book", 0, 1, 0, 2, 0, "images\\combatText\\attack.png");
            Books id17 = new Books(17, "Book", 1, 3, 1, 2, "Enchanted Book", 0, 2, 0, 2, 0, "images\\combatText\\attack.png");
            Books id18 = new Books(18, "Book", 1, 3, 1, 2, "Strange Book", 0, 1, 0, 2, 0, "images\\combatText\\attack.png");
            Books id19 = new Books(19, "Book", 1, 3, 1, 3, "Blessed Book", 0, 2, 0, 1, 0, "images\\combatText\\attack.png");
            Books id20 = new Books(20, "Book", 1, 3, 1, 3, "Cursed sword", 0, 0, 0, 4, 0, "images\\combatText\\attack.png");

            ArmoryData.Armory.Add(id1);
            ArmoryData.Armory.Add(id2);
            ArmoryData.Armory.Add(id3);
            ArmoryData.Armory.Add(id4);
            ArmoryData.Armory.Add(id5);
            ArmoryData.Armory.Add(id6);
            ArmoryData.Armory.Add(id7);
            ArmoryData.Armory.Add(id8);
            ArmoryData.Armory.Add(id9);
            ArmoryData.Armory.Add(id10);
            ArmoryData.Armory.Add(id11);
            ArmoryData.Armory.Add(id12);
            ArmoryData.Armory.Add(id13);
            ArmoryData.Armory.Add(id14);
            ArmoryData.Armory.Add(id15);
            ArmoryData.Armory.Add(id16);
            ArmoryData.Armory.Add(id17);
            ArmoryData.Armory.Add(id18);
            ArmoryData.Armory.Add(id19);
            ArmoryData.Armory.Add(id20);
        }
    }
}
