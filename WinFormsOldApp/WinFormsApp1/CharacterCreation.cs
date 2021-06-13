using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.CharCreation;
using WinFormsApp1.PlayerClasses;

namespace WinFormsApp1
{
    public partial class CharacterCreation : Form
    {
        public CharacterCreation()
        {
            InitializeComponent();
            Opacity = 0;

            Timer opacity = new Timer();
            opacity.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 5) opacity.Stop();
            });
            opacity.Interval = 5;
            opacity.Start();
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {
            // characterImage.Image = mageFemaleList.Images[0];
            InitalizeImages();
            InitializeDefaultChoise();
            // warriorChoiseButton.PerformClick();

            CheckForCorrection();

        }

        private void InitializeDefaultChoise()
        {

            if (Data.GetPlayer() != null)
            {

                try
                {
                    Player player = (Player)Data.GetPlayer();


                    strengthLabelText.Text = Convert.ToString(player.baseStrength);
                    intellectLabelText.Text = Convert.ToString(player.baseIntellect);
                    staminaLabelText.Text = Convert.ToString(player.baseStamina);
                    enduranceLabelText.Text = Convert.ToString(player.baseEndurance);
                    agilityLabelText.Text = Convert.ToString(player.baseAgility);
                    bioTextBox.Text = ChoiseData.Bio;
                    characterImage.Image = player.Avatar;

                    specializationDescription.Text = SpecializationDescription.Description[ChoiseData.Specialization];
                    attributeDescText.Text = AttributesDescription.Description[AttributesDescription.DescriptionChoise];
                }
                catch (Exception)
                {

                    
                }

            }
            else
            {
                ChoiseData.Gender = "male";
                ChoiseData.Specialization = "warrior";
                ChoiseData.ChoisePosition = 0;


                ChoiseData.Avatar = ImagesData.warriorMale[ChoiseData.ChoisePosition];
                ChoiseData.IconPath = ImagesData.PathWarriorMaleIcon[ChoiseData.ChoisePosition];
                characterImage.Image = ChoiseData.Avatar;

                SpecializationDescription.GetDescription();
                specializationDescription.Text = SpecializationDescription.Description[ChoiseData.Specialization];

                AttributesDescription.GetDescription();
                AttributesDescription.DescriptionChoise = "strength";
                attributeDescText.Text = AttributesDescription.Description[AttributesDescription.DescriptionChoise];


                InitializeWarriorStats();
            }
        }

        private void CheckForCorrection()
        {
            if (bioTextBox.Text.Length < 1)
            {
                warriorChoiseButton.PerformClick();
                bioTextBox.Text = "Stranger from the Lonesome road...";
            }
        }

        private void InitializeWarriorStats()
        {
            Warrior warrior = new Warrior();
            Data.SetPlayer(warrior);

            strengthLabelText.Text = Convert.ToString(warrior.baseStrength);
            intellectLabelText.Text = Convert.ToString(warrior.baseIntellect);
            staminaLabelText.Text = Convert.ToString(warrior.baseStamina);
            enduranceLabelText.Text = Convert.ToString(warrior.baseEndurance);
            agilityLabelText.Text = Convert.ToString(warrior.baseAgility);


        }

        private void InitializeRogueStats()
        {
            Rogue rogue = new Rogue();
            Data.SetPlayer(rogue);

            strengthLabelText.Text = Convert.ToString(rogue.baseStrength);
            intellectLabelText.Text = Convert.ToString(rogue.baseIntellect);
            staminaLabelText.Text = Convert.ToString(rogue.baseStamina);
            enduranceLabelText.Text = Convert.ToString(rogue.baseEndurance);
            agilityLabelText.Text = Convert.ToString(rogue.baseAgility);

        }

        private void InitializeMageStats()
        {
            Mage mage = new Mage();
            Data.SetPlayer(mage);

            strengthLabelText.Text = Convert.ToString(mage.baseStrength);
            intellectLabelText.Text = Convert.ToString(mage.baseIntellect);
            staminaLabelText.Text = Convert.ToString(mage.baseStamina);
            enduranceLabelText.Text = Convert.ToString(mage.baseEndurance);
            agilityLabelText.Text = Convert.ToString(mage.baseAgility);

        }

        private void CharacterCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void InitalizeImages()
        {
            List<Image> mageFemale = new List<Image> { };
            List<Image> mageFemaleIcon = new List<Image> { };
            List<Image> mageMale = new List<Image> { };
            List<Image> mageMaleIcon = new List<Image> { };
            List<Image> rogueFemale = new List<Image> { };
            List<Image> rogueFemaleIcon = new List<Image> { };
            List<Image> rogueMale = new List<Image> { };
            List<Image> rogueMaleIcon = new List<Image> { };
            List<Image> warriorFemale = new List<Image> { };
            List<Image> warriorFemaleIcon = new List<Image> { };
            List<Image> warriorMale = new List<Image> { };
            List<Image> warriorMaleIcon = new List<Image> { };

            List<string> PathMageFemale = new List<string> {};
            List<string> PathMageFemaleIcon = new List<string> {};
            List<string> PathMageMale = new List<string> {};
            List<string> PathMageMaleIcon = new List<string> {};
            List<string> PathRogueFemale = new List<string> {};
            List<string> PathRogueFemaleIcon = new List<string> {};
            List<string> PathRogueMale = new List<string> {};
            List<string> PathRogueMaleIcon = new List<string> {};
            List<string> PathWarriorFemale = new List<string> {};
            List<string> PathWarriorFemaleIcon = new List<string> {};
            List<string> PathWarriorMale = new List<string> {};
            List<string> PathWarriorMaleIcon = new List<string> {};




            for (int i = 1; i <= 10; i++)
            {
                mageFemale.Add(Image.FromFile($"images\\characters\\mageFemale\\{i}.jpg"));
                mageMale.Add(Image.FromFile($"images\\characters\\mageMale\\{i}.jpg"));
                rogueFemale.Add(Image.FromFile($"images\\characters\\rogueFemale\\{i}.jpg"));
                rogueMale.Add(Image.FromFile($"images\\characters\\rogueMale\\{i}.jpg"));
                warriorFemale.Add(Image.FromFile($"images\\characters\\warriorFemale\\{i}.jpg"));
                warriorMale.Add(Image.FromFile($"images\\characters\\warriorMale\\{i}.jpg"));

                mageFemaleIcon.Add(Image.FromFile($"images\\characters\\mageFemale\\avatar{i}.png"));
                mageMaleIcon.Add(Image.FromFile($"images\\characters\\mageMale\\avatar{i}.png"));
                rogueFemaleIcon.Add(Image.FromFile($"images\\characters\\rogueFemale\\avatar{i}.png"));
                rogueMaleIcon.Add(Image.FromFile($"images\\characters\\rogueMale\\avatar{i}.png"));
                warriorFemaleIcon.Add(Image.FromFile($"images\\characters\\warriorFemale\\avatar{i}.png"));
                warriorMaleIcon.Add(Image.FromFile($"images\\characters\\warriorMale\\avatar{i}.png"));

                PathMageFemale.Add($"images\\characters\\mageFemale\\{i}.jpg");
                PathMageMale.Add($"images\\characters\\mageMale\\{i}.jpg");
                PathRogueFemale.Add($"images\\characters\\rogueFemale\\{i}.jpg");
                PathRogueMale.Add($"images\\characters\\rogueMale\\{i}.jpg");
                PathWarriorFemale.Add($"images\\characters\\warriorFemale\\{i}.jpg");
                PathWarriorMale.Add($"images\\characters\\warriorMale\\{i}.jpg");

                PathMageFemaleIcon.Add($"images\\characters\\mageFemale\\avatar{i}.png");
                PathMageMaleIcon.Add($"images\\characters\\mageMale\\avatar{i}.png");
                PathRogueFemaleIcon.Add($"images\\characters\\rogueFemale\\avatar{i}.png");
                PathRogueMaleIcon.Add($"images\\characters\\rogueMale\\avatar{i}.png");
                PathWarriorFemaleIcon.Add($"images\\characters\\warriorFemale\\avatar{i}.png");
                PathWarriorMaleIcon.Add($"images\\characters\\warriorMale\\avatar{i}.png");
            }


            ImagesData.mageFemale = mageFemale;
            ImagesData.mageMale = mageMale;
            ImagesData.rogueFemale = rogueFemale;
            ImagesData.rogueMale = rogueMale;
            ImagesData.warriorFemale = warriorFemale;
            ImagesData.warriorMale = warriorMale;

            ImagesData.mageFemaleIcon = mageFemaleIcon;
            ImagesData.mageMaleIcon = mageMaleIcon;
            ImagesData.rogueFemaleIcon = rogueFemaleIcon;
            ImagesData.rogueMaleIcon = rogueMaleIcon;
            ImagesData.warriorFemaleIcon = warriorFemaleIcon;
            ImagesData.warriorMaleIcon = warriorMaleIcon;

            ImagesData.PathMageFemale = PathMageFemale;
            ImagesData.PathMageMale = PathMageMale;
            ImagesData.PathRogueFemale = PathRogueFemale;
            ImagesData.PathRogueMale = PathRogueMale;
            ImagesData.PathWarriorFemale = PathWarriorFemale;
            ImagesData.PathWarriorMale = PathWarriorMale;


            ImagesData.PathMageFemaleIcon = PathMageFemaleIcon;
            ImagesData.PathMageMaleIcon = PathMageMaleIcon;
            ImagesData.PathRogueFemaleIcon = PathRogueFemaleIcon;
            ImagesData.PathRogueMaleIcon = PathRogueMaleIcon;
            ImagesData.PathWarriorFemaleIcon = PathWarriorFemaleIcon;
            ImagesData.PathWarriorMaleIcon = PathWarriorMaleIcon;

            characterImage.Image = warriorMale[0];
            ChoiseData.ImagePath = ImagesData.PathWarriorMale[0];
        }

        public void SelectImages(string gender, string specialization, int choisePosition)
        {
            if (gender == "female" && specialization == "mage")
            {
                ChoiseData.Avatar = ImagesData.mageFemale[choisePosition];
                characterImage.Image = ChoiseData.Avatar;
                ChoiseData.ImagePath = ImagesData.PathMageFemale[choisePosition];
                ChoiseData.IconPath = ImagesData.PathMageFemaleIcon[choisePosition];
            }

            if (gender == "male" && specialization == "mage")
            {
                ChoiseData.Avatar = ImagesData.mageMale[choisePosition];
                characterImage.Image = ChoiseData.Avatar;
                ChoiseData.ImagePath = ImagesData.PathMageMale[choisePosition];
                ChoiseData.IconPath = ImagesData.PathMageMaleIcon[choisePosition];
            }

            if (gender == "female" && specialization == "rogue")
            {
                ChoiseData.Avatar = ImagesData.rogueFemale[choisePosition];
                characterImage.Image = ChoiseData.Avatar;
                ChoiseData.ImagePath = ImagesData.PathRogueFemale[choisePosition];
                ChoiseData.IconPath = ImagesData.PathRogueFemaleIcon[choisePosition];
            }

            if (gender == "male" && specialization == "rogue")
            {
                ChoiseData.Avatar = ImagesData.rogueMale[choisePosition];
                characterImage.Image = ChoiseData.Avatar;
                ChoiseData.ImagePath = ImagesData.PathRogueMale[choisePosition];
                ChoiseData.IconPath = ImagesData.PathRogueMaleIcon[choisePosition];
            }

            if (gender == "female" && specialization == "warrior")
            {
                ChoiseData.Avatar = ImagesData.warriorFemale[choisePosition];
                characterImage.Image = ChoiseData.Avatar;
                ChoiseData.ImagePath = ImagesData.PathWarriorFemale[choisePosition];
                ChoiseData.IconPath = ImagesData.PathWarriorFemaleIcon[choisePosition];
            }

            if (gender == "male" && specialization == "warrior")
            {
                ChoiseData.Avatar = ImagesData.warriorMale[choisePosition];
                characterImage.Image = ChoiseData.Avatar;
                ChoiseData.ImagePath = ImagesData.PathWarriorMale[choisePosition];
                ChoiseData.IconPath = ImagesData.PathWarriorMaleIcon[choisePosition];
            }
        }

        private void maleRadioTrigger_CheckedChanged(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            ChoiseData.Gender = "male";
            SelectImages(ChoiseData.Gender, ChoiseData.Specialization, ChoiseData.ChoisePosition);
        }

        private void femaleRadioTrigger_CheckedChanged(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            ChoiseData.Gender = "female";
            SelectImages(ChoiseData.Gender, ChoiseData.Specialization, ChoiseData.ChoisePosition);
        }

        private void swapLeftButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            ChoiseData.ChoisePosition -= 1;

            if (ChoiseData.ChoisePosition == -1)
            {
                ChoiseData.ChoisePosition = 9;
            }

            SelectImages(ChoiseData.Gender, ChoiseData.Specialization, ChoiseData.ChoisePosition);
        }

        private void swapRIghtButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            ChoiseData.ChoisePosition += 1;

            if (ChoiseData.ChoisePosition == 10)
            {
                ChoiseData.ChoisePosition = 0;
            }

            SelectImages(ChoiseData.Gender, ChoiseData.Specialization, ChoiseData.ChoisePosition);
        }

        private void warriorChoiseButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            ChoiseData.Specialization = "warrior";


            SelectImages(ChoiseData.Gender, ChoiseData.Specialization, ChoiseData.ChoisePosition);
            specializationDescription.Text = SpecializationDescription.Description[ChoiseData.Specialization];
            InitializeWarriorStats();
        }

        private void mageChoiseButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            ChoiseData.Specialization = "mage";

            SelectImages(ChoiseData.Gender, ChoiseData.Specialization, ChoiseData.ChoisePosition);
            specializationDescription.Text = SpecializationDescription.Description[ChoiseData.Specialization];
            InitializeMageStats();
        }

        private void rogueChoiseButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            ChoiseData.Specialization = "rogue";

            SelectImages(ChoiseData.Gender, ChoiseData.Specialization, ChoiseData.ChoisePosition);
            specializationDescription.Text = SpecializationDescription.Description[ChoiseData.Specialization];
            InitializeRogueStats();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            this.Hide();
            var run = new RunGame();
            run.Show();
            
            

        }
 
        private void strengthDescButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            AttributesDescription.DescriptionChoise = "strength";
            attributeDescText.Text = AttributesDescription.Description[AttributesDescription.DescriptionChoise];
        }

        private void intellectDescButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            AttributesDescription.DescriptionChoise = "intellect";
            attributeDescText.Text = AttributesDescription.Description[AttributesDescription.DescriptionChoise];
        }

        private void staminaDescButton_Click(object sender, EventArgs e)
        {
            AttributesDescription.DescriptionChoise = "stamina";
            attributeDescText.Text = AttributesDescription.Description[AttributesDescription.DescriptionChoise];
        }

        private void enduranceDescButton_Click(object sender, EventArgs e)
        {
            AttributesDescription.DescriptionChoise = "endurance";
            attributeDescText.Text = AttributesDescription.Description[AttributesDescription.DescriptionChoise];
        }

        private void agilityDescButton_Click(object sender, EventArgs e)
        {
            AttributesDescription.DescriptionChoise = "agility";
            attributeDescText.Text = AttributesDescription.Description[AttributesDescription.DescriptionChoise];
        }

        private void ConfirmChangesButton_Click(object sender, EventArgs e)
        {
            Player checkName = (Player)Data.GetPlayer();
            checkName.name = nameTextBox.Text;
            if (System.IO.Directory.Exists($"saves\\player\\{checkName.name}"))
            {
                MessageBox.Show($"Character {checkName.name} already exists");
                return;
            }


            var strRUS = Regex.IsMatch(nameTextBox.Text, "^[А-Яа-я]+$");
            var strENG = Regex.IsMatch(nameTextBox.Text, "^[A-Za-z]+$");
            ChoiseData.Bio = bioTextBox.Text;
            if (nameTextBox.Text.Length < 1)
            {
                MessageBox.Show("Enter player name");
                return;
            }

            if (nameTextBox.Text.Length > 16)
            {
                MessageBox.Show("Player name must contains up to 16 characters");
                return;
            }

            if (!strRUS && !strENG)
            {
                MessageBox.Show("Incorrect name:\n Name must contain russian or english characters");
            }
            else
            {
                string name = nameTextBox.Text.ToLower();
                name = char.ToUpper(name[0]) + name.Substring(1);

                
                if (ChoiseData.Specialization == "mage")
                {
                    Mage player = new Mage();
                    player.SetGender(ChoiseData.Gender);
                    player.Bio = ChoiseData.Bio;
                    player.SetName(name);
                    player.Avatar = ChoiseData.Avatar;;
                    player.AvatarPath = ChoiseData.ImagePath;
                    player.Specialization = ChoiseData.Specialization;
                    player.IconPath = ChoiseData.IconPath;
                    Data.SetPlayer(player);

                }

                if (ChoiseData.Specialization == "rogue")
                {
                    Rogue player = new Rogue();
                    player.SetGender(ChoiseData.Gender);
                    player.Bio = ChoiseData.Bio;
                    player.SetName(name);
                    player.Avatar = ChoiseData.Avatar;
                    player.AvatarPath = ChoiseData.ImagePath;
                    player.Specialization = ChoiseData.Specialization;
                    player.IconPath = ChoiseData.IconPath;
                    Data.SetPlayer(player);
                }

                if (ChoiseData.Specialization == "warrior")
                {
                    Warrior player = new Warrior();
                    player.SetGender(ChoiseData.Gender);
                    player.Bio = ChoiseData.Bio;
                    player.SetName(name);
                    player.Avatar = ChoiseData.Avatar;
                    player.AvatarPath = ChoiseData.ImagePath;
                    player.Specialization = ChoiseData.Specialization;
                    player.IconPath = ChoiseData.IconPath;
                    Data.SetPlayer(player);
                }



                



                this.Hide();
                var ApplyChanges = new skillNamePanel();
                ApplyChanges.Show();
            }




        }
    }
}
