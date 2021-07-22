using GameEngine.CombatEngine.Interfaces;
using GameEngine.LevelUpMechanics.Interfaces.Services;
using GameEngine.SpecializationMechanics.Mage.Skills;

namespace GameEngine.LevelUpMechanics

{
    public class SkillRaiseUpManager : ISkillRaiseUpmanager
    {
        public ISkill Skill { get; private set; }
        public int SkillLevel { get; private set; }
        public SkillRaiseUpManager(ISkill skill)
        {
            Skill = skill;
            SkillLevel = skill.SkillLevel;
        }

        public void Raise()
        {

        }
    }
}
