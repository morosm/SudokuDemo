using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuDemo
{
    public class ViewModel
    {
        public SudokuData SudokuData { get; set; }
        public ViewModel()
        {
            int num = 3;
            SudokuData= new SudokuData(num,num);
            InitialGenerator(SudokuData, num);
        }

        public void InitialGenerator(SudokuData SudokuData, int num)
        { 
            int counter = 1;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    SudokuData.Data[i, j] = counter.ToString();
                    counter++;
                }
            }
        }
    }
}
