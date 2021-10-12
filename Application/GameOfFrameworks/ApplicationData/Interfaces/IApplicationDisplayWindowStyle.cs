using System.Windows;

namespace GameOfFrameworks.ApplicationData.Interfaces
{
    public interface IApplicationDisplayWindowStyle
    {
        WindowStyle Style { get; }
        WindowState State { get; }
        void SetNextWindowStyle();
        void SetPreviousWindowStyle();
        void SetDefault();
    }
}
