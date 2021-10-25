using System.Timers;
using System.Windows;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces
{
    public interface ISkillEffectView
    {
        Visibility CooldownStatement { get; set; }
        Visibility DurationStatement { get; set; }
        int ID { get; }
        double DurationCount { get; }
        double CooldownCount { get; }
        string ImagePath { get; }
        Timer DurationTimer { get; }
        Timer CooldownTimer { get; }
        void Activate();
        void Hide();
        void Show();
    }
}
