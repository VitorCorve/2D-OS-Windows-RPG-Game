using GameOfFrameworks.ApplicationData.Services;
using GameOfFrameworks.Models.Temporary;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ControlsControl.xaml
    /// </summary>
    public partial class ControlsControl : UserControl
    {
        private delegate void Function();
        public ControlsControl()
        {
            InitializeComponent();
            SetButtonControl.Visibility = Visibility.Hidden;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonBindingHandler.KeyboardBindingIndex = 10;
            ShowSetButtonControl();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ButtonBindingHandler.KeyboardBindingIndex = 11;
            ShowSetButtonControl();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ButtonBindingHandler.KeyboardBindingIndex = 0;
            ShowSetButtonControl();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ShowSetButtonControl();
            ButtonBindingHandler.KeyboardBindingIndex = 1;
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ButtonBindingHandler.KeyboardBindingIndex = 2;
            ShowSetButtonControl();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ButtonBindingHandler.KeyboardBindingIndex = 3;
            ShowSetButtonControl();
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ButtonBindingHandler.KeyboardBindingIndex = 4;
            ShowSetButtonControl();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ButtonBindingHandler.KeyboardBindingIndex = 5;
            ShowSetButtonControl();
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ButtonBindingHandler.KeyboardBindingIndex = 6;
            ShowSetButtonControl();
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ButtonBindingHandler.KeyboardBindingIndex = 7;
            ShowSetButtonControl();
        }
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ButtonBindingHandler.KeyboardBindingIndex = 8;
            ShowSetButtonControl();
        }
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ButtonBindingHandler.KeyboardBindingIndex = 9;
            ShowSetButtonControl();
        }
        private async void ShowSetButtonControl()
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();

            SetButtonControl.Opacity = 0.0;
            SetButtonControl.Visibility = Visibility.Visible;
            SetButtonControl.Focusable = true;
            SetButtonControl.Focus();
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Action(() => SetButtonControl.Opacity += 0.05);
                    System.Threading.Thread.Sleep(10);
                }
            });
        }
        private void Action(Function func = null)
        {
            Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background,
                new Action(() =>
                {
                    func?.Invoke();
                }));
        }
    }
}
