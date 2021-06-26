using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsApp1.Interface.BattleWindow
{
    public class SkillButton
    {
        public Image stByImg { get; set; }
        public Image pressImg { get; set; }

        public Image Statement { get; set; }

        public string ImagePath { get; set; }
        public bool OnCoolDown { get; set; }

        public string Specialization { get; set; }

        public string SkillName { get; set; }

        public int opacity { get; set; }

        public string SkillDescription { get; set; }

        public SkillButton(string specialization, string skillName)
        {
            // rogue
            if (specialization == "rogue" && skillName == "Backstab")
            {
                stByImg = Image.FromFile("images\\skills\\rogue\\relButton\\1.jpg");
                Statement = Image.FromFile("images\\skills\\rogue\\relButton\\1.jpg");
                pressImg = Image.FromFile("images\\skills\\rogue\\pressButton\\1.jpg");
                ImagePath = "images\\skills\\rogue\\relButton\\1.jpg";

                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Backstab";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Rogue\\Backstab.txt");
            }

            if (specialization == "rogue" && skillName == "Rend")
            {
                stByImg = Image.FromFile("images\\skills\\rogue\\relButton\\2.jpg");
                Statement = Image.FromFile("images\\skills\\rogue\\relButton\\2.jpg");
                pressImg = Image.FromFile("images\\skills\\rogue\\pressButton\\2.jpg");
                ImagePath = "images\\skills\\rogue\\relButton\\2.jpg";

                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Rend";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Rogue\\Rend.txt");
            }

            if (specialization == "rogue" && skillName == "Stun")
            {
                stByImg = Image.FromFile("images\\skills\\rogue\\relButton\\3.jpg");
                Statement = Image.FromFile("images\\skills\\rogue\\relButton\\3.jpg");
                pressImg = Image.FromFile("images\\skills\\rogue\\pressButton\\3.jpg");
                ImagePath = "images\\skills\\rogue\\relButton\\3.jpg";

                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Stun";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Rogue\\Stun.txt");
            }

            if (specialization == "rogue" && skillName == "Dissapear")
            {
                stByImg = Image.FromFile("images\\skills\\rogue\\relButton\\4.jpg");
                Statement = Image.FromFile("images\\skills\\rogue\\relButton\\4.jpg");
                pressImg = Image.FromFile("images\\skills\\rogue\\pressButton\\4.jpg");
                ImagePath = "images\\skills\\rogue\\relButton\\4.jpg";

                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Dissapears Into The Shadows";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Rogue\\DissapearIntoTheShadows.txt");
            }

            if (specialization == "rogue" && skillName == "FTW")
            {
                stByImg = Image.FromFile("images\\skills\\rogue\\relButton\\5.jpg");
                Statement = Image.FromFile("images\\skills\\rogue\\relButton\\5.jpg");
                pressImg = Image.FromFile("images\\skills\\rogue\\pressButton\\5.jpg");
                ImagePath = "images\\skills\\rogue\\relButton\\5.jpg";

                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Find The Weakness";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Rogue\\FindTheWeakness.txt");
            }
            // <- rogue

            // mage
            if (specialization == "mage" && skillName == "Fireball")
            {
                stByImg = Image.FromFile("images\\skills\\mage\\relButton\\1.jpg");
                Statement = Image.FromFile("images\\skills\\mage\\relButton\\1.jpg");
                pressImg = Image.FromFile("images\\skills\\mage\\pressButton\\1.jpg");
                ImagePath = "images\\skills\\mage\\relButton\\1.jpg";

                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Fireball";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Mage\\Fireball.txt");
            }

            if (specialization == "mage" && skillName == "MagicShield")
            {
                stByImg = Image.FromFile("images\\skills\\mage\\relButton\\2.jpg");
                Statement = Image.FromFile("images\\skills\\mage\\relButton\\2.jpg");
                pressImg = Image.FromFile("images\\skills\\mage\\pressButton\\2.jpg");
                ImagePath = "images\\skills\\mage\\relButton\\2.jpg";
                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Magic Shield";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Mage\\MagicShield.txt");
            }

            if (specialization == "mage" && skillName == "Polymorph")
            {
                stByImg = Image.FromFile("images\\skills\\mage\\relButton\\3.jpg");
                Statement = Image.FromFile("images\\skills\\mage\\relButton\\3.jpg");
                pressImg = Image.FromFile("images\\skills\\mage\\pressButton\\3.jpg");
                ImagePath = "images\\skills\\mage\\relButton\\3.jpg";
                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Polymorph";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Mage\\Polymorph.txt");
            }

            if (specialization == "mage" && skillName == "Soulburn")
            {
                stByImg = Image.FromFile("images\\skills\\mage\\relButton\\4.jpg");
                Statement = Image.FromFile("images\\skills\\mage\\relButton\\4.jpg");
                pressImg = Image.FromFile("images\\skills\\mage\\pressButton\\4.jpg");
                ImagePath = "images\\skills\\mage\\relButton\\4.jpg";
                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Soul Burn";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Mage\\SoulBurn.txt");
            }

            if (specialization == "mage" && skillName == "Heal")
            {
                stByImg = Image.FromFile("images\\skills\\mage\\relButton\\5.jpg");
                Statement = Image.FromFile("images\\skills\\mage\\relButton\\5.jpg");
                pressImg = Image.FromFile("images\\skills\\mage\\pressButton\\5.jpg");
                ImagePath = "images\\skills\\mage\\relButton\\5.jpg";
                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Heal";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Mage\\Heal.txt");
            }

            // <- mage

            // warrior

            if (specialization == "warrior" && skillName == "Powerhit")
            {
                stByImg = Image.FromFile("images\\skills\\warrior\\relButton\\1.jpg");
                Statement = Image.FromFile("images\\skills\\warrior\\relButton\\1.jpg");
                pressImg = Image.FromFile("images\\skills\\warrior\\pressButton\\1.jpg");
                ImagePath = "images\\skills\\warrior\\relButton\\1.jpg";

                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Power Hit";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Warrior\\PowerHit.txt");
            }

            if (specialization == "warrior" && skillName == "DeepDefense")
            {
                stByImg = Image.FromFile("images\\skills\\warrior\\relButton\\2.jpg");
                Statement = Image.FromFile("images\\skills\\warrior\\relButton\\2.jpg");
                pressImg = Image.FromFile("images\\skills\\warrior\\pressButton\\2.jpg");
                ImagePath = "images\\skills\\warrior\\relButton\\2.jpg";
                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Deep Defense";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Warrior\\DeepDefense.txt");
            }

            if (specialization == "warrior" && skillName == "WideBlow")
            {
                stByImg = Image.FromFile("images\\skills\\warrior\\relButton\\3.jpg");
                Statement = Image.FromFile("images\\skills\\warrior\\relButton\\3.jpg");
                pressImg = Image.FromFile("images\\skills\\warrior\\pressButton\\3.jpg");
                ImagePath = "images\\skills\\warrior\\relButton\\3.jpg";
                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Wide Blow";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Warrior\\WideBlow.txt");
            }

            if (specialization == "warrior" && skillName == "CrushLegs")
            {
                stByImg = Image.FromFile("images\\skills\\warrior\\relButton\\4.jpg");
                Statement = Image.FromFile("images\\skills\\warrior\\relButton\\4.jpg");
                pressImg = Image.FromFile("images\\skills\\warrior\\pressButton\\4.jpg");
                ImagePath = "images\\skills\\warrior\\relButton\\4.jpg";
                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Crush Legs";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Warrior\\CrushLegs.txt");
            }

            if (specialization == "warrior" && skillName == "LastManStanding")
            {
                stByImg = Image.FromFile("images\\skills\\warrior\\relButton\\5.jpg");
                Statement = Image.FromFile("images\\skills\\warrior\\relButton\\5.jpg");
                pressImg = Image.FromFile("images\\skills\\warrior\\pressButton\\5.jpg");
                ImagePath = "images\\skills\\warrior\\relButton\\5.jpg";
                OnCoolDown = false;
                Specialization = specialization;
                SkillName = "Last Man Standing";
                SkillDescription = File.ReadAllText("Data\\skills\\Description\\Warrior\\LastManStanding.txt");
            }

            // <- warrior

        }

    }
}
