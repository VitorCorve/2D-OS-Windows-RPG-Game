using GalaSoft.MvvmLight.Command;
using GameOfFrameworks.ApplicationData;
using GameOfFrameworks.ViewModels.Base;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options
{
    public class ControlsControlViewModel : ViewModel
    {
        private KeyboardBindingsModel _Bindings;
        public KeyboardBindingsModel Bindings { get => _Bindings; set => Set(ref _Bindings, value); }
        public static ICommand UpdateBindings { get; private set; }
        public ControlsControlViewModel()
        {
            Bindings = MainWindowViewModel.Settings.Bindings;
            UpdateBindings = new RelayCommand(Update);
        }
        private void Update()
        {
            Bindings = null;
            Bindings = MainWindowViewModel.Settings.Bindings;
        }
    }
}
