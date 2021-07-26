using System;
using System.Windows.Data;

namespace SimpleDonutChart.DonutChart
{
    public class PercentStringConverter : IValueConverter
    {
        public object Convert(object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            return value + "%";
        }
        public object ConvertBack(object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            return 0.0;
        }
    }
}