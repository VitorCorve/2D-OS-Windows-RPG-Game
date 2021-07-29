using GameEngine.Abstract;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using System.Collections.Generic;

namespace GameEngine.Data.Interfaces
{
    public interface IPlayerLoadData
    {
        WearedEquipment Equipment { get; }
        PlayerInventoryItemsList Inventory { get; }
        PlayerSkillList Skills { get; }
        List<ItemAttributes> ItemsList { get; }
        PlayerModelData PlayerModel { get; }
        PlayerSpecialization Specialization { get; }
        IEntityAttributes SpecializationAttributes { get; }
    }
}
