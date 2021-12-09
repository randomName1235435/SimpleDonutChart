using System;
using System.Windows.Data;

namespace SimpleDonutChart.DonutChart
{
    public class PercentageConverter : IValueConverter
    {
        public object Convert(object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            double outParam;
            if (double.TryParse(value.ToString(), out outParam))
            {
                if (outParam > 100) return (double)0;
                return (360) - (outParam * System.Convert.ToDouble(3.6));
            }
            return (double)0;
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
