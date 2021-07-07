using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Actions
{
    public interface IWeaponAttack
    {
        int DamageValue { get; }
        public void Execute(PlayerEntity player);
    }
}
