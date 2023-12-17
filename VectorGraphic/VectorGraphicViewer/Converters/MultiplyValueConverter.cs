using System;
using System.Globalization;
using System.Windows.Data;

namespace VectorGraphicViewer
{
    public class MultiplyValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double result = default;

            if (parameter != null && value != null) 
            {
                var doubleValue = (double)value;
                var doubleParameter = double.Parse((string)parameter);
                result = doubleValue * doubleParameter;
            }
                
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
