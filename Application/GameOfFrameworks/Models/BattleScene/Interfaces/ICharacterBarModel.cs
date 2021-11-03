using GameEngine.CombatEngine.Interfaces;

namespace GameOfFrameworks.Models.BattleScene.Interfaces
{
    public interface ICharacterBarModel
    {
        string Name { get; }
        int Level { get; }
        int Health { get; }
        int Mana { get; }
        int Energy { get; }
        IConditionResourceType HP { get; }
        IConditionResourceType MP { get; }
        IConditionResourceType ENRG { get; }
        void UpdateValues();
    }
}
