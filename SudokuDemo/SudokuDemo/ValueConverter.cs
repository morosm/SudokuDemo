using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SudokuDemo
{
    public class ValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SudokuData sudokuData = (SudokuData)value;
            int param = int.Parse((string)parameter);
            int i = param / 10 - 1;
            int j = param % 10 - 1;
            return sudokuData.Data[i, j];
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
