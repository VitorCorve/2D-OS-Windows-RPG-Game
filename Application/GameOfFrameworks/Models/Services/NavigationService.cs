using GalaSoft.MvvmLight.Views;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace GameOfFrameworks.Models.Services
{
    public class NavigationService : INavigationService
    {
        public string CurrentPageKey => throw new NotImplementedException();
        public void GoBack()
        {
            var frame = (Frame)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive).Content;
            frame.GoBack();
        }

        public void NavigateTo(string pageKey)
        {
            var frame = (Frame)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive).Content;
            frame.Navigate(pageKey);
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            var frame = (Frame)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive).Content;
            frame.Navigate(pageKey, parameter);
        }
    }
}
