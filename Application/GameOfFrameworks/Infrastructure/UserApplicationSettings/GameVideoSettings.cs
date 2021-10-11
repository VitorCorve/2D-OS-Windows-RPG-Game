using System.Collections.Generic;
using System.Windows;

namespace GameOfFrameworks.Infrastructure.UserApplicationSettings
{
    public class GameVideoSettings
    {
        private int _UserResolutionSelector;
        public int UserResolutionSelector { get => _UserResolutionSelector; set => ConvertUserResolutionSelectorValue(value); }
        public int HorizontalVideoResolution { get; set; }
        public int VerticalVideoResolution { get; set; }
        public int UserResolutionSetting { get; set; }
        public WindowStyle UserWindowStyleSetting { get; set; }
        public string UserWindowStateSetting { get; set; }
        public Dictionary<int, int> VideoResolutionsDictionary { get; private set; } = new Dictionary<int, int>();
        public GameVideoSettings()
        {
            VideoResolutionsDictionary.Add(1360, 768);
            VideoResolutionsDictionary.Add(1600, 1200);
            VideoResolutionsDictionary.Add(1920, 1080);

            if (CheckUserSettings()) SetVideoResolution(UserResolutionSetting);
        }
        private bool CheckUserSettings()
        {
            UserWindowStateSetting = "Maximized";
            UserWindowStyleSetting = WindowStyle.None;
            UserResolutionSetting = 2;
            return true;
        }
        private void SetVideoResolution(int selectionValue)
        {
            int count = 0;
            foreach (var item in VideoResolutionsDictionary)
            {
                if (selectionValue != count)
                {
                    count++;
                    continue;
                }
                HorizontalVideoResolution = item.Key;
                VerticalVideoResolution = item.Value;
                return;
            }
        }
        private void ConvertUserResolutionSelectorValue(int value)
        {
            if (value > 2) _UserResolutionSelector = 0;
            if (value < 2) _UserResolutionSelector = 2;
            _UserResolutionSelector = value;
        }
        public void SelectNextVideoResolution()
        {
            UserResolutionSelector++;
            SetVideoResolution(UserResolutionSetting);
        }
        public void SelectPreviousVideoResolution()
        {
            UserResolutionSelector--;
            SetVideoResolution(UserResolutionSetting);
        }
    }
}
