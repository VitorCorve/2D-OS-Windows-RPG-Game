using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using System.Collections.Generic;

namespace GameEngine.Data.Interfaces
{
    public interface IPlayerSaveData
    {
        WearedEquipment Equipment { get; }
        PlayerInventoryItemsList Inventory { get; }
        PlayerSkillList Skills { get;  }
        int Level { get; }
        string Name { get; }
        string Specialization { get; }
        GENDER Gender { get; }
        int Money { get; }
        List<ItemAttributes> ItemsList { get; }
    }
}
