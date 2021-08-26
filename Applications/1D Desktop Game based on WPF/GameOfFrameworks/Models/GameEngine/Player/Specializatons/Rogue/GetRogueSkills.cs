using GameEngine.CombatEngine.Interfaces;
using GameEngine.SpecializationMechanics.Rogue.Skills;
using System.Collections.Generic;

namespace GameEngine.Player.Specializatons.Rogue
{
    public class GetRogueSkills
    {
        public List<ISkill> SkillList { get; } = new();
        public GetRogueSkills(int playerLevel)
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
                case > 16:
                    SetMasterSkills();
                    return;
                default:
                    break;
            }
        }

        public void SetNoviceSkills()
        {
            var backstab = new Backstab();
            SkillList.Add(backstab);
        }
        public void SetAdvancedSkills()
        {
            SetNoviceSkills();
            var rend = new Rend();
            SkillList.Add(rend);
        }
        public void SetAdeptSkills()
        {
            SetAdvancedSkills();
            var dissapearIntoTheShadows = new DissapearIntoTheShadows();
            SkillList.Add(dissapearIntoTheShadows);
        }
        public void SetExpertSkills()
        {
            SetAdeptSkills();
            var stun = new Stun();
            SkillList.Add(stun);
        }

        public void SetMasterSkills()
        {
            SetExpertSkills();
            var findTheWeakness = new FindTheWeakness();
            SkillList.Add(findTheWeakness);
        }
    }
}
