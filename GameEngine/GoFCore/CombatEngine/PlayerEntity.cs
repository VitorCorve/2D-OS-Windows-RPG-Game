using System;
using GameEngine.Player.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.EquipmentManagement;

namespace GameEngine.CombatEngine
{
    public class PlayerEntity
    {
        public uint HealthPoints { get; set; }
        public uint ManaPoints { get; set; }
        public uint EnergyPoints { get; set; }

        public uint AttackPower { get; set; }
        public uint ArmorPoints { get; set; }

        public double CriticalHitChance { get; set; }
        public double DodgeChance { get; set; }
        public double BlockChance { get; set; }
        public double ParryChange { get; set; }
        public double ResistChance { get; set; }

    }
}
