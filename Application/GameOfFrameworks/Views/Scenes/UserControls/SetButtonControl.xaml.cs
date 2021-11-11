using GameOfFrameworks.ApplicationData.Services;
using GameOfFrameworks.ViewModels;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для SetButtonControl.xaml
    /// </summary>
    public partial class SetButtonControl : UserControl
    {
        public SetButtonControl()
        {
            InitializeComponent();
            IncomingDataTextBox.Focusable = true;
            IncomingDataTextBox.Focus();
        }

        private void IncomingDataTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Hidden;
            UpdateKeyboardBindings(e.Key);
            ControlsControlViewModel.UpdateBindings.Execute(null);
            AttributesControlViewModel.UpdateAttributesViewModelCommand.Execute(null);
        }
        private void UpdateKeyboardBindings(Key buttonKey)
        {
            if (buttonKey == Key.Escape) return;
            MainWindowViewModel.Settings.Bindings.ChangeButtonBinding(ButtonBindingHandler.KeyboardBindingIndex, buttonKey);
        }
    }
}
