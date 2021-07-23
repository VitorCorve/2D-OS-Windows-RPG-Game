using GameEngine.CombatEngine.Interfaces;
using GameEngine.LevelUpMechanics.Interfaces.Services;
using GameEngine.Player;
using System.Linq;

namespace GameEngine.LevelUpMechanics.Services
{
    public class SkillLevelUpService : ISkillLevelUpService
    {
        public PlayerSkillList PlayerSkills { get; private set; }
        public PlayerConsumablesData PlayerConsumables { get; private set; }
        public GetAvailablePlayerSkills AvailablePlayerSkills { get; private set; }
        public ISkill SkillToRaise { get; private set; }
        public SkillLevelUpService(PlayerModelData playerModel, PlayerConsumablesData playerConsumables, PlayerSkillList playerSkills)
        {
            PlayerSkills = playerSkills;
            AvailablePlayerSkills = new GetAvailablePlayerSkills(playerModel);
            PlayerConsumables = playerConsumables;
            SkillToRaise = AvailablePlayerSkills.SkillList.First();
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
                PlayerSkills.AddSkill(SkillToRaise);
            }
        }
        public void Select()
        {
            foreach (var item in AvailablePlayerSkills.SkillList)
            {
                if (item == AvailablePlayerSkills.SkillList.Last())
                    SkillToRaise = AvailablePlayerSkills.SkillList.First();

                if (item == SkillToRaise)
                    continue;

                SkillToRaise = item;
                return;
            }
        }

    }
}
