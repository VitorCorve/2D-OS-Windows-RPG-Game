using System.Windows.Controls;

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

        private void IncomingDataTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var result = e.Key;
            this.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
