using GameEngine.CharacterCreationMaster.Interfaces;
using GameEngine.CharacterCreationMaster.Services;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.ModelConditions;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster
{
    public class CharacterCreationData : ICharacterCreationData
    {
        public IEntityAttributes CharacterAttributes { get; set; }
        public string Name { get; set; } = null;
        public GENDER Gender { get; set; } = GENDER.Male;
        public SPECIALIZATION CharacterSpecialization { get; set; } = SPECIALIZATION.Warrior;
        public PlayerBiography Bio { get; set; } = null;
        public List<PlayerAvatar> PlayerAvatarsList { get; set; } = new();
        public PlayerAvatar Avatar { get; set; }
        public int AvatarsCount { get; set; } = 30;
        public int AvatarSelectionValue
        {
            get { return _AvatarSelectionValue; }
            set { _AvatarSelectionValue = ValidateAvatarSelectionValue(value); }
        }
        private int _AvatarSelectionValue;
        public List<string> AttributesDescriptionList { get; set; } = new();
        public string AttributeDescription { get; set; }
        public List<ISkill> AvailableSkills { get; set; } = new();
        public CharacterCreationData()
        {
            string str = "Character strength directly affects to attack power.";
            string stm = "The more stamina, the more health points character has. Also, stamina affects to chance to immune to incoming damage.";
            string endur = "Endurance determines how much energy you have. And it's also affects to physical skills power.";
            string intellect = "Intellect affects to magical skills power and determines amount of available mana.";
            string agility = "Agility affects to chance to dodge attacks and deal additional critcal damage.";

            AttributesDescriptionList.Add(str);
            AttributesDescriptionList.Add(stm);
            AttributesDescriptionList.Add(endur);
            AttributesDescriptionList.Add(intellect);
            AttributesDescriptionList.Add(agility);

            var avatarsData = new GetAvatarsData();
            PlayerAvatarsList = avatarsData.GetAvatarsList(CharacterSpecialization);

            foreach (var item in PlayerAvatarsList)
            {
                if (item.ID == 0)
                    Avatar = item;
                break;
            }
        }
        private int ValidateAvatarSelectionValue(int value)
        {
            if (AvatarSelectionValue + value > AvatarsCount)
                return 0;
            if (AvatarSelectionValue - value < 0)
                return AvatarsCount;
            else
                return value;
        }
    }
}
