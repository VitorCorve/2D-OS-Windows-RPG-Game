using System;
using System.Windows;
using System.Windows.Media;

namespace GameOfFrameworks.Models.Services
{
    public class SoundMaster
    {
        private delegate void Function();
        private double _FXVolume;
        private double _SoundTrackVolume;
        public double FXVolume { get => _FXVolume; set { _FXVolume = value; } }
        public double SoundTrackVolume { get => _SoundTrackVolume; set { _SoundTrackVolume = value; } }
        private MediaPlayer FX;
        private MediaPlayer CombatFX;
        private MediaPlayer RunGameSoundtrack;
        private MediaPlayer ArmorySoundtrack;
        private MediaPlayer BattleSceneSoundtrack;
        public SoundMaster()
        {
            FX = new MediaPlayer();
            CombatFX = new MediaPlayer();
            RunGameSoundtrack = new MediaPlayer();
            ArmorySoundtrack = new MediaPlayer();
            BattleSceneSoundtrack = new MediaPlayer();
            RunGameSoundtrack.MediaEnded += PlayRandomizedRunGameSoundtrack;
            ArmorySoundtrack.MediaEnded += PlayRandomizedArmorySoundtrack;
            BattleSceneSoundtrack.MediaEnded += PlayRandomizedBattleSceneSoundtrack;

            SetSoundtrackVolume(0.2);
        }
        public void PlayCustomFXEvent(string uri)
        {
            FX.Open(new Uri(uri));
            FX.Play();
        }
        public void ButtonPressSoundPlay()
        {
            FX.Open(new Uri(Environment.CurrentDirectory + "\\Data\\Sound\\FX\\ButtonPress.mp3"));
            FX.Play();
        }
        public void SceneBackgroundSoundTrackPlay(SCENE scene)
        {
            MuteAllBackgroundSoundtracks();

            switch (scene)
            {
                case SCENE.RunGame:
                   PlayRandomizedRunGameSoundtrack(null, null);
                    return;
                case SCENE.Armory:
                    PlayRandomizedArmorySoundtrack(null, null);
                    return;
                case SCENE.BattleScene:
                    PlayRandomizedBattleSceneSoundtrack(null, null);
                    return;
                default:
                    break;
            }
        }
        private void Action(Function func = null)
        {
            Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background,
                new Action(() =>
                {
                    func?.Invoke();
                }));
        }
        private void PlayRandomizedRunGameSoundtrack(object sender, EventArgs e)
        {
            var rand = new Random();
            int result = rand.Next(1, 3);
            RunGameSoundtrack.Open(new Uri(Environment.CurrentDirectory + $"\\Data\\Sound\\Soundtrack{result}.mp3"));
            RunGameSoundtrack.Play();
        }
        private void PlayRandomizedArmorySoundtrack(object sender, EventArgs e)
        {
            var rand = new Random();
            int result = rand.Next(1, 5);
            ArmorySoundtrack.Open(new Uri(Environment.CurrentDirectory + $"\\Data\\Sound\\ArmoryST{result}.mp3"));
            ArmorySoundtrack.Play();
        }
        private void PlayRandomizedBattleSceneSoundtrack(object sender, EventArgs e)
        {
            var rand = new Random();
            int result = rand.Next(1, 5);
            BattleSceneSoundtrack.Open(new Uri(Environment.CurrentDirectory + $"\\Data\\Sound\\BattleST{result}.mp3"));
            BattleSceneSoundtrack.Play();
        }
        private void MuteAllBackgroundSoundtracks()
        {
            RunGameSoundtrack.Stop();
            ArmorySoundtrack.Stop();
            BattleSceneSoundtrack.Stop();
        }
        public void PlayEvent(string URI, double balance)
        {
            CombatFX.Open(new Uri(URI));
            CombatFX.Balance = balance;
            CombatFX.Play();
        }
        public void SetSoundtrackVolume(double value)
        {
            RunGameSoundtrack.Volume = value;
            ArmorySoundtrack.Volume = value;
            BattleSceneSoundtrack.Volume = value;
        }
        public void SetFXVolume(double value)
        {
            CombatFX.Volume = value;
            FX.Volume = value;
        }
    }
}
