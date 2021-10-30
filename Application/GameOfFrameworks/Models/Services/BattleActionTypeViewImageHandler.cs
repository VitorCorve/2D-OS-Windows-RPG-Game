using GameEngine.CombatEngine.Actions;
using System;

namespace GameOfFrameworks.Models.Services
{
    public static class BattleActionTypeViewImageHandler
    {
        public static string Handle(ACTION_TYPE actionType)
        {
            switch (actionType)
            {
                case ACTION_TYPE.Dodge:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\dodge.jpg";
                case ACTION_TYPE.Block:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\block.jpg";
                case ACTION_TYPE.Parry:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\parry.jpg";
                case ACTION_TYPE.Resist:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\resist.jpg";
                case ACTION_TYPE.Death:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\devastation.jpg";
                case ACTION_TYPE.Damage:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\attack.jpg";
                case ACTION_TYPE.Buff:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\buff.jpg";
                case ACTION_TYPE.Debuff:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\debuff.jpg";
                case ACTION_TYPE.Cool_Down:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\cooldown.jpg";
                case ACTION_TYPE.Dot_Damage:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\DoT.jpg";
                case ACTION_TYPE.Out_Of_Control:
                    break;
                case ACTION_TYPE.Special_Damage:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\devastation.jpg";
                case ACTION_TYPE.Not_Enought_Energy:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\noEnergy.jpg";
                case ACTION_TYPE.Not_Enought_Mana:
                    return Environment.CurrentDirectory + "\\Data\\Images\\combatText\\noMana.jpg";
                case ACTION_TYPE.Not_Enought_Health:
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
