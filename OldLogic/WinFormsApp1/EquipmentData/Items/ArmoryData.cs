using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.EquipmentData.Items
{
   public static class ArmoryData
    {
        public static List<EquipmentBaseClass> Armory { get; set; }
        public static void InitializeArmory()
        {
            List<EquipmentBaseClass> armory = new List<EquipmentBaseClass> { };
            Armory = armory;

            Weapons.InitializeWeapons.Initialize();
            Armor.InitializeArmors.Initialize();
        }

        public static EquipmentBaseClass GetItemByID(int id)
        {
            foreach (var item in Armory)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
