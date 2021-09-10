﻿using GameEngine.SpecializationMechanics.Mage.Skills;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Services
{
    public class MageSkillViewListBuilder : ISkillViewListBuilder
    {
        public List<ISkillView> Get()
        {
            var userUISkillList = new List<ISkillView>();


            var skill1View = new SkillView();
            skill1View.Skill = new Fireball();
            skill1View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\mage\\1.jpg";
            skill1View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\mage\\Fireball.txt");

            var skill2View = new SkillView();
            skill2View.Skill = new Heal();
            skill2View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\mage\\2.jpg";
            skill2View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\mage\\Heal.txt");

            var skill3View = new SkillView();
            skill3View.Skill = new MagicShield();
            skill3View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\mage\\3.jpg";
            skill3View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\mage\\MagicShield.txt");


            var skill4View = new SkillView();
            skill4View.Skill = new Polymorph();
            skill4View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\mage\\4.jpg";
            skill4View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\mage\\Polymorph.txt");

            var skill5View = new SkillView();
            skill5View.Skill = new Soulburn();
            skill5View.ImagePath = $"{Environment.CurrentDirectory}\\Data\\Images\\skills\\mage\\5.jpg";
            skill5View.Description = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\skills\\Description\\mage\\SoulBurn.txt");

            userUISkillList.Add(skill1View);
            userUISkillList.Add(skill2View);
            userUISkillList.Add(skill3View);
            userUISkillList.Add(skill4View);
            userUISkillList.Add(skill5View);

            return userUISkillList;
        }
    }
}