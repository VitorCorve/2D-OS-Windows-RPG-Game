using GameEngine.Abstract;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using GameEngine.Player.Abstract;


namespace GameEngine.Data.Interfaces
{
    public interface IPlayerLoadData
    {
        WearedEquipment Equipment { get; }
        PlayerInventoryItemsList Inventory { get; }
        PlayerSkillList ListOfSkills { get; }
        PlayerModelData PlayerModel { get; }
        PlayerSpecializationAttributes Specialization { get; }
        IEntityAttributes SpecializationAttributes { get; }
    }
}
