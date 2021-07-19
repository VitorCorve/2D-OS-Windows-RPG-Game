using GameEngine.CombatEngine.Services;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.DefenseResources;
using GameEngine.Player.Specializatons.Mage;
using GameEngine.SpecializationMechanics.UniversalSkills;

namespace GameEngine.CombatEngine
{
    public class PlayerEntityConstructor
    {
        public object RecoverResources { get; private set; }

        public PlayerEntity CreatePlayer(PlayerModelData modelData, IEntityAttributes specializationAttributes, IEntityAttributes equipmentValues)
        {
            var playerEntity = new PlayerEntity
            {
                HealthPoints    = new Health((specializationAttributes.Stamina          + equipmentValues.Stamina)   * 10),
                ManaPoints      = new Mana((specializationAttributes.Intellect          + equipmentValues.Intellect) * 10),
                EnergyPoints    = new Energy((specializationAttributes.Agility          + equipmentValues.Agility)   * 10),
                ArmorPoints     = new Armor(equipmentValues.ArmorValue),
                DodgeChance     = new Dodge(((specializationAttributes.Agility          + equipmentValues.Agility)   / 2)   + modelData.Level),
                ParryChance     = new Parry(((specializationAttributes.Agility          + equipmentValues.Agility)   / 2.2) + modelData.Level),
                BlockChance     = new Block(((specializationAttributes.Agility          + equipmentValues.Agility)   / 1.8) + modelData.Level),
                ResistChance    = new Resist((specializationAttributes.Intellect / 2)   + modelData.Level),
            };

            switch (specializationAttributes)
            {
                case EntityModel_Mage:
                    playerEntity.CriticalChance =   new CriticalHitChance(specializationAttributes.Intellect + modelData.Level);
                    playerEntity.Attack =           new AttackPower((specializationAttributes.Intellect + equipmentValues.Intellect * 10) + equipmentValues.WeaponDamageValue);
                    break;
                default:
                    playerEntity.CriticalChance =   new CriticalHitChance(specializationAttributes.Agility + modelData.Level);
                    playerEntity.Attack =           new AttackPower((specializationAttributes.Strength + equipmentValues.Strength * 10) + equipmentValues.WeaponDamageValue);
                    break;
            }

            var playerRecovery = new RecoveryService(playerEntity.HealthPoints, playerEntity.ManaPoints, playerEntity.EnergyPoints);

            playerEntity.RecoverResources = playerRecovery;

            return playerEntity;
        }
    }
}
