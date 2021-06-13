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
using System.Threading;

namespace WinFormsApp1
{
    public partial class CharacterLoading : Form
    {
        public string DeletedCharacterName { get; set; }
        public CharacterLoading()
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
        private void CharacterLoading_Load(object sender, EventArgs e)
        {
            InitializeCharactersListBox();
            
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");

            for (int i = Application.OpenForms.Count; i > 4; i--)
            {
                    Application.OpenForms[i - 1].Close();
            }
            var run = new RunGame();
            run.Show();
            this.Hide();
            Data.SetPlayer(null);
        }

        private void InitializeCharactersListBox()
        {

            string[] characters = Directory.GetDirectories("saves\\player\\");

            if (characters.Length < 1)
            {
                loadButton.Enabled = false;
                deleteButton.Enabled = false;
                return;
            }
            else 
            {
                for (int i = 0; i < characters.Length; i++)
                {
                    charListBox.Items.Add(characters[i].Replace("saves\\player\\", ""));

                    charListBox.SelectedIndex = 0;
                }
            }


        }

        private void charListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            if (charListBox.Items.Count < 1)
            {

                characterImage.Image = null;

                saveDateText.Text = null;
                classText.Text = null;

                bioText.Text = null;

                levelText.Text = null;
                healthText.Text = null;
                manaText.Text = null;
                energyText.Text = null;

                goldText.Text = null;
                silverText.Text = null;
                copperText.Text = null;

                enemiesKilledLabel.Text = null;
                epicItemsLabel.Text = null;
                daysPlayedLabel.Text = null;

                return;
            }

            try
            {
                if (charListBox.SelectedItem == null)
                {
                    charListBox.SelectedIndex += 1;
                }


                Player player = new Player();
                player.LoadData(charListBox.SelectedItem.ToString());
                Data.SetPlayer(player);
                InitializeCharacter();
            }
            catch (Exception)
            {

                MessageBox.Show("Corrupted savegame");
            }

            if (DeletedCharacterName != null)
            {
                    CleanCharData();
            }

        }

        private void InitializeCharacter()
        {
            Player player = (Player)Data.GetPlayer();

            player.ScaleStaticStats();

            characterImage.Image = player.Avatar;

            saveDateText.Text = player.SaveTime;
            classText.Text = char.ToUpper(player.Specialization[0]) + player.Specialization.Substring(1);

            bioText.Text = player.Bio;

            levelText.Text = Convert.ToString(player.level);
            healthText.Text = Convert.ToString(player.healthpoints);
            manaText.Text = Convert.ToString(player.mana);
            energyText.Text = Convert.ToString(player.energy);

            goldText.Text = Convert.ToString(player.gold);
            silverText.Text = Convert.ToString(player.silver);
            copperText.Text = Convert.ToString(player.copper);

            enemiesKilledLabel.Text = $"Enemies killed: {player.EnemiesKilled}";
            epicItemsLabel.Text = $"Epic items: {player.EpicItems}";
            daysPlayedLabel.Text = $"Epic items: {player.DaysPlayed}";

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");

            Player player = (Player)Data.GetPlayer();
            DialogResult dialogResult = MessageBox.Show("Delete save?", $"{player.name} Date: {player.SaveTime}", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                player.Avatar.Dispose();
                DeleteCharacter();
            }
            else
            {
                return;
            }


        }

        public void DeleteCharacter()
        {
            Player player = (Player)Data.GetPlayer();

            DeletedCharacterName = player.name;
 
            charListBox.Items.Remove(charListBox.SelectedItem);

            CleanCharData();

        }

        private void CleanCharData()
        {
            try
            {
                Directory.Delete($"saves\\player\\{DeletedCharacterName}", true);
            }
            catch (Exception)
            {

                
            }
            
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            Player player = (Player)Data.GetPlayer();
            DialogResult loadGame = MessageBox.Show($"Load {player.name}game save?", "game", MessageBoxButtons.YesNo);

            if (loadGame == DialogResult.Yes)
            {
                player.LoadData(player.name);
                this.Hide();
                var gameMenu = new GameMenu();
                gameMenu.Show();
            }
            else
            {
                return;
            }
            

        }
    }
}

