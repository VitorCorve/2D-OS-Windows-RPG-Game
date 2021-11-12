using GameEngine.CombatEngine.Actions;
using GameOfFrameworks.Models.Temporary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfFrameworks.Models.BattleScene.Services
{
    public class BattleSceneSoundHandler
    {
        public static void Handle(ACTION_TYPE actionType, SERVICE_OWNER owner)
        {
            string uri = null;

            switch (actionType)
            {
                case ACTION_TYPE.Dodge:
                    uri = Environment.CurrentDirectory + $"\\Data\\Sound\\FX\\Dodge.wav";
                    Execute(uri, owner);
                    return;
                case ACTION_TYPE.Block:
                    uri = Environment.CurrentDirectory + $"\\Data\\Sound\\FX\\Block.wav";
                    Execute(uri, owner);
                    return;
                case ACTION_TYPE.Parry:
                    uri = Environment.CurrentDirectory + $"\\Data\\Sound\\FX\\Parry.wav";
                    Execute(uri, owner);
                    return;
                case ACTION_TYPE.Resist:
                    return;
                case ACTION_TYPE.Death:
                    return;
                case ACTION_TYPE.Damage:
                    Execute(actionType);
                    return;
                case ACTION_TYPE.Buff:
                    return;
                case ACTION_TYPE.Debuff:
                    return;
                case ACTION_TYPE.Critical:
                    return;
                case ACTION_TYPE.Cool_Down:
                    return;
                case ACTION_TYPE.Dot_Damage:
                    return;
                case ACTION_TYPE.Experience:
                    return;
                case ACTION_TYPE.LevelUp:
                    return;
                case ACTION_TYPE.Out_Of_Control:
                    return;
                case ACTION_TYPE.Special_Damage:
                    return;
                case ACTION_TYPE.Not_Enought_Energy:
                    return;
                case ACTION_TYPE.Not_Enought_Mana:
                    return;
                case ACTION_TYPE.Not_Enought_Health:
                    return;
                default:
                    return;
            }
        }
        private static void Execute(string uri, SERVICE_OWNER owner)
        {
            ApplicationTemporaryData.Sound.PlayEvent(uri);
        }
        private static void Execute(ACTION_TYPE actionType)
        {
            var rand = new Random();
            int result = rand.Next(1, 8);
            ApplicationTemporaryData.Sound.PlayEvent(Environment.CurrentDirectory + $"\\Data\\Sound\\FX\\SwordImpact{result}.wav"); 
        }
    }
}
