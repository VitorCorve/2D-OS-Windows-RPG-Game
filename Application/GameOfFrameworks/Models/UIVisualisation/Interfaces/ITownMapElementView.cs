using GameEngine.Locations;

namespace GameOfFrameworks.Models.UIVisualisation.Interfaces
{
    public interface ITownMapElementView
    {
        TOWN Name { get; }
        bool IsSelected { get; }
        string Color { get; }
    }
}
