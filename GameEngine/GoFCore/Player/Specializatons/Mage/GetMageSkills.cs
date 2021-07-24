using GameEngine.CombatEngine.Interfaces;
using GameEngine.SpecializationMechanics.Mage.Skills;
using System.Collections.Generic;

namespace GameEngine.Player.Specializatons.Mage
{
    public class GetMageSkills
    {
        public List<ISkill> SkillList { get; } = new();
        public GetMageSkills(int playerLevel)
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
            var fireball = new Fireball();
            SkillList.Add(fireball);
        }
        public void SetAdvancedSkills()
        {
            SetNoviceSkills();
            var heal = new Heal();
            SkillList.Add(heal);
        }
        public void SetAdeptSkills()
        {
            SetAdvancedSkills();
            var magicShield = new MagicShield();
            SkillList.Add(magicShield);
        }
        public void SetExpertSkills()
        {
            SetAdeptSkills();
            var polymorph = new Polymorph();
            SkillList.Add(polymorph);
        }

        public void SetMasterSkills()
        {
            SetExpertSkills();
            var soulburn = new Soulburn();
            SkillList.Add(soulburn);
        }
    }
}
