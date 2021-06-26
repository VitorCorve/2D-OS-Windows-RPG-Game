using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Sounds
{
    public static class Soundtracks
    {

        private static string MenuSoundtrack1 = "Sound\\Soundtrack1.mp3";
        private static string MenuSoundtrack2 = "Sound\\Soundtrack2.mp3";
        private static string MenuSoundtrack3 = "Sound\\Soundtrack3.mp3";

        private static string ArmoryST1 = "Sound\\ArmoryST1.mp3";
        private static string ArmoryST2 = "Sound\\ArmoryST2.mp3";
        private static string ArmoryST3 = "Sound\\ArmoryST3.mp3";
        private static string ArmoryST4 = "Sound\\ArmoryST4.mp3";
        private static string ArmoryST5 = "Sound\\ArmoryST5.mp3";

        private static string BattleST1 = "Sound\\BattleST1.mp3";
        private static string BattleST2 = "Sound\\BattleST2.mp3";
        private static string BattleST3 = "Sound\\BattleST3.mp3";
        private static string BattleST4 = "Sound\\BattleST4.mp3";
        private static string BattleST5 = "Sound\\BattleST5.mp3";


        public static string RunGameGetURL()
        {
            List<String> menuSound = new List<string> { };

            menuSound.Add(MenuSoundtrack1);
            menuSound.Add(MenuSoundtrack2);
            menuSound.Add(MenuSoundtrack3);


            Random rand = new Random();

            return menuSound[rand.Next(0, 2)];
        }

        public static string ArmoryGetURL()
        {
            List<String> armorySound = new List<string> { };

            armorySound.Add(ArmoryST1);
            armorySound.Add(ArmoryST2);
            armorySound.Add(ArmoryST3);
            armorySound.Add(ArmoryST4);
            armorySound.Add(ArmoryST5);


            Random rand = new Random();

            return armorySound[rand.Next(0, 4)];
        }

        public static string BattleGetURL()
        {
            List<String> battleSound = new List<string> { };

            battleSound.Add(BattleST1);
            battleSound.Add(BattleST2);
            battleSound.Add(BattleST3);
            battleSound.Add(BattleST4);
            battleSound.Add(BattleST5);


            Random rand = new Random();

            return battleSound[rand.Next(0, 4)];
        }
    }
}
