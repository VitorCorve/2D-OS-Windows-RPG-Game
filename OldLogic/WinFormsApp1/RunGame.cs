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
    public partial class RunGame : Form
    {
        public RunGame()
        {
            InitializeComponent();
            Opacity = 0;

            System.Windows.Forms.Timer opacity = new System.Windows.Forms.Timer();
            opacity.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) opacity.Stop();
            });
            opacity.Interval = 10;
            opacity.Start();
        }

        private void RunGame_Load(object sender, EventArgs e)
        {
            CleanFormsCache();
            Sounds.SoundMaster.InitializeMusicPlayer();
            Sounds.SoundMaster.InitializeEventsPlayer();
            Sounds.SoundMaster.Scene = "RunGame";
            Sounds.SoundMaster.Play();


            Sounds.SoundMaster.SetGeneralSTVolume(5);


        }

        private void CleanFormsCache()
        {
            if (Application.OpenForms.Count > 5)
            {
                for (int i = Application.OpenForms.Count; i > 5; i--)
                {
                    Application.OpenForms[i-1].Close();
                }
            }

            Application.OpenForms[Application.OpenForms.Count-1].Show();
        }

        private bool CheckActive(CharacterCreation charCreation)
        {

            if (charCreation != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private void exitGameButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            DialogResult exitGame = MessageBox.Show("Exit game?", "Game", MessageBoxButtons.YesNo);

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

        private void newGameButton_Click(object sender, EventArgs e)
        {

            Sounds.SoundMaster.PlayEvent("EnterNewGame");
            var characterCreation = new CharacterCreation();
            this.Hide();
            characterCreation.Show();

        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.PlayEvent("ButtonPress");
            var characterLoading = new CharacterLoading();
            this.Hide();
            characterLoading.Show();
        }
    }
}
