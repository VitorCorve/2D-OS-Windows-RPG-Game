using System.Windows.Input;

namespace GameOfFrameworks.ApplicationData.Interfaces
{
    public interface IButtonBinding
    {
        string Name { get; set; }
        int ShortcutIndex { get; set; }
        Key Key { get; set; }
    }
}
