using CalculatorCSharp.Model;
using System;
using System.Collections.Generic;
using System.Windows;

namespace CalculatorCSharp.Cmds
{
    class BtnSqrtClickCommand : CommandBase
    {
        private Data _data;
        private int _pos = 0;
        private IList<string> _journal;
        public BtnSqrtClickCommand(Data data, IList<string> journal)
        {
            _data = data;
            _journal = journal;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            if (!_data.Display.Contains("-"))
            {
                _data.FirstNum = double.Parse(_data.Display);
                _data.Display = Math.Sqrt(_data.FirstNum).ToString();
                _journal.Insert(_pos, $"sqrt({_data.FirstNum}) = {_data.Display}");
                _data.Hint = $"sqrt({_data.FirstNum})";
                _data.IsResult = true;
            }
            else
            {
                //MessageBox.Show("Некорректные данные!!!");
                _data.Display = "Некорректные данные!";
                _data.IsError = true;
                _data.IsResult = true;
            }
        }
    }
}
