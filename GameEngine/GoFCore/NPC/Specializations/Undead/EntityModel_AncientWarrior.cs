﻿using GameEngine.NPC.Interfaces.SpecializationArchetypes;
using GameEngine.Player;

namespace GameEngine.NPC.Specializations.Undead
{
    public class EntityModel_AncientWarrior : IUndead
    {
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
        public int Endurance { get; set; }
        public int WeaponDamageValue { get; set; }
        public int ArmorValue { get; set; }
        public SPECIALIZATION Specialization { get; private set; }
        public NPC_NAME Name { get; private set; }
        public EntityModel_AncientWarrior()
        {
            Specialization = SPECIALIZATION.Undead;
            Name = NPC_NAME.Ancient_Warrior;

            Strength = 7;
            Stamina = 6;
            Intellect = 2;
            Agility = 3;
            Endurance = 3;
        }
    }
}