using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SudokuDemo
{
    public class SudokuData : INotifyPropertyChanged
    {
        private string[,] _data;
        private int _i;
        private int _j;

        public SudokuData(int i, int j)
        {
            this._i = i;
            this._j = j;
            _data = new string[i, j];
        }

        public string[,] Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Data"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
