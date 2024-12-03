using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace soc
{
    public class FechaHoraConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string fechaIso)
            {
                if (DateTime.TryParse(fechaIso, null, DateTimeStyles.RoundtripKind, out DateTime fechaFormateada))
                {
                    return fechaFormateada.ToString("dd MMM yyyy, HH:mm", CultureInfo.InvariantCulture);
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
