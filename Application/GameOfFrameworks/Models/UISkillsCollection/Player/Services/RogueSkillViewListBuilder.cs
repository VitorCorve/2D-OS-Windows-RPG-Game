using GameEngine.SpecializationMechanics.Rogue.Skills;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Services
{
    public class RogueSkillViewListBuilder : ISkillViewListBuilder
    {
        public List<ISkillView> Get()
        {
            var userUISkillList = new List<ISkillView>();

            var skill1View = new SkillView();
            skill1View.Skill = new Backstab();
            skill1View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\rogue\\relButton\\1.jpg";
            skill1View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\rogue\\Backstab.txt");

            var skill2View = new SkillView();
            skill2View.Skill = new Rend();
            skill2View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\rogue\\relButton\\2.jpg";
            skill2View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\rogue\\Rend.txt");

            var skill3View = new SkillView();
            skill3View.Skill = new DissapearIntoTheShadows();
            skill3View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\rogue\\relButton\\3.jpg";
            skill3View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\rogue\\DissapearIntoTheShadows.txt");


            var skill4View = new SkillView();
            skill4View.Skill = new Stun();
            skill4View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\rogue\\relButton\\4.jpg";
            skill4View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\rogue\\Stun.txt");

            var skill5View = new SkillView();
            skill5View.Skill = new FindTheWeakness();
            skill5View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\rogue\\relButton\\5.jpg";
            skill5View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\rogue\\FindTheWeakness.txt");

            userUISkillList.Add(skill1View);
            userUISkillList.Add(skill2View);
            userUISkillList.Add(skill3View);
            userUISkillList.Add(skill4View);
            userUISkillList.Add(skill5View);

            return userUISkillList;
        }
    }
}
