using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine
{
    public class DefenseService : IDefense
    {
        public delegate void Notifications(string message);

        public double BlockChance { get; private set; }

        public double DodgeChance { get; private set; }

        public double ParryChance { get; private set; }

        public double ResistChance { get; private set; }

        public DefenseService(PlayerEntity player)
        {
            BlockChance = player.BlockChance;
            DodgeChance = player.DodgeChance;
            ParryChance = player.ParryChange;
            ResistChance = player.ResistChance;
        }

        public bool DefenseCheck(ISkill skill)
        {
            switch (skill.Type)
            {
                case Melee:
                    return
                        Chance() > BlockChance &&
                        Chance() > DodgeChance &&
                        Chance() > ParryChance;
                case Magic:
                    return
                        Chance() > ResistChance;
                default:
                    break;
            }
            return false;
        }

        public double Chance()
        {
            var random = new Random();
            double randomValue = random.Next(0, 100);
            return randomValue;
        }

    }
}
