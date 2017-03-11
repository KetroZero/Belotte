using CompteurBelotteWindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfBelotte.converters
{
    class EquipeToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                if (value.ToString().ToLower() == Equipe.Paire.ToString().ToLower()) { return false; }
                if (value.ToString().ToLower() == Equipe.Impaire.ToString().ToLower()) { return true; }
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
