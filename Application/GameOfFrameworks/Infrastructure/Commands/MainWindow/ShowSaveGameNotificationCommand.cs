using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;
using System.Timers;
using System.Windows;

namespace GameOfFrameworks.Infrastructure.Commands.MainWindow
{
    public class ShowSaveGameNotificationCommand : Command
    {
        private int TimerCountdown = 0;
        private Timer NotificationTimer;
        private MainWindowViewModel ViewModel;
        public ShowSaveGameNotificationCommand(MainWindowViewModel mainWindowViewModel) => ViewModel = mainWindowViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            NotificationTimer =  new Timer(10);
            NotificationTimer.Elapsed += Timer_Elapsed;
            NotificationTimer.Start();
            ViewModel.SaveGameNotifyVisibility = Visibility.Visible;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (TimerCountdown < 110) ViewModel.SaveGameNotifyOpacity += 0.01;
            if (TimerCountdown > 190) ViewModel.SaveGameNotifyOpacity -= 0.01;
            if (TimerCountdown == 300)
            {
                NotificationTimer.Stop();
                ViewModel.SaveGameNotifyVisibility = Visibility.Hidden;
                TimerCountdown = 0;
                NotificationTimer = null;
            }
            else TimerCountdown++;
        }
    }
}
