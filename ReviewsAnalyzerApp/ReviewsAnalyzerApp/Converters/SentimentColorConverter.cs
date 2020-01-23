using System;
using System.Globalization;
using Xamarin.Forms;

namespace ReviewsAnalyzerApp.Converters
{
    public class SentimentColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var score = (float)value;

            return score == 0.0 ? Color.Black
                : score > 50.0 ? Color.Green
                : Color.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}