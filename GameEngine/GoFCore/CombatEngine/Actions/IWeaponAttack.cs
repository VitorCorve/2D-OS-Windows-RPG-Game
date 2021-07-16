using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player.ConditionResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Actions
{
    public interface IWeaponAttack
    {
        AttackPower DamageValue { get; }
        public void Execute(PlayerEntity player);
    }
}
