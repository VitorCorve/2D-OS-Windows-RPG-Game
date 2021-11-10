using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;
using System.Windows.Controls;

namespace GameOfFrameworks.Scenes
{
    /// <summary>
    /// Логика взаимодействия для BattleWindow.xaml
    /// </summary>
    public partial class BattleWindow : Page
    {
        public BattleWindow()
        {
            InitializeComponent();
            BattleWindowTemporaryData.Instance = this;
            ShortcutsControlElement.Focusable = true;
            ShortcutsControlElement.Focus();
            MainWindowViewModel.ConsoleDisengaged += ShortcutsControlElement.Focus;
        }

        private void BattleWindowControlElement_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            BattleWindowTemporaryData.ViewModel.Bindings.SkillUse(e.Key);
        }
    }
}
