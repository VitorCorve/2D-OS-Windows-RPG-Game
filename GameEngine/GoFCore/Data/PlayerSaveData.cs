using GameEngine.Data.Interfaces;
using GameEngine.Equipment;
using GameEngine.Player;
using GameEngine.Player.ModelConditions;

namespace GameEngine.Data
{
    public class PlayerSaveData : IPlayerSaveData
    {
        public ItemSerializationData ItemsInInventory { get; set; } = new();
        public ItemSerializationData ItemsOnCharacter{ get; set; } = new();
        public PlayerSkillList Skills { get; set; }
        public int AvailableSkillPoints { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public GENDER Gender { get; set; }
        public int Money { get; set; }
        public PlayerBiography Bio { get; set; }
        public PlayerAvatar Avatar_ID { get; set; }
    }
}
