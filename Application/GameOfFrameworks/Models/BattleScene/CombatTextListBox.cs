using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace GameOfFrameworks.Models.BattleScene
{
    public class CombatTextListBox
    {
        public ObservableCollection<string> Text { get; set; } = new();
        public ObservableCollection<string> Time { get; set; } = new();
        public void AddMessage(string message)
        {
            /*            if (Text.Count > 10)
                        {
                            Text.RemoveAt(0);
                            Text.Add(message);
                        }
                        else
                        {
                            Text.Add(message);
                        }*/
            Text.Add(message);
            Time.Add(DateTime.Now.ToString("H:mm:ss"));
        }
    }
}
