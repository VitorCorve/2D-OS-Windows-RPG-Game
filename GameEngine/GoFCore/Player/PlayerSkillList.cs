using GameEngine.Abstract;
using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player
{
    public class PlayerSkillList : IPlayerSkillList
    {
        public List<ISkill> Skills { get; set; } = new();
        public void AddSkillExperience(ISkill skill)
        {
            foreach (var item in Skills)
            {
                if (item.GetType() == skill.GetType())
                {
                    item.SkillLevel++;
                    return;
                }
            }
            skill.SkillLevel = 1;
            Skills.Add(skill);
        }
    }
}
