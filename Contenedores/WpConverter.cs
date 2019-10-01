﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Diagnostics;

namespace Contenedores
{
    public class WpConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            return Int32.Parse(value.ToString()) - 200;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           
            throw new NotImplementedException();
        }
    }
}
