using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.EquipmentData.Armor;
using WinFormsApp1.EquipmentData.Weapons;

namespace WinFormsApp1.EquipmentData.Items.Armor
{
    public static class InitializeArmors
    {
        public static void Initialize()
        {
            Belts id21 = new Belts(21, "Belts", 1, 3, 1, "Leather belt", 0, 0, 0, 2, 0, "images\\items\\testArmor.jpg");
            Belts id22 = new Belts(22, "Belts", 1, 3, 1, "Worned belt", 0, 0, 0, 0, 2, "images\\items\\testArmor.jpg");
            Belts id23 = new Belts(23, "Belts", 1, 3, 1, "Shiny belt", 0, 0, 2, 0, 0, "images\\items\\testArmor.jpg");
            Belts id24 = new Belts(24, "Belts", 1, 3, 1, "Dirty belt", 0, 2, 0, 0, 0, "images\\items\\testArmor.jpg");
            Belts id25 = new Belts(25, "Belts", 1, 3, 1, "Compounted belt", 0, 1, 0, 4, 1, "images\\items\\testArmor.jpg");

            Boots id26 = new Boots(26, "Boots", 1, 3, 1, "Leather boots", 0, 1, 0, 2, 0, "images\\items\\testArmor.jpg");
            Boots id27 = new Boots(27, "Boots", 1, 3, 1, "Worned boots", 0, 0, 0, 0, 2, "images\\items\\testArmor.jpg");
            Boots id28 = new Boots(28, "Boots", 1, 3, 1, "Shiny boots", 0, 0, 2, 0, 0, "images\\items\\testArmor.jpg");
            Boots id29 = new Boots(29, "Boots", 1, 3, 1, "Dirty boots", 0, 2, 0, 2, 0, "images\\items\\testArmor.jpg");
            Boots id30 = new Boots(30, "Boots", 1, 3, 1, "Compounted boots", 0, 1, 0, 4, 1, "images\\items\\testArmor.jpg");

            Bracers id31 = new Bracers(31, "Bracers", 1, 3, 1, "Leather Bracers", 0, 1, 0, 2, 0, "images\\items\\testArmor.jpg");
            Bracers id32 = new Bracers(32, "Bracers", 1, 3, 1, "Worned Bracers", 0, 0, 0, 0, 2, "images\\items\\testArmor.jpg");
            Bracers id33 = new Bracers(33, "Bracers", 1, 3, 1, "Shiny Bracers", 0, 0, 2, 0, 0, "images\\items\\testArmor.jpg");
            Bracers id34 = new Bracers(34, "Bracers", 1, 3, 1, "Dirty Bracers", 0, 2, 0, 2, 0, "images\\items\\testArmor.jpg");
            Bracers id35 = new Bracers(35, "Bracers", 1, 3, 1, "Compounted Bracers", 0, 1, 0, 4, 1, "images\\items\\testArmor.jpg");

            Breastplates id36 = new Breastplates(36, "Breastplates", 1, 3, 1, "Leather Breastplate", 0, 1, 0, 2, 0, "images\\items\\testArmor.jpg");
            Breastplates id37 = new Breastplates(37, "Breastplates", 1, 3, 1, "Worned Breastplate", 0, 0, 0, 0, 2, "images\\items\\testArmor.jpg");
            Breastplates id38 = new Breastplates(38, "Breastplates", 1, 3, 1, "Shiny Breastplate", 0, 0, 2, 0, 0, "images\\items\\testArmor.jpg");
            Breastplates id39 = new Breastplates(39, "Breastplates", 1, 3, 1, "Dirty Breastplate", 0, 2, 0, 2, 0, "images\\items\\testArmor.jpg");
            Breastplates id40 = new Breastplates(40, "Breastplates", 1, 3, 1, "Compounted Breastplate", 0, 1, 0, 4, 1, "images\\items\\testArmor.jpg");

            Cloaks id41 = new Cloaks(41, "Cloaks", 1, 3, 1, "Leather Cloak", 0, 1, 0, 2, 0, "images\\items\\testArmor.jpg");
            Cloaks id42 = new Cloaks(42, "Cloaks", 1, 3, 1, "Worned Cloak", 0, 0, 0, 0, 2, "images\\items\\testArmor.jpg");
            Cloaks id43 = new Cloaks(43, "Cloaks", 1, 3, 1, "Shiny Cloak", 0, 0, 2, 0, 0, "images\\items\\testArmor.jpg");
            Cloaks id44 = new Cloaks(44, "Cloaks", 1, 3, 1, "Dirty Cloak", 0, 2, 0, 2, 0, "images\\items\\testArmor.jpg");
            Cloaks id45 = new Cloaks(45, "Cloaks", 1, 3, 1, "Compounted Cloak", 0, 1, 0, 4, 1, "images\\items\\testArmor.jpg");

            Gloves id46 = new Gloves(46, "Gloves", 1, 3, 1, "Leather gloves", 0, 1, 0, 2, 0, "images\\items\\testArmor.jpg");
            Gloves id47 = new Gloves(47, "Gloves", 1, 3, 1, "Worned gloves", 0, 0, 0, 0, 2, "images\\items\\testArmor.jpg");
            Gloves id48 = new Gloves(48, "Gloves", 1, 3, 1, "Shiny gloves", 0, 0, 2, 0, 0, "images\\items\\testArmor.jpg");
            Gloves id49 = new Gloves(49, "Gloves", 1, 3, 1, "Dirty gloves", 0, 2, 0, 2, 0, "images\\items\\testArmor.jpg");
            Gloves id50 = new Gloves(50, "Gloves", 1, 3, 1, "Compounted gloves", 0, 1, 0, 4, 1, "images\\items\\testArmor.jpg");

            Helmets id51 = new Helmets(51, "Helmets", 1, 3, 1, "Leather helmet", 0, 1, 0, 2, 0, "images\\items\\testArmor.jpg");
            Helmets id52 = new Helmets(52, "Helmets", 1, 3, 1, "Worned helmet", 0, 0, 0, 0, 2, "images\\items\\testArmor.jpg");
            Helmets id53 = new Helmets(53, "Helmets", 1, 3, 1, "Shiny helmet", 0, 0, 2, 0, 0, "images\\items\\testArmor.jpg");
            Helmets id54 = new Helmets(54, "Helmets", 1, 3, 1, "Dirty helmet", 0, 2, 0, 2, 0, "images\\items\\testArmor.jpg");
            Helmets id55 = new Helmets(55, "Helmets", 1, 3, 1, "Compounted helmet", 0, 1, 0, 4, 1, "images\\items\\testArmor.jpg");

            Necklaces id56 = new Necklaces(56, "Necklaces", 1, 3, 1, "Copper necklace", 0, 1, 0, 2, 0, "images\\items\\testArmor.jpg");
            Necklaces id57 = new Necklaces(57, "Necklaces", 1, 3, 1, "Iron necklace", 0, 0, 0, 0, 2, "images\\items\\testArmor.jpg");
            Necklaces id58 = new Necklaces(58, "Necklaces", 1, 3, 1, "Silver necklace", 0, 0, 2, 0, 0, "images\\items\\testArmor.jpg");
            Necklaces id59 = new Necklaces(59, "Necklaces", 1, 3, 1, "Gold necklace", 0, 2, 0, 2, 0, "images\\items\\testArmor.jpg");
            Necklaces id60 = new Necklaces(60, "Necklaces", 1, 3, 1, "Diamong necklace", 0, 1, 0, 4, 1, "images\\items\\testArmor.jpg");

            Pants id61 = new Pants(61, "Pants", 1, 3, 1, "Leather pants", 0, 1, 0, 2, 0, "images\\items\\testArmor.jpg");
            Pants id62 = new Pants(62, "Pants", 1, 3, 1, "Worned pants", 0, 0, 0, 0, 2, "images\\items\\testArmor.jpg");
            Pants id63 = new Pants(63, "Pants", 1, 3, 1, "Shiny pants", 0, 0, 2, 0, 0, "images\\items\\testArmor.jpg");
            Pants id64 = new Pants(64, "Pants", 1, 3, 1, "Dirty pants", 0, 2, 0, 2, 0, "images\\items\\testArmor.jpg");
            Pants id65 = new Pants(65, "Pants", 1, 3, 1, "Compounted pants", 0, 1, 0, 4, 1, "images\\items\\testArmor.jpg");

            Shoulders id66 = new Shoulders(66, "Shoulders", 1, 3, 1, "Leather Shoulders", 0, 1, 0, 2, 0, "images\\items\\testArmor.jpg");
            Shoulders id67 = new Shoulders(67, "Shoulders", 1, 3, 1, "Worned Shoulders", 0, 0, 0, 0, 2, "images\\items\\testArmor.jpg");
            Shoulders id68= new Shoulders(68, "Shoulders", 1, 3, 1, "Shiny Shoulders", 0, 0, 2, 0, 0, "images\\items\\testArmor.jpg");
            Shoulders id69 = new Shoulders(69, "Shoulders", 1, 3, 1, "Dirty Shoulders", 0, 2, 0, 2, 0, "images\\items\\testArmor.jpg");
            Shoulders id70 = new Shoulders(70, "Shoulders", 1, 3, 1, "Compounted Shoulders", 0, 1, 0, 4, 1, "images\\items\\testArmor.jpg");

            ArmoryData.Armory.Add(id21);
            ArmoryData.Armory.Add(id22);
            ArmoryData.Armory.Add(id23);
            ArmoryData.Armory.Add(id24);
            ArmoryData.Armory.Add(id25);

            ArmoryData.Armory.Add(id26);
            ArmoryData.Armory.Add(id27);
            ArmoryData.Armory.Add(id28);
            ArmoryData.Armory.Add(id29);
            ArmoryData.Armory.Add(id30);

            ArmoryData.Armory.Add(id31);
            ArmoryData.Armory.Add(id32);
            ArmoryData.Armory.Add(id33);
            ArmoryData.Armory.Add(id34);
            ArmoryData.Armory.Add(id35);

            ArmoryData.Armory.Add(id36);
            ArmoryData.Armory.Add(id37);
            ArmoryData.Armory.Add(id38);
            ArmoryData.Armory.Add(id39);
            ArmoryData.Armory.Add(id40);

            ArmoryData.Armory.Add(id41);
            ArmoryData.Armory.Add(id42);
            ArmoryData.Armory.Add(id43);
            ArmoryData.Armory.Add(id44);
            ArmoryData.Armory.Add(id45);

            ArmoryData.Armory.Add(id46);
            ArmoryData.Armory.Add(id47);
            ArmoryData.Armory.Add(id48);
            ArmoryData.Armory.Add(id49);
            ArmoryData.Armory.Add(id50);

            ArmoryData.Armory.Add(id51);
            ArmoryData.Armory.Add(id52);
            ArmoryData.Armory.Add(id53);
            ArmoryData.Armory.Add(id54);
            ArmoryData.Armory.Add(id55);

            ArmoryData.Armory.Add(id56);
            ArmoryData.Armory.Add(id57);
            ArmoryData.Armory.Add(id58);
            ArmoryData.Armory.Add(id59);
            ArmoryData.Armory.Add(id60);

            ArmoryData.Armory.Add(id61);
            ArmoryData.Armory.Add(id62);
            ArmoryData.Armory.Add(id63);
            ArmoryData.Armory.Add(id64);
            ArmoryData.Armory.Add(id65);

            ArmoryData.Armory.Add(id66);
            ArmoryData.Armory.Add(id67);
            ArmoryData.Armory.Add(id68);
            ArmoryData.Armory.Add(id69);
            ArmoryData.Armory.Add(id70);
        }
    }
}
