using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;

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
        public void AddMessage(CombatTextMessageView message)
        {
            string text = message.Message.Replace("_", "");
            message.Message = text;
            CombatTextMessagesCollection.Add(message);
        }
        public async void AddMessage(CombatTextMessageView message, bool delayed, int value)
        {
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(value);

                Application.Current.Dispatcher.BeginInvoke(
                System.Windows.Threading.DispatcherPriority.Background,
                new Action(() =>
                {
                    CombatTextMessagesCollection.Add(message);
                }));
            });
        }
    }
}
