using GameEngine.Locations;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace GameOfFrameworks.Models.Services
{
    public class EnumToStringTownNamesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           value = (TOWN)value;
           return value.ToString().Replace("_", " ");
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => DependencyProperty.UnsetValue;
    }
}
