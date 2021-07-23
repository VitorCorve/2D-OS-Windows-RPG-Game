using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player.Specializatons.Warrior;
using GameEngine.Player.Specializatons.Rogue;
using GameEngine.Player.Specializatons.Mage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player
{
    public class GetAvailablePlayerSkills
    {
        public List<ISkill> SkillList { get; private set; } = new();
        public int PlayerLevel { get; private set; }
        public GetAvailablePlayerSkills(PlayerModelData playerModel)
        {
            PlayerLevel = playerModel.Level;

            switch (playerModel.Specialization)
            {
                case SPECIALIZATION.Warrior:
                    var warriorSkills = new GetAvailableWarriorSkills(PlayerLevel);
                    SkillList = warriorSkills.SkillList;
                    return;
                case SPECIALIZATION.Rogue:
                    var rogueSkills = new GetAvailableRogueSkills(PlayerLevel);
                    SkillList = rogueSkills.SkillList;
                    return;
                default:
                    var mageSkills = new GetAvailableMageSkills(PlayerLevel);
                    SkillList = mageSkills.SkillList;
                    return;
            }
        }
    }
}
