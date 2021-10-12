using GameOfFrameworks.ApplicationData.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace GameOfFrameworks.ApplicationData
{
    public class ApplicationDisplayWindowStyle : IApplicationDisplayWindowStyle, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public delegate void ChangeWindowStyleAction();
        private readonly List<ChangeWindowStyleAction> ActionList = new();
        private WindowStyle _Style;
        private WindowState _State;
        private int _WindowBorderStyleIndex;
        public WindowStyle Style { get => _Style; set { _Style = value; OnPropertyChanged(); } }
        public WindowState State { get => _State; set { _State = value; OnPropertyChanged(); } }
        public int WindowBorderStyleIndex { get => _WindowBorderStyleIndex; set { _WindowBorderStyleIndex = value; ConvertWindowBorderStyleIndex(); } }
        public ApplicationDisplayWindowStyle()
        {
            ActionList.Add(SetWindowBorderStyleToNone);
            ActionList.Add(SetWindowBorderStyleToBordered);
        }

        public void SetNextWindowStyle()
        {
            WindowBorderStyleIndex++;
            ActionList[WindowBorderStyleIndex].Invoke();
        }

        public void SetPreviousWindowStyle()
        {
            WindowBorderStyleIndex--;
            ActionList[WindowBorderStyleIndex].Invoke();
        }
        private void SetWindowBorderStyleToBordered()
        {
            Style = WindowStyle.SingleBorderWindow;
            State = WindowState.Normal;
        }
        private void SetWindowBorderStyleToNone()
        {
            Style = WindowStyle.None;
            State = WindowState.Maximized;
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        private void ConvertWindowBorderStyleIndex()
        {
            if (WindowBorderStyleIndex < 0) WindowBorderStyleIndex = 1;
            if (WindowBorderStyleIndex > 1) WindowBorderStyleIndex = 0;
        }
        public void SetDefault()
        {
            Style = WindowStyle.None;
            State = WindowState.Maximized;
        }
    }
}
