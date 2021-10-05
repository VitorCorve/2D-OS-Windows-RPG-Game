using GameEngine.Locations;
using GameOfFrameworks.Models.UIVisualisation.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.Models.UIVisualisation
{
    public class TownMapElementView : ITownMapElementView, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private bool _IsSelected;
        private string _Color;
        public bool IsSelected { get => _IsSelected; set { _IsSelected = value; OnPropertyChanged(); ConvertColor(value); } }
        public string Color { get => _Color; set { _Color = value; OnPropertyChanged(); } }
        public TOWN Name { get; set; }
        protected void OnPropertyChanged([CallerMemberName] string property = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        public TownMapElementView(TOWN name)
        {
             Name = name;
             Color = "Black";
        }
        private void ConvertColor(bool value)
        {
            if (value) Color = "#FF9C0303";
            else Color = "Black";
        }
    }
}
