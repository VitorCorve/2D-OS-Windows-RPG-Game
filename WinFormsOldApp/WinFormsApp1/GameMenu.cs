using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormsApp1.GameMenuForms;
using System.Media;

namespace WinFormsApp1
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
/*            Initialize();*/
            Opacity = 0;

            System.Windows.Forms.Timer opacity = new System.Windows.Forms.Timer();
            opacity.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 5) opacity.Stop();
            });
            opacity.Interval = 5;
            opacity.Start();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        Bitmap Background, backgroundtemp;

        public void Initialize()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            backgroundtemp = new Bitmap(Properties.Resources._new);
            Background = new Bitmap(backgroundtemp.Width, backgroundtemp.Height);
        }

/*        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            dc.DrawImageUnscaled(Background, 0, 0);
            base.OnPaint(e);
        }*/
        private void notesButton_Click(object sender, EventArgs e)
        {


        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            DialogResult mainMenu = MessageBox.Show("Back to main menu?", "Game", MessageBoxButtons.YesNo);

            if (mainMenu == DialogResult.Yes)
            {
                Data.SetPlayer(null);
                this.Hide();
                var runGame = new RunGame();
                runGame.Show();
            }
            else
            {
                return;
            }

            
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {

            CleanFormsCache();
            InitializeCharacter();
            InitializeViewPanel();
            Sounds.SoundMaster.Scene = "GameMenu";
            Sounds.SoundMaster.Play();

        }

        private void InitializeCharacter()
        {
            Player player = (Player)Data.GetPlayer();
            characterImage.Image = Image.FromFile(player.AvatarPath);
            levelLabel.Text = "Level: " + Convert.ToString(player.level);
            nameLabel.Text = player.name;
            healthPointsLabel.Text = "HP: " + Convert.ToString(player.healthpoints);
            manaPointsLabel.Text = "MP: " + Convert.ToString(player.mana);
            energyPointsLabel.Text = "EP: " + Convert.ToString(player.energy);
            InitializeEXP();
            player.ScaleStaticStats();
        }

        private void InitializeEXP()
        {
            Player player = (Player)Data.GetPlayer();
            double xpMult = player.maxExperience/ 10;
            double xpBarsCount = Convert.ToDouble(player.experience) / xpMult;

            string[] bars = new string[10];

            for (int i = 0; i < 10; i++)
            {
                bars[i] = "images\\textures\\xpBarEmptyIcon.png";
            }
            for (int i = 0; i < xpBarsCount; i++)
            {
                bars[i] = "images\\textures\\xpBarFilledIcon.png";
            }

            xp1.Image = Image.FromFile(bars[0]);
            xp2.Image = Image.FromFile(bars[1]);
            xp3.Image = Image.FromFile(bars[2]);
            xp4.Image = Image.FromFile(bars[3]);
            xp5.Image = Image.FromFile(bars[4]);
            xp6.Image = Image.FromFile(bars[5]);
            xp7.Image = Image.FromFile(bars[6]);
            xp8.Image = Image.FromFile(bars[7]);
            xp9.Image = Image.FromFile(bars[8]);
            xp10.Image = Image.FromFile(bars[9]);
        }

        private void InitializeViewPanel()
        {
            viewPanel.Controls.Clear();
            var equipment = new Equipment();
            equipment.TopLevel = false;
            viewPanel.Controls.Add(equipment);
            equipment.Show();
        }

        private void equipmentButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            viewPanel.Controls.Clear();
            var equipment = new Equipment();
            equipment.TopLevel = false;
            viewPanel.Controls.Add(equipment);
            equipment.Show();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            viewPanel.Controls.Clear();
            var inventory = new Inventory();
            inventory.TopLevel = false;
            viewPanel.Controls.Add(inventory);
            inventory.Show();
        }

        private void huntButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");

            this.Hide();
            var battleWindow = new BattleWindow();
            battleWindow.Show();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            this.Hide();
            var optionsMenu = new GameMenuOptions();
            optionsMenu.Show();
            /*viewPanel.Controls.Clear();
            var optionsMenu = new GameMenuOptions();
            optionsMenu.TopLevel = false;
            viewPanel.Controls.Add(optionsMenu);
            optionsMenu.Show();*/
        }
        private void CleanFormsCache()
        {
            for (int i = Application.OpenForms.Count; i > 1; i--)
            {
                if (Application.OpenForms.Count < 4)
                {
                    return;
                }
                if (Application.OpenForms.Count > 2)
                {
                    return;
                }
                else
                {
                    Application.OpenForms[i - 1].Close();
                }

            }

            /*if (Application.OpenForms.Count > 5)
                {
                for (int i = Application.OpenForms.Count; i > 5; i--)
                {
                Application.OpenForms[i - 1].Close();
                }
                }

                Application.OpenForms[0].Show();*/

        }
        private void GameMenu_Activated(object sender, EventArgs e)
        {

        }

        private void GameMenu_Deactivate(object sender, EventArgs e)
        {
            
        }

        private void GameMenu_Click(object sender, EventArgs e)
        {

        }

        private void GameMenu_Enter(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        private void GameMenu_Leave(object sender, EventArgs e)
        {
            this.Enabled = false;
        }

        private void GameMenu_ParentChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Parent Changed");
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            viewPanel.Controls.Clear();
            var attributes = new Attributes();
            attributes.TopLevel = false;
            viewPanel.Controls.Add(attributes);
            attributes.Show();
        }
    }
}
