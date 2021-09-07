using GameEngine.SpecializationMechanics.Warrior.Skills;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Services
{
    public class WarriorSkillViewListBuilder : ISkillViewListBuilder
    {
        public List<ISkillView> Get()
        {
            var userUISkillList = new List<ISkillView>();

            var skill1View = new SkillView();
            skill1View.Skill = new PowerHit();
            skill1View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\warrior\\1.jpg";
            skill1View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\Warrior\\PowerHit.txt");

            var skill2View = new SkillView();
            skill2View.Skill = new DeepDefense();
            skill2View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\warrior\\2.jpg";
            skill2View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\Warrior\\DeepDefense.txt");

            var skill3View = new SkillView();
            skill3View.Skill = new WideBlow();
            skill3View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\warrior\\3.jpg";
            skill3View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\Warrior\\WideBlow.txt");


            var skill4View = new SkillView();
            skill4View.Skill = new CrushLegs();
            skill4View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\warrior\\4.jpg";
            skill4View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\Warrior\\CrushLegs.txt");

            var skill5View = new SkillView();
            skill5View.Skill = new LastManStanding();
            skill5View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\warrior\\5.jpg";
            skill5View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\Warrior\\LastManStanding.txt");

            userUISkillList.Add(skill1View);
            userUISkillList.Add(skill2View);
            userUISkillList.Add(skill3View);
            userUISkillList.Add(skill4View);
            userUISkillList.Add(skill5View);

            return userUISkillList;
        }
    }
}
