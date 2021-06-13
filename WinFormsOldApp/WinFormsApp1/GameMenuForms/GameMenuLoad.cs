using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.GameMenuForms
{
    public partial class GameMenuLoad : Form
    {
        public GameMenuLoad()
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

        private void GameMenuLoad_Load(object sender, EventArgs e)
        {
            InitializeSaves();
        }

        private void InitializeSaves()
        {
            string[] characters = Directory.GetDirectories("saves\\player\\");

            if (characters.Length < 1)
            {
                loadButton.Enabled = false;

                return;
            }
            else
            {
                for (int i = 0; i < characters.Length; i++)
                {
                    charsList.Items.Add(characters[i].Replace("saves\\player\\", ""));

                    charsList.SelectedIndex = 0;

                    GetPlayerData();
                    Player player = (Player)Data.GetPlayer();
                    saveDateText.Text = player.SaveTime;
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            this.Hide();
            var gameMenuOptions = new GameMenuOptions();
            gameMenuOptions.Show();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            DialogResult loadCharacter = MessageBox.Show("Are you sure? Unsaved progress will be lost", "Game", MessageBoxButtons.YesNo);

            if (loadCharacter == DialogResult.Yes)
            {
                GetPlayerData();
                this.Hide();
                var gameMenu = new GameMenu();
                gameMenu.Show();
            }
            
        }

        private void GetPlayerData()
        {
            Player player = new Player();
            player.LoadData(charsList.SelectedItem.ToString());
            Data.SetPlayer(player);
        }

        private void charsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = new Player();
            player.LoadData(charsList.SelectedItem.ToString());
            Data.SetPlayer(player);
            saveDateText.Text = player.SaveTime;
        }
    }
}
