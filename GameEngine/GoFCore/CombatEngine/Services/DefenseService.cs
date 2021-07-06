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
        public event Notifications Log;

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
                        TryMeleeDefense();
                case Magic:
                    return
                        TryMagicDefense();
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

        private bool TryMeleeDefense()
        {
            if (Chance() < BlockChance)
            {
                //Log("Attack blocked.");
                return false;
            }
                

            if (Chance() < DodgeChance)
            {
                //Log("Attack dodged.");
                return false;
            }
                

            if (Chance() < ParryChance)
            {
                //Log("Attack parried.");
                return false;
            }
            return true;
        }

        private bool TryMagicDefense()
        {
            if (Chance() < ResistChance)
            {
                //Log("Magic resisted.");
                return false;
            }
            return true;
        }
    }
}
