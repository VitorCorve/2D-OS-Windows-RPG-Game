using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class upgradeAgility : Form
    {

        public static int chooseEndurance;
        public static int chooseStamina;
        public static int chooseStrength;
        public static int chooseIntellect;
        public static int chooseAgility;
        public bool ConfirmReady;

        public upgradeAgility()
        {
            InitializeComponent();
        }

        private void LevelUpMenu_Load(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            levelValue.Text = Convert.ToString(player.GetLevel());
            InitializeAttributes();
        }

        private void LevelUpMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var BattleWindow = new BattleWindow();
            BattleWindow.Show();
            
        }

        public void InitializeAttributes()
        {
            Player player = (Player)Data.GetPlayer();
            playerEndurance.Text = Convert.ToString(player.baseEndurance);
            playerStamina.Text = Convert.ToString(player.baseStamina);
            playerStrength.Text = Convert.ToString(player.baseStrength);
            playerIntellect.Text = Convert.ToString(player.baseIntellect);
            playerAgility.Text = Convert.ToString(player.baseAgility);
        }

        private void upgradeEndurance_Click(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            playerEndurance.Text = $"{Convert.ToString(player.baseEndurance+1)}";
            playerStamina.Text = Convert.ToString(player.baseStamina);
            playerStrength.Text = Convert.ToString(player.baseStrength);
            playerIntellect.Text = Convert.ToString(player.baseIntellect);
            playerAgility.Text = Convert.ToString(player.baseAgility);
            playerEndurance.Enabled = false;
            playerStamina.Enabled = true;
            playerStrength.Enabled = true;
            playerIntellect.Enabled = true;
            playerAgility.Enabled = true;
            chooseEndurance = 1;
            chooseStamina = 0;
            chooseStrength = 0;
            chooseIntellect = 0;
            chooseAgility = 0;

            ConfirmReady = true;
    }

        private void upgradeStamina_Click(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            playerStamina.Text = $"{Convert.ToString(player.baseStamina + 1)}";
            playerEndurance.Text = Convert.ToString(player.baseEndurance);
            playerStrength.Text = Convert.ToString(player.baseStrength);
            playerIntellect.Text = Convert.ToString(player.baseIntellect);
            playerAgility.Text = Convert.ToString(player.baseAgility);
            playerEndurance.Enabled = true;
            playerStamina.Enabled = false;
            playerStrength.Enabled = true;
            playerIntellect.Enabled = true;
            playerAgility.Enabled = true;
            chooseEndurance = 0;
            chooseStamina = 1;
            chooseStrength = 0;
            chooseIntellect = 0;
            chooseAgility = 0;

            ConfirmReady = true;
        }

        private void upgradeStrength_Click(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            playerStrength.Text = $"{Convert.ToString(player.baseStrength + 1)}";
            playerEndurance.Text = Convert.ToString(player.baseEndurance);
            playerStamina.Text = Convert.ToString(player.baseStamina);
            playerIntellect.Text = Convert.ToString(player.baseIntellect);
            playerAgility.Text = Convert.ToString(player.baseAgility);
            playerEndurance.Enabled = true;
            playerStamina.Enabled = true;
            playerStrength.Enabled = false;
            playerIntellect.Enabled = true;
            playerAgility.Enabled = true;
            chooseEndurance = 0;
            chooseStamina = 0;
            chooseStrength = 1;
            chooseIntellect = 0;
            chooseAgility = 0;

            ConfirmReady = true;
        }

        private void upgradeIntellect_Click(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            playerIntellect.Text = $"{Convert.ToString(player.baseIntellect + 1)}";
            playerEndurance.Text = Convert.ToString(player.baseEndurance);
            playerStrength.Text = Convert.ToString(player.baseStrength);
            playerStamina.Text = Convert.ToString(player.baseStamina);
            playerAgility.Text = Convert.ToString(player.baseAgility);
            playerEndurance.Enabled = true;
            playerStamina.Enabled = true;
            playerStrength.Enabled = true;
            playerIntellect.Enabled = false;
            playerAgility.Enabled = true;
            chooseEndurance = 0;
            chooseStamina = 0;
            chooseStrength = 0;
            chooseIntellect = 1;
            chooseAgility = 0;

            ConfirmReady = true;
        }

        private void upgradeAg_Click(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            playerAgility.Text = $"{Convert.ToString(player.baseAgility + 1)}";
            playerEndurance.Text = Convert.ToString(player.baseEndurance);
            playerStrength.Text = Convert.ToString(player.baseStrength);
            playerIntellect.Text = Convert.ToString(player.baseIntellect);
            playerStamina.Text = Convert.ToString(player.baseStamina);
            playerEndurance.Enabled = true;
            playerStamina.Enabled = true;
            playerStrength.Enabled = true;
            playerIntellect.Enabled = true;
            playerAgility.Enabled = false;
            chooseEndurance = 0;
            chooseStamina = 0;
            chooseStrength = 0;
            chooseIntellect = 0;
            chooseAgility = 1;

            ConfirmReady = true;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!ConfirmReady)
            {
                MessageBox.Show("Choose attributes tu upgrade");
            }

            if (ConfirmReady)
            {
                Player player = (Player)Data.GetPlayer();
                player.baseStamina += chooseStamina;
                player.baseAgility += chooseAgility;
                player.baseStrength += chooseStrength;
                player.baseEndurance += chooseEndurance;
                player.baseIntellect += chooseIntellect;
                player.RefreshStats();

                Data.SetPlayer(player);
                this.Close();
            }

        }
    }
}
