using GameEngine.CombatEngine.Interfaces;
using GameEngine.LevelUpMechanics.Interfaces.Services;
using GameEngine.Player;

namespace GameEngine.LevelUpMechanics.Services
{
    public class SkillLevelUpService : ISkillLevelUpService
    {
        public int MaxSelectValue { get; private set; }
        public int SelectValue
        {
            get { return _SelectValue; }
            set { _SelectValue = ValidateValue(value); }
        }
        private int _SelectValue;
        public PlayerSkillList PlayerSkills { get; private set; }
        public PlayerConsumablesData PlayerConsumables { get; private set; }
        public GetAvailablePlayerSkills AvailablePlayerSkills { get; private set; }
        public ISkill SkillToRaise { get; private set; }
        public SkillLevelUpService(PlayerModelData playerModel, PlayerSkillList playerSkills)
        {
            PlayerSkills = playerSkills;
            AvailablePlayerSkills = new GetAvailablePlayerSkills(playerModel);
            PlayerConsumables = playerModel.PlayerConsumables;
            SkillToRaise = AvailablePlayerSkills.SkillList[SelectValue];
            MaxSelectValue = AvailablePlayerSkills.SkillList.Count;
        }
        public void LevelUp()
        {
            foreach (var skill in PlayerSkills.Skills)
            {
                if (skill.GetType() == SkillToRaise.GetType())
                {
                    if (PlayerConsumables.SkillPointsValue.Value > 0)
                    {
                        PlayerConsumables.SkillPointsValue.Value--;
                        skill.SkillLevel++;
                        return;
                    }
                }
            }
            if (PlayerConsumables.SkillPointsValue.Value > 0)
            {
                PlayerConsumables.SkillPointsValue.Value--;
                PlayerSkills.AddSkillExperience(SkillToRaise);
            }
        }
        public void Select()
        {
            SelectValue++;
            SkillToRaise = AvailablePlayerSkills.SkillList[SelectValue];
        }
        public void LearnDirectly(ISkill skill)
        {
            PlayerSkills.AddSkillExperience(skill);
        }
        private int ValidateValue(int value)
        {
            if (SelectValue + value > MaxSelectValue)
                return 0;
            else
                return value;
        }
    }
}
