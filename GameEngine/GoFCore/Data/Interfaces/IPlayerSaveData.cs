using GameEngine.Equipment;
using GameEngine.Equipment.Resource;
using GameEngine.Inventory;
using GameEngine.Player;
using GameEngine.Player.ModelConditions;
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
        PlayerBiography Bio { get; }
        PlayerAvatar Avatar_ID { get; }
    }
}
