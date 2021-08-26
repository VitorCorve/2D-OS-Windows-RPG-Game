using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player.DefenseResources;
using System;


namespace GameEngine.CombatEngine
{
    public class DefenseService : IDefenseService
    {
        public delegate void NotifyMaster(string message);
        public event NotifyMaster Log;
        public Block BlockChance { get; private set; }
        public Dodge DodgeChance { get; private set; } = new Dodge();
        public Parry ParryChance { get; private set; }
        public Resist ResistChance { get; private set; }
        public DefenseService(PlayerEntity player)
        {
            BlockChance = player.BlockChance;
            DodgeChance = player.DodgeChance;
            ParryChance = player.ParryChance;
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
            double chance = Chance();

            if (chance < BlockChance.Value)
            {
                Log("blocked attack");
                return false;
            }
                

            if (chance < DodgeChance.Value)
            {
                Log("dodged attack");
                return false;
            }
                

            if (chance < ParryChance.Value)
            {
                Log("parried attack");
                return false;
            }
            return true;
        }

        private bool TryMagicDefense()
        {
            if (Chance() < ResistChance.Value)
            {
                Log("resisted attack");
                return false;
            }
            return true;
        }
    }
}
