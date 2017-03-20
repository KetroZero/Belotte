using CompteurBelotteWindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfBelotte.models;

namespace WpfBelotte.converters
{
    //[ValueConversion(typeof(string), typeof(ImageSource))]
    class StringToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string defaultImage = "carte_dos.bmp";
            string prefix = "/WpfBelotte;component/images/";

            if (value == null) { value = defaultImage as string; }
            if (string.IsNullOrEmpty(value.ToString())) { value = defaultImage as string; }
            if (value.ToString().Contains("carte")) { value = defaultImage as string; }
            

            return string.Concat(prefix, value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
