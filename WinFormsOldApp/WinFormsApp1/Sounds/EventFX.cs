using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Sounds
{
    public class EventFX
    {
        private static string EnterBattleScene = "Sound\\FX\\EnterBattleScene.wav";
        private static string EnterNewGame = "Sound\\FX\\EnterNewGame.wav";
        private static string BattleWin = "Sound\\FX\\BattleWinAlt.wav";
        private static string CombatStart = "Sound\\FX\\CombatStart.wav";
        private static string ButtonPress = "Sound\\FX\\ButtonPress.mp3";

        private static string SwordImpact1 = "Sound\\FX\\SwordImpact1.wav";
        private static string SwordImpact2 = "Sound\\FX\\SwordImpact2.wav";
        private static string SwordImpact3 = "Sound\\FX\\SwordImpact3.wav";
        private static string SwordImpact4 = "Sound\\FX\\SwordImpact4.wav";
        private static string SwordImpact5 = "Sound\\FX\\SwordImpact5.wav";
        private static string SwordImpact6 = "Sound\\FX\\SwordImpact6.wav";
        private static string SwordImpact7 = "Sound\\FX\\SwordImpact7.wav";
        private static string SwordImpact8 = "Sound\\FX\\SwordImpact8.wav";
        private static string SwordImpact9 = "Sound\\FX\\SwordImpact9.wav";
        private static string SwordCritical = "Sound\\FX\\SwordCritical.wav";

        private static string ManHit1 = "Sound\\FX\\ManHit1.wav";
        private static string ManHit2 = "Sound\\FX\\ManHit2.wav";
        private static string ManHit3 = "Sound\\FX\\ManHit3.wav";
        private static string ManHit4 = "Sound\\FX\\ManHit4.wav";
        private static string ManHit5 = "Sound\\FX\\ManHit5.wav";

        private static string WomanHit1 = "Sound\\FX\\WomanHit1.wav";
        private static string WomanHit2 = "Sound\\FX\\WomanHit2.wav";
        private static string WomanHit3 = "Sound\\FX\\WomanHit3.wav";
        private static string WomanHit4 = "Sound\\FX\\WomanHit4.wav";
        private static string WomanHit5 = "Sound\\FX\\WomanHit5.wav";
        private static string WomanHit6 = "Sound\\FX\\WomanHit6.wav";

        private static List<string> ManHitList;
        private static List<string> WomanHitList;


        private static string Dodge = "Sound\\FX\\Dodge.wav";
        private static string Parry = "Sound\\FX\\Parry.wav";
        private static string Block = "Sound\\FX\\Block.wav";

        private static List<string> SwordImpacts;


        public static void PrepareSwordAttacksList()
        {
            List<string> swordImpacts = new List<string> { };
            swordImpacts.Add(SwordImpact1);
            swordImpacts.Add(SwordImpact2);
            swordImpacts.Add(SwordImpact3);
            swordImpacts.Add(SwordImpact4);
            swordImpacts.Add(SwordImpact5);
            swordImpacts.Add(SwordImpact6);
            swordImpacts.Add(SwordImpact7);
            swordImpacts.Add(SwordImpact8);
            swordImpacts.Add(SwordImpact9);

            SwordImpacts = swordImpacts;

        }

        public static void PrepareVoiceEncounters()
        {
            List<string> manHitList = new List<string> { };
            manHitList.Add(ManHit1);
            manHitList.Add(ManHit2);
            manHitList.Add(ManHit3);
            manHitList.Add(ManHit4);
            manHitList.Add(ManHit5);

            ManHitList = manHitList;


            List<string> womanHitList = new List<string> { };
            womanHitList.Add(WomanHit1);
            womanHitList.Add(WomanHit2);
            womanHitList.Add(WomanHit3);
            womanHitList.Add(WomanHit4);
            womanHitList.Add(WomanHit5);

            WomanHitList = womanHitList;
        }

        public static int GetRandom(List<string> list)
        {
            Random rand = new Random();
            return rand.Next(0, list.Count);
        }

        public static string GetURL(string eventName)
        {
            switch (eventName)
            {
                case "EnterBattleScene":
                    return EnterBattleScene;
                case "EnterNewGame":
                    return EnterNewGame;
                case "BattleWin":
                    return BattleWin;
                case "CombatStart":
                    return CombatStart;
                case "ButtonPress":
                    return ButtonPress;
                case "Dodge":
                    return Dodge;
                case "Parry":
                    return Parry;
                case "Block":
                    return Block;
                default:
                    break;
            }

            return "";
        }

        public static string GetDefURL(string eventName)
        {
            switch (eventName)
            {
                case "Dodge":
                    return Dodge;
                case "Parry":
                    return Parry;
                case "Block":
                    return Block;
                default:
                    break;
            }

            return "";
        }

        public static string GetCombatImpactURL(string eventType)
        {
            switch (eventType)
            {
                case "CleanAttack":
                    return SwordImpacts[GetRandom(SwordImpacts)];                
                case "CleanAttackSwordCritical":
                    return SwordCritical;
                default:
                    break;
            }

            return "";
        }

        public static string VoiceEncounterURL(string gender, string kind)
        {
            if (gender == "male" && kind == "human")
            {
                Random voiceEncounter = new Random();

                return ManHitList[voiceEncounter.Next(0, ManHitList.Count-1)];
            }

            if (gender == "female" && kind == "human")
            {
                Random voiceEncounter = new Random();

                return WomanHitList[voiceEncounter.Next(0, WomanHitList.Count-1)];
            }
            else
            {
                return "";
            }
        }
    }
}
