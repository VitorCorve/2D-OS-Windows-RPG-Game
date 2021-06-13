using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.EquipmentData;
using System.IO;
using WinFormsApp1.EquipmentData.Weapons;
using WinFormsApp1.EquipmentData.Armor;
using WinFormsApp1.EquipmentData.Items;

namespace WinFormsApp1.GameMenuForms
{
    public partial class Equipment : Form
    {
        public Equipment()
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

        private void Inventory_Load(object sender, EventArgs e)
        {
            CheckEquipment();
            // test section

            /*            TwoHandedWeapons weapon = new TwoHandedWeapons(1, 1.2, "Crusher", 3, 0, 0, 0, 0);
                        weapon.ImageUrl = "images\\items\\testSword.jpg";
                        EquipmentValue.Add(weapon);



                        Shoulders shoulder = new Shoulders(20, "Awful Shoulders", 3, 10, 10, 1, 1);
                        shoulder.ImageUrl = "images\\items\\testShoulder.jpg";
                        EquipmentValue.Add(shoulder);

                        CheckEquipment();*/


            /*            OneHandedWeapons weapon = new OneHandedWeapons(4, 1.2, "Warglaive of Azzinoth", 0, 32, 10, 0, 0);
                        weapon.ImageUrl = "images\\items\\testWarglaive.jpg";
                        EquipmentValue.Add(weapon);*/


            /*            OneHandedWeapons weaponTwo = new OneHandedWeapons(3, 1.2, "Warglaive of Azzinoth", 8, 0, 1, 50, 14);
                        weaponTwo.ImageUrl = "images\\items\\testWarglaive.jpg";
                        EquipmentValue.Add(weaponTwo);*/
        }

        private void CheckEquipment()
        {
            if (EquipmentValue._Shoulders != null)
            {
                shouldersPicture.Image = Image.FromFile(EquipmentValue._Shoulders.ImageUrl);
            }

            if (EquipmentValue._Belt != null)
            {
                beltPicture.Image = Image.FromFile(EquipmentValue._Belt.ImageUrl);
            }

            if (EquipmentValue._Boots != null)
            {
                bootsPicture.Image = Image.FromFile(EquipmentValue._Boots.ImageUrl);
            }

            if (EquipmentValue._Bracers != null)
            {
                bracersPicture.Image = Image.FromFile(EquipmentValue._Bracers.ImageUrl);
            }

            if (EquipmentValue._Breastplate != null)
            {
                chestPicture.Image = Image.FromFile(EquipmentValue._Breastplate.ImageUrl);
            }

            if (EquipmentValue._Cloak != null)
            {
                cloakPicture.Image = Image.FromFile(EquipmentValue._Cloak.ImageUrl);
            }

            if (EquipmentValue._Gloves != null)
            {
                handsPicture.Image = Image.FromFile(EquipmentValue._Gloves.ImageUrl);
            }

            if (EquipmentValue._Helmet != null)
            {
                helmetPicture.Image = Image.FromFile(EquipmentValue._Helmet.ImageUrl);
            }

            if (EquipmentValue._Necklace != null)
            {
                necklacePicture.Image = Image.FromFile(EquipmentValue._Necklace.ImageUrl);
            }

            if (EquipmentValue._Pants != null)
            {
                pantsPicture.Image = Image.FromFile(EquipmentValue._Pants.ImageUrl);
            }

            if (EquipmentValue._Shoulders != null)
            {
                shouldersPicture.Image = Image.FromFile(EquipmentValue._Shoulders.ImageUrl);
            }

            if (EquipmentValue._MainWeapon != null)
            {
                firstWeaponPicture.Image = Image.FromFile(EquipmentValue._MainWeapon.ImageUrl);
            }

            if (EquipmentValue._SecondaryWeapon != null)
            {
                secondWeaponPicture.Image = Image.FromFile(EquipmentValue._SecondaryWeapon.ImageUrl);
            }

            if (EquipmentValue._Artefact != null)
            {
                artefactPicture.Image = Image.FromFile(EquipmentValue._Artefact.ImageUrl);
            }
        }
        private void beltPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._Belt != null)
            {
                InitializeLabels(EquipmentValue._Belt);
            }
        }

        private void beltPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        private void chestPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._Breastplate != null)
            {
                InitializeLabels(EquipmentValue._Breastplate);
            }
        }

        private void chestPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        private void pantsPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._Pants != null)
            {
                InitializeLabels(EquipmentValue._Pants);
            }
        }

        private void pantsPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        private void handsPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._Gloves != null)
            {
                InitializeLabels(EquipmentValue._Gloves);
            }
        }

        private void handsPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        private void bracersPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._Bracers != null)
            {
                InitializeLabels(EquipmentValue._Bracers);
            }
        }

        private void bracersPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        private void bootsPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._Boots != null)
            {
                InitializeLabels(EquipmentValue._Boots);
            }
        }

        private void bootsPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        private void necklacePicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._Necklace != null)
            {
                InitializeLabels(EquipmentValue._Necklace);
            }
        }

        private void necklacePicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        private void helmetPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._Helmet != null)
            {
                InitializeLabels(EquipmentValue._Helmet);
            }
        }

        private void helmetPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        private void cloakPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._Cloak != null)
            {
                InitializeLabels(EquipmentValue._Cloak);
            }
        }

        private void cloakPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        private void artefactPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._Artefact != null)
            {
                InitializeLabels(EquipmentValue._Artefact);
            }
        }

        private void artefactPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }
        private void firstWeaponPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._MainWeapon != null)
            {
                InitializeLabels(EquipmentValue._MainWeapon);
            }
        }
        private void firstWeaponPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        private void shouldersPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._Shoulders != null)
            {
                InitializeLabels(EquipmentValue._Shoulders);
            }
        }

        private void shouldersPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        private void secondWeaponPicture_MouseHover(object sender, EventArgs e)
        {
            if (EquipmentValue._SecondaryWeapon != null)
            {
                InitializeLabels(EquipmentValue._SecondaryWeapon);
            }
        }

        private void secondWeaponPicture_MouseLeave(object sender, EventArgs e)
        {
            descriptionPanel.Hide();
            CleanDescription();
        }

        public Dictionary<string, double> CountItemStatRows(EquipmentBaseClass item)
        {
            Dictionary<string, double> statRows = new Dictionary<string, double> { };

            if (item.DamageValue > 0)
            {
                statRows.Add("damageValue", item.DamageValue);
            }

            if (item.AttackSpeed > 0)
            {
                statRows.Add("attackSpeed", item.AttackSpeed);
            }


            if (item.Stamina > 0)
            {
                statRows.Add("stamina", item.Stamina);
            }

            if (item.Strength > 0)
            {
                statRows.Add("strength", item.Strength);
            }

            if (item.Endurance > 0)
            {
                statRows.Add("endurance", item.Endurance);
            }

            if (item.Intellect > 0)
            {
                statRows.Add("intellect", item.Intellect);
            }

            if (item.Agility > 0)
            {
                statRows.Add("agility", item.Agility);
            }

            if (item.ArmorValue > 0)
            {
                statRows.Add("armorValue", item.ArmorValue);
            }

                return statRows;

        }

        private void InitializeLabels(EquipmentBaseClass equippedItem)
        {
            Dictionary<string, double> statRows = CountItemStatRows(equippedItem);

            descriptionPanel.Show();

            itemDescName.Text = equippedItem.Name;

            descPanelItemImage.Image = Image.FromFile(equippedItem.ImageUrl);

            durabilityValue.Text = equippedItem.Durability + "/100";

            int labelPositionX = 17;
            int labelPosiitonY = 150;

            int ValuePositionX = 114;
            int ValuePositionY = 150;

            int rowsCount = 1;



            foreach (var stats in statRows)
            {
                int addValueY = 21;
                int calculateY = addValueY * rowsCount;

                if (stats.Key == "attackSpeed")
                {
                    attackSpeedDesc.Location = new Point(labelPositionX, labelPosiitonY + calculateY);
                    attackSpeedValue.Location = new Point(ValuePositionX, ValuePositionY + calculateY);
                    attackSpeedValue.Text = Convert.ToString(stats.Value) + " /s.";
                    attackSpeedDesc.Show();
                    attackSpeedValue.Show();

                    rowsCount += 1;
                }

                if (stats.Key == "armorValue")
                {
                    armorRatingDesc.Location = new Point(labelPositionX, labelPosiitonY + calculateY);
                    armorValue.Location = new Point(ValuePositionX, ValuePositionY + calculateY);
                    armorValue.Text = Convert.ToString(stats.Value);
                    armorRatingDesc.Show();
                    armorValue.Show();

                    rowsCount += 1;
                }

                if (stats.Key == "damageValue")
                {
                    DamageDesc.Location = new Point(labelPositionX, labelPosiitonY + calculateY);
                    damageValue.Location = new Point(ValuePositionX, ValuePositionY + calculateY);
                    damageValue.Text = Convert.ToString(stats.Value);
                    DamageDesc.Show();
                    damageValue.Show();

                    rowsCount += 1;
                }

                if (stats.Key == "stamina")
                {
                    staminaDesc.Location = new Point(labelPositionX, labelPosiitonY + calculateY);
                    staminaValue.Location = new Point(ValuePositionX, ValuePositionY + calculateY);
                    staminaValue.Text = Convert.ToString(stats.Value);
                    staminaDesc.Show();
                    staminaValue.Show();

                    rowsCount += 1;
                }

                if (stats.Key == "strength")
                {
                    strengthDesc.Location = new Point(labelPositionX, labelPosiitonY + calculateY);
                    strengthValue.Location = new Point(ValuePositionX, ValuePositionY + calculateY);
                    strengthValue.Text = Convert.ToString(stats.Value);
                    strengthDesc.Show();
                    strengthValue.Show();

                    rowsCount += 1;
                }

                if (stats.Key == "endurance")
                {
                    enduranceDesc.Location = new Point(labelPositionX, labelPosiitonY + calculateY);
                    enduranceValue.Location = new Point(ValuePositionX, ValuePositionY + calculateY);
                    enduranceValue.Text = Convert.ToString(stats.Value);
                    enduranceDesc.Show();
                    enduranceValue.Show();

                    rowsCount += 1;
                }

                if (stats.Key == "intellect")
                {
                    intellectDesc.Location = new Point(labelPositionX, labelPosiitonY + calculateY);
                    intellectValue.Location = new Point(ValuePositionX, ValuePositionY + calculateY);
                    intellectValue.Text = Convert.ToString(stats.Value);
                    intellectDesc.Show();
                    intellectValue.Show();

                    rowsCount += 1;
                }

                if (stats.Key == "agility")
                {
                    agilityDesc.Location = new Point(labelPositionX, labelPosiitonY + calculateY);
                    agilityValue.Location = new Point(ValuePositionX, ValuePositionY + calculateY);
                    agilityValue.Text = Convert.ToString(stats.Value);
                    agilityDesc.Show();
                    agilityValue.Show();

                    rowsCount += 1;
                }
            }
        }

        private void CleanDescription()
        {
            attackSpeedDesc.Hide();
            attackSpeedValue.Hide();
            armorRatingDesc.Hide();
            armorValue.Hide();
            DamageDesc.Hide();
            damageValue.Hide();
            staminaDesc.Hide();
            staminaValue.Hide();
            strengthDesc.Hide();
            strengthValue.Hide();
            enduranceDesc.Hide();
            enduranceValue.Hide();
            intellectDesc.Hide();
            intellectValue.Hide();
            agilityDesc.Hide();
            agilityValue.Hide();

        }
    }
}
