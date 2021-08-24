using GameEngine.CombatEngine.Interfaces;
using GameEngine.SpecializationMechanics.Warrior.Skills;
using System.Collections.Generic;

namespace GameEngine.Player.Specializatons.Warrior
{
    public class GetWarriorSkills
    {
        public List<ISkill> SkillList { get; } = new();
        public GetWarriorSkills(int playerLevel)
        {
            switch (playerLevel)
            {
                case < 4:
                    SetNoviceSkills();
                    return;
                case < 8:
                    SetAdvancedSkills();
                    return;
                case < 12:
                    SetAdeptSkills();
                    return;
                case < 16:
                    SetExpertSkills();
                    return;
                case < 30:
                    SetMasterSkills();
                    return;
                default:
                    SetMasterSkills();
                    break;
            }
        }

        public void SetNoviceSkills()
        {
            var powerHit = new PowerHit();
            SkillList.Add(powerHit);
        }
        public void SetAdvancedSkills()
        {
            SetNoviceSkills();
            var deepDefense = new DeepDefense();
            SkillList.Add(deepDefense);
        }
        public void SetAdeptSkills()
        {
            SetAdvancedSkills();
            var wideBlow = new WideBlow();
            SkillList.Add(wideBlow);
        }
        public void SetExpertSkills()
        {
            SetAdeptSkills();
            var crushLegs = new CrushLegs();
            SkillList.Add(crushLegs);
        }

        public void SetMasterSkills()
        {
            SetExpertSkills();
            var lastManStanding = new LastManStanding();
            SkillList.Add(lastManStanding);
        }
    }
}
