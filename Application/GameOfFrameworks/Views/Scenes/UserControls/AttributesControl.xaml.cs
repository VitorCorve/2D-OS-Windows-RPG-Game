using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для AttributesControl.xaml
    /// </summary>
    public partial class AttributesControl : UserControl
    {
        public AttributesControl()
        {
            InitializeComponent();
        }
        private void MainGrid_MouseMove(object sender, MouseEventArgs e)
        {
            ShortcutPopup.VerticalOffset = Mouse.GetPosition(MainGrid).Y-25;
            ShortcutPopup.HorizontalOffset = Mouse.GetPosition(MainGrid).X - 25;
        }
    }
}
