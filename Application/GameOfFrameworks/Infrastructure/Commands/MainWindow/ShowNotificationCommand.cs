using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;
using System.Timers;
using System.Windows;

namespace GameOfFrameworks.Infrastructure.Commands.MainWindow
{
    public class ShowNotificationCommand : Command
    {
        private int TimerCountdown = 0;
        private Timer NotificationTimer;
        private MainWindowViewModel ViewModel;
        public ShowNotificationCommand(MainWindowViewModel mainWindowViewModel) => ViewModel = mainWindowViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            if (NotificationTimer != null)
            {
                NotificationTimer.Dispose();
                ViewModel.NotifyVisibility = Visibility.Hidden;
                ViewModel.SaveGameNotifyOpacity = 0.0;
                TimerCountdown = 0;
            }
            ViewModel.NotifyMessage = (string)parameter;
            NotificationTimer =  new Timer(10);
            NotificationTimer.Elapsed += Timer_Elapsed;
            NotificationTimer.Start();
            ViewModel.NotifyVisibility = Visibility.Visible;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (TimerCountdown < 110) ViewModel.SaveGameNotifyOpacity += 0.01;
            if (TimerCountdown > 190) ViewModel.SaveGameNotifyOpacity -= 0.01;
            if (TimerCountdown == 300)
            {
                NotificationTimer.Stop();
                ViewModel.NotifyVisibility = Visibility.Hidden;
                TimerCountdown = 0;
                NotificationTimer = null;
            }
            else TimerCountdown++;
        }
    }
}
