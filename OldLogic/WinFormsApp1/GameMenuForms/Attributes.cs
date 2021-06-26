using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.GameMenuForms
{
    public partial class Attributes : Form
    {
        public Attributes()
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

        private void Attributes_Load(object sender, EventArgs e)
        {
            GetStats();
        }

        private void GetStats()
        {
            Player player = (Player)Data.GetPlayer();

            player.ScaleStaticStats();

            healthValue.Text = Convert.ToString(player.healthpoints);
            manaValue.Text = Convert.ToString(player.mana);
            energyValue.Text = Convert.ToString(player.energy);

            hpRegenValue.Text = Convert.ToString(player.healthRegen) + " hp/s.";
            mpRegenValue.Text = Convert.ToString(player.manaRegen) + " mp/s.";
            energyRegenValue.Text = Convert.ToString(player.energyRegen + " en/s.");

            staminaValue.Text = Convert.ToString(player.stamina);
            strengthValue.Text = Convert.ToString(player.strength);
            enduranceValue.Text = Convert.ToString(player.endurance);
            intellectValue.Text = Convert.ToString(player.intellect);
            agilityValue.Text = Convert.ToString(player.agility);

            attackPowerValue.Text = Convert.ToString(player.attackPower);
            attackSpeedValue.Text = Convert.ToString(player.attackSpeed);
            criticalHitChanceValue.Text = Convert.ToString(player.CriticalChance) + " %";

            armorValue.Text = Convert.ToString(player.Armor);
            dodgeChanceValue.Text = Convert.ToString(player.DodgeChance) + " %";
            blockChanceValue.Text = Convert.ToString(player.BlockChance) + " %";
            parryChanceValue.Text = Convert.ToString(player.ParryChance) + " %";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
/*            this.Hide();
            var gameMenu = new GameMenu();
            gameMenu.Show();*/
        }
    }
}
