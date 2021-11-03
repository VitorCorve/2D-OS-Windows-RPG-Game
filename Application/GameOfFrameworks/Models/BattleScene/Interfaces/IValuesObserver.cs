using System;
using System.Timers;

namespace GameOfFrameworks.Models.BattleScene.Interfaces
{
    public interface IValuesObserver
    {
        ICharacterBarModel PlayerBar { get; }
        ICharacterBarModel NPCBar { get; }
        Timer Timer { get; }
        void Update(object sender, ElapsedEventArgs e);
        void Start();
        void Stop();
    }
}
