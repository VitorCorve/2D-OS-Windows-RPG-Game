using GameOfFrameworks.Models.Temporary;
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
        }
    }
}
