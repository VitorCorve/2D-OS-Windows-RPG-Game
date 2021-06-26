using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.CharCreation;
using WinFormsApp1.PlayerClasses.Skills;

namespace WinFormsApp1
{
    public partial class skillNamePanel : Form
    {
        static string Specialization;
        public skillNamePanel()
        {
            InitializeComponent();
            Opacity = 0;

            System.Windows.Forms.Timer opacity = new System.Windows.Forms.Timer();
            opacity.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 5) opacity.Stop();
            });
            opacity.Interval = 5;
            opacity.Start();
        }

        private void ApplyCharacterCreationChoise_Load(object sender, EventArgs e)
        {
            InitializeAttributes();
        }

        private void InitializeAttributes()
        {
            Player player = (Player)Data.GetPlayer();

            characterImage.Image = player.Avatar;

            strengthLabelText.Text = Convert.ToString(player.GetStrength());
            agilityLabelText.Text = Convert.ToString(player.GetAgility());
            intellectLabelText.Text = Convert.ToString(player.GetIntellect());
            staminaLabelText.Text = Convert.ToString(player.GetStamina());
            enduranceLabelText.Text = Convert.ToString(player.GetEndurance());
            characterNameLabel.Text = Convert.ToString(player.GetName());
            classDescription.Text = SpecializationDescription.Description[ChoiseData.Specialization];

            attackPowerText.Text = Convert.ToString(player.GetAttackPower());
            manaLabelText.Text = Convert.ToString(player.GetMana());
            healthLabelText.Text = Convert.ToString(player.GetHealthPoints());
            energyLabelText.Text = Convert.ToString(player.GetEnergy());
            dodgeLabelText.Text = Convert.ToString(player.DodgeChance) + "%";

            genderTextLabel.Text = char.ToUpper(player.GetGender()[0]) + player.GetGender().Substring(1);
            classTextLabel.Text = char.ToUpper(player.Specialization[0]) + player.Specialization.Substring(1);
            bioDescriptionLabel.Text = player.Bio;

            Specialization = player.Specialization;

            InitializeSkills();

            Skill1Button.PerformClick();

            
        }

        private void InitializeSkills()
        {
            SkillsImagesData.InitalizeImages();


            if (Specialization == "mage")
            {
                Skill1Button.Image = SkillsImagesData.Mage[0];
                Skill2Button.Image = SkillsImagesData.Mage[1];
                Skill3Button.Image = SkillsImagesData.Mage[2];
                Skill4Button.Image = SkillsImagesData.Mage[3];
                Skill5Button.Image = SkillsImagesData.Mage[4];
            }

            if (Specialization == "warrior")
            {
                Skill1Button.Image = SkillsImagesData.Warrior[0];
                Skill2Button.Image = SkillsImagesData.Warrior[1];
                Skill3Button.Image = SkillsImagesData.Warrior[2];
                Skill4Button.Image = SkillsImagesData.Warrior[3];
                Skill5Button.Image = SkillsImagesData.Warrior[4];
            }

            if (Specialization == "rogue")
            {
                Skill1Button.Image = SkillsImagesData.Rogue[0];
                Skill2Button.Image = SkillsImagesData.Rogue[1];
                Skill3Button.Image = SkillsImagesData.Rogue[2];
                Skill4Button.Image = SkillsImagesData.Rogue[3];
                Skill5Button.Image = SkillsImagesData.Rogue[4];
            }


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count; i > 1; i--)
            {
                if (Application.OpenForms.Count < 4)
                {
                    break;
                }
                if (Application.OpenForms.Count > 2)
                {
                    break;
                }
                else
                {
                    Application.OpenForms[i - 1].Close();
                }
            }
            this.Hide();

                var CharCreation = new CharacterCreation();
            CharCreation.Show();
        }

        private void Skill1Button_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            SkillsDescription.GetDescription();

            if (Specialization == "mage")
            {
                skillsDescription.Text = SkillsDescription.MageSkillsDescription["1"];
                skillNameLabel.Text = SkillsDescription.MageSkillNames[0];
            }

            if (Specialization == "warrior")
            {
                skillsDescription.Text = SkillsDescription.WarriorSkillsDescription["1"];
                skillNameLabel.Text = SkillsDescription.WarriorSkillNames[0];
            }

            if (Specialization == "rogue")
            {
                skillsDescription.Text = SkillsDescription.RogueSkillsDescription["1"];
                skillNameLabel.Text = SkillsDescription.RogueSkillNames[0];
            }

        }

        private void Skill2Button_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            SkillsDescription.GetDescription();

            if (Specialization == "mage")
            {
                skillsDescription.Text = SkillsDescription.MageSkillsDescription["2"];
                skillNameLabel.Text = SkillsDescription.MageSkillNames[1];
            }

            if (Specialization == "warrior")
            {
                skillsDescription.Text = SkillsDescription.WarriorSkillsDescription["2"];
                skillNameLabel.Text = SkillsDescription.WarriorSkillNames[1];
            }

            if (Specialization == "rogue")
            {
                skillsDescription.Text = SkillsDescription.RogueSkillsDescription["2"];
                skillNameLabel.Text = SkillsDescription.RogueSkillNames[1];
            }

        }

        private void Skill3Button_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            SkillsDescription.GetDescription();

            if (Specialization == "mage")
            {
                skillsDescription.Text = SkillsDescription.MageSkillsDescription["3"];
                skillNameLabel.Text = SkillsDescription.MageSkillNames[2];
            }

            if (Specialization == "warrior")
            {
                skillsDescription.Text = SkillsDescription.WarriorSkillsDescription["3"];
                skillNameLabel.Text = SkillsDescription.WarriorSkillNames[2];
            }

            if (Specialization == "rogue")
            {
                skillsDescription.Text = SkillsDescription.RogueSkillsDescription["3"];
                skillNameLabel.Text = SkillsDescription.RogueSkillNames[2];
            }
        }

        private void Skill4Button_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            SkillsDescription.GetDescription();

            if (Specialization == "mage")
            {
                skillsDescription.Text = SkillsDescription.MageSkillsDescription["4"];
                skillNameLabel.Text = SkillsDescription.MageSkillNames[3];
            }

            if (Specialization == "warrior")
            {
                skillsDescription.Text = SkillsDescription.WarriorSkillsDescription["4"];
                skillNameLabel.Text = SkillsDescription.WarriorSkillNames[3];
            }

            if (Specialization == "rogue")
            {
                skillsDescription.Text = SkillsDescription.RogueSkillsDescription["4"];
                skillNameLabel.Text = SkillsDescription.RogueSkillNames[3];
            }
        }

        private void Skill5Button_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            SkillsDescription.GetDescription();

            if (Specialization == "mage")
            {
                skillsDescription.Text = SkillsDescription.MageSkillsDescription["5"];
                skillNameLabel.Text = SkillsDescription.MageSkillNames[4];
            }

            if (Specialization == "warrior")
            {
                skillsDescription.Text = SkillsDescription.WarriorSkillsDescription["5"];
                skillNameLabel.Text = SkillsDescription.WarriorSkillNames[4];
            }

            if (Specialization == "rogue")
            {
                skillsDescription.Text = SkillsDescription.RogueSkillsDescription["5"];
                skillNameLabel.Text = SkillsDescription.RogueSkillNames[4];
            }
        }

        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            Player player = (Player)Data.GetPlayer();
            
            

            player.SaveData();
            MessageBox.Show($"Character {player.GetName()} was created");
            this.Hide();
            var gameMenu = new GameMenu();
            gameMenu.Show();
        }
    }
}
