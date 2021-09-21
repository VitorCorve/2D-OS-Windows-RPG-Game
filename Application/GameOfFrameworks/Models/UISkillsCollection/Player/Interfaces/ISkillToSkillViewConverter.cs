using GameEngine.CombatEngine.Interfaces;


namespace GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces
{
    public interface ISkillToSkillViewConverter
    {
        ISkillView Convert(ISkill skill);
    }
}
