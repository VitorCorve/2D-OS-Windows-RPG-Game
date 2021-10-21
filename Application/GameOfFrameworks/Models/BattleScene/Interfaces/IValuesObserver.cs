using System;
using System.Timers;

namespace GameOfFrameworks.Models.BattleScene.Interfaces
{
    public interface IValuesObserver
    {
        ICharacterBarView PlayerBar { get; }
        ICharacterBarView NPCBar { get; }
        Timer Timer { get; }
        void Update(object sender, ElapsedEventArgs e);
        void Start();
        void Stop();
    }
}
