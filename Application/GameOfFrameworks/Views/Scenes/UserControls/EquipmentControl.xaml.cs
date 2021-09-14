using GameEngine.Equipment;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
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
    /// Логика взаимодействия для EquipmentControl.xaml
    /// </summary>
    public partial class EquipmentControl : UserControl
    {
        private readonly EquipmentControlMouseSelectionHandler EquipmentHandler;
        public EquipmentControl()
        {
            InitializeComponent();
            EquipmentHandler = new EquipmentControlMouseSelectionHandler(this);
        }
        private void HelmetShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void GlovesShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void MainWeaponShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void ShouldersShortcut_MouseEnter(object sender, MouseEventArgs e) => DescriptionToolTip.Visibility = Visibility.Visible;
        private void BracersShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void SecondWeaponShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void NecklaceShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void WaistShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void FirstArtefactShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void SecondArtefactShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void ThirdArtefactShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void ChestShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void PantsShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void CloakShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void BootsShortcut_MouseEnter(object sender, MouseEventArgs e) { }
        private void HelmetShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void GlovesShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void MainWeaponShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void BracersShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void ShouldersShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void SecondWeaponShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void NecklaceShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void WaistShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void FirstArtefactShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void SecondArtefactShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void ThirdArtefactShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void ChestShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void PantsShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void CloakShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void BootsShortcut_MouseLeave(object sender, MouseEventArgs e) => HideDescriptionDialog();
        private void HideDescriptionDialog() => DescriptionToolTip.Visibility = Visibility.Hidden;
    }
}
