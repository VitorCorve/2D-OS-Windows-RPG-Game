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
using WinFormsApp1.EquipmentData.Items;
using System.IO;

namespace WinFormsApp1.BattleWindowForms
{
    public partial class LootMenu : Form
    {
        public LootMenu()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LootMenu_Load(object sender, EventArgs e)
        {
            Random itemReward = new Random();
            int rewardID = itemReward.Next(1, ArmoryData.Armory.Count);
            EquipmentValue.Add(rewardID);
            EquipmentValue.InitializeValues();

            EquipmentBaseClass item = ArmoryData.GetItemByID(rewardID);
            rewardImage.Image = Image.FromFile(item.ImageUrl);

            rewardTitleLabel.Text = item.Name;
        }

        private void rewardImage_MouseHover(object sender, EventArgs e)
        {

        }

        private void rewardImage_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
