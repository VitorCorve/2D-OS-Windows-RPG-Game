using GameOfFrameworks.ApplicationData.Interfaces;
using System.Windows.Input;

namespace GameOfFrameworks.ApplicationData
{
    public class ButtonBinding : IButtonBinding
    {
        public int ShortcutIndex { get; set; }

        public Key Key { get; set; }
        public string Name { get; set; }
        public ButtonBinding(Key key, int index)
        {
            Key = key;
            ShortcutIndex = index;
            Name = key.ToString();
        }
        public ButtonBinding() { }
    }
}
