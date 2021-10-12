using GameOfFrameworks.ApplicationData.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.ApplicationData
{
    public class ApplicationDisplayResolution : IApplicationDisplayResolution, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public delegate void ChangeResolutionAction();
        private readonly List<ChangeResolutionAction> ActionList = new();
        private int _Height;
        private int _Width;
        private int _ResolutionIndex;
        public int Height { get => _Height; set { _Height = value; OnPropertyChanged(); } }
        public int Width { get => _Width; set { _Width = value; OnPropertyChanged(); } }
        public int ResolutionIndex { get => _ResolutionIndex; set { _ResolutionIndex = value; ConvertResolutionIndex(); } }
        public ApplicationDisplayResolution()
        {
            if (Height == 0 && Width == 0)
            {
                Height = 1080;
                Width = 1920;
                ResolutionIndex = 3;
            }
            ActionList.Add(SetResolution_A);
            ActionList.Add(SetResolution_B);
            ActionList.Add(SetResolution_C);
            ActionList.Add(SetResolution_D);
        }
        public void SetNextResolution()
        {
            ResolutionIndex++;
            ActionList[ResolutionIndex].Invoke();
        }
        public void SetPreviousResolution()
        {
            ResolutionIndex--;
            ActionList[ResolutionIndex].Invoke();
        }
        private void SetResolution_A()
        {
            Width = 1280;
            Height = 720;
        }
        private void SetResolution_B()
        {
            Width = 1440;
            Height = 900;
        }
        private void SetResolution_C()
        {
            Width = 1600;
            Height = 1024;
        }
        private void SetResolution_D()
        {
            Width = 1920;
            Height = 1080;
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        private void ConvertResolutionIndex()
        {
            if (ResolutionIndex < 0) ResolutionIndex = 3;
            if (ResolutionIndex > 3) ResolutionIndex = 0;
        }
    }
}
