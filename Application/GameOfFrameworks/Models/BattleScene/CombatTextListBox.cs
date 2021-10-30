using System;
using System.Collections.ObjectModel;


namespace GameOfFrameworks.Models.BattleScene
{
    public class CombatTextListBox
    {
        public ObservableCollection<CombatTextMessageView> CombatTextMessagesCollection { get; set; } = new();
        public void AddMessage(string actionImageView, string message, string skillUseImageView)
        {
            CombatTextMessageView combatTextMessage = new CombatTextMessageView();

            combatTextMessage.Message = message;
            combatTextMessage.ActionImageView = actionImageView;
            combatTextMessage.SkillUseImageView = skillUseImageView;
            combatTextMessage.Time = DateTime.Now.ToString("H:mm:ss");
            CombatTextMessagesCollection.Add(combatTextMessage);
        }
    }
}
