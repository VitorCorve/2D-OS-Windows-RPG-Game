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
    public partial class GameMenuOptions : Form
    {
        public GameMenuOptions()
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



        private void quitButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            DialogResult exitGame = MessageBox.Show("Unsaved progress will be lost. Exit the game?", "Game", MessageBoxButtons.YesNo);

            if (exitGame == DialogResult.Yes)
            {
                Form forms = Application.OpenForms[0];

                for (int i = Application.OpenForms.Count; i > -1; i--)
                {
                    forms.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            Player player = (Player)Data.GetPlayer();
            player.SaveData();
            MessageBox.Show("Game saved");
            resumeButton.PerformClick();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            DialogResult mainMenu = MessageBox.Show("Unsaved progress will be lost. Go to Main menu?", "Game", MessageBoxButtons.YesNo);

            if (mainMenu == DialogResult.Yes)
            {
                this.Hide();


                for (int i = Application.OpenForms.Count; i > 3; i--)
                {
                    Application.OpenForms[i - 1].Close();
                }

                Data.SetPlayer(null);

                var runGame = new RunGame();
                runGame.Show();

                MessageBox.Show(Application.OpenForms.Count.ToString());
            }
            else
            {
                return;
            }
        }

        private void GameMenuOptions_Load(object sender, EventArgs e)
        {
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            this.Hide();
            /*            for (int i = Application.OpenForms.Count; i > 1; i--)
                        {
                            if (Application.OpenForms.Count == 1)
                            {
                                return;
                            }
                            else
                            {
                                Application.OpenForms[i - 1].Close();
                            }

                        }*/
            var gameMenu = new GameMenu();
            gameMenu.Show();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            this.Hide();
            var loadGameMenuMenu = new GameMenuLoad();
            loadGameMenuMenu.Show();
        }
    }
}
