using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Timers;

namespace WinFormsApp1.Sounds
{
    public static class SoundMaster
    {
        public static WindowsMediaPlayer SoundPlayer { get; set; }

        public static WindowsMediaPlayer EventsPlayer { get; set; }

        public static WindowsMediaPlayer CombatEventsAttackPlayer { get; set; }
        public static WindowsMediaPlayer CombatEventsDefensePlayer { get; set; }
        public static WindowsMediaPlayer HitVoiseEncounters { get; set; }

        // addManager

        public static string Scene;

        private static Timer TrackMusicStatement;

        private static Timer MuteMainST { get; set; }
        private static int MuteStage = 0;

        public static void Play()
        {
            if (Scene == "RunGame")
            {
                SoundPlayer.URL = Soundtracks.RunGameGetURL();
                SoundPlayer.controls.play();
            }

            if (Scene == "GameMenu")
            {
                SoundPlayer.URL = Soundtracks.ArmoryGetURL();
                SoundPlayer.controls.play();
            }

            if (Scene == "BattleWindow")
            {
                SoundPlayer.URL = Soundtracks.BattleGetURL();
                SoundPlayer.controls.play();
            }
        }

        public static void Play(string eventFX)
        {
            SoundPlayer.URL = EventFX.GetURL(eventFX);
            SoundPlayer.controls.play();

        }


        public static void InitializeMusicPlayer()
        {
            if (SoundPlayer == null)
            {
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                SoundPlayer = player;
                /*                Timer controlMusicStatement = new Timer(5000);
                                controlMusicStatement.Start();
                                controlMusicStatement.Elapsed += ControlMusicStatement_Elapsed;
                                TrackMusicStatement = controlMusicStatement;*/
            }
            else
            {
                return;
            }

        }

        public static void SetGeneralFXVolume(int value)
        {
            EventsPlayer.settings.volume = value;
            CombatEventsAttackPlayer.settings.volume = value;
            CombatEventsDefensePlayer.settings.volume = value;
            HitVoiseEncounters.settings.volume = value;
        }

        public static void SetGeneralSTVolume(int value)
        {
            SoundPlayer.settings.volume = value;
        }

        public static void InitializeEventsPlayer()
        {
            if (EventsPlayer == null)
            {
                WindowsMediaPlayer events = new WindowsMediaPlayer();
                EventsPlayer = events;

            }
        }

        public static void InitializeGlobalCombatEvents()
        {
            InitializeCombatEventsAttackPlayer();
            InitializeCombatEventsDefensePlayer();
            InitializeHitVoiceEncounters();
        }
        public static void InitializeCombatEventsAttackPlayer()
        {
            if (CombatEventsAttackPlayer == null)
            {
                WindowsMediaPlayer events = new WindowsMediaPlayer();
                CombatEventsAttackPlayer = events;
                EventFX.PrepareSwordAttacksList();
            }
        }

        public static void InitializeCombatEventsDefensePlayer()
        {
            if (CombatEventsDefensePlayer == null)
            {
                WindowsMediaPlayer events = new WindowsMediaPlayer();
                CombatEventsDefensePlayer = events;
            }
        }

        public static void InitializeHitVoiceEncounters()
        {
            if (HitVoiseEncounters == null)
            {
                WindowsMediaPlayer events = new WindowsMediaPlayer();
                HitVoiseEncounters = events;
                EventFX.PrepareVoiceEncounters();
            }
        }

        private static void ControlMusicStatement_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (SoundPlayer != null)
            {
                if (SoundPlayer.playState == WMPPlayState.wmppsMediaEnded)
                {
                    Play();
                }

            }
        }

        public static void PlayEvent(string eventFX)
        {
            EventsPlayer.URL = EventFX.GetURL(eventFX);
            EventsPlayer.controls.play();

/*            if (MuteMainST != null && MuteStage == 0)
            {
                Timer muteST = MuteMainST;
                EventsPlayer.URL = EventFX.GetURL(eventFX);
                EventsPlayer.controls.play();
                MuteMainST = muteST;
                SoundPlayer.settings.volume -= 20;
                muteST.Start();
                muteST.Elapsed += MuteST_Elapsed;
                MuteStage = 0;
            }

            if (MuteMainST == null && MuteStage == 0)
            {
                Timer muteST = new Timer(1000);
                EventsPlayer.URL = EventFX.GetURL(eventFX);
                EventsPlayer.controls.play();
                MuteMainST = muteST;
                SoundPlayer.settings.volume -= 20;
                muteST.Start();
                muteST.Elapsed += MuteST_Elapsed;
                MuteStage = 0;
            }*/

        }

        private static void MuteST_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (MuteStage == 2)
            {
                MuteMainST.Stop();
                SoundPlayer.settings.volume += 20;
                MuteMainST = null;
                MuteStage = 0;
            }
            MuteStage += 1;
        }

        public static void PlayCombatEvent(string eventType)
        {
            CombatEventsAttackPlayer.URL = EventFX.GetCombatImpactURL(eventType);
            CombatEventsAttackPlayer.controls.play();
        }

        public static void PlayDefenseEvent(string eventType)
        {
            CombatEventsDefensePlayer.URL = EventFX.GetDefURL(eventType);
            CombatEventsDefensePlayer.controls.play();
        }

        public static void PlayVoiceEncounter(Player player)
        {
            HitVoiseEncounters.URL = EventFX.VoiceEncounterURL(player.gender, player.Kind);
            HitVoiseEncounters.controls.play();
        }

        public static void PlayVoiceEncounter(NPC npc)
        {
            HitVoiseEncounters.URL = EventFX.VoiceEncounterURL(npc.gender, npc.Kind);
            HitVoiseEncounters.controls.play();
        }
    }
}
