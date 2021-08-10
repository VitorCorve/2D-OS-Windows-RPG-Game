using GameEngine.Equipment.Interfaces;

namespace GameEngine.Equipment
{
    public class DurabilityManager : IDurablityManager
    {
        public WearedEquipment DecreaseDurabilityAfterFight(WearedEquipment equipment)
        {
            foreach (var item in equipment.ItemsList)
                item.ItemDurability.Decrease(5);
            return equipment;
        }
        public WearedEquipment RecoverWearedEquipment(WearedEquipment equipment)
        {
            foreach (var item in equipment.ItemsList)
                item.ItemDurability.Increase(100);
            return equipment;
        }
        public int CalculateRepairValue(WearedEquipment equipment)
        {
            int repairvalue = 0;
            foreach (var item in equipment.ItemsList)
                repairvalue += 100 - item.ItemDurability.Value;
            return repairvalue;
        }
    }
}
