using GameEngine.Equipment;
using GameEngine.Player;
using GameEngine.Player.ModelConditions;

namespace GameEngine.Data.Interfaces
{
    public interface IPlayerSaveData
    {
        ItemSerializationData ItemsInInventory { get; set; }
        ItemSerializationData ItemsOnCharacter { get; set; }
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
