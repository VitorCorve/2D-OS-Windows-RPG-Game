using System;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Scenes.RunGame();
        }
        private void Button_Click(object sender, RoutedEventArgs e) => Environment.Exit(0);
    }
}
