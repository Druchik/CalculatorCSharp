using CalculatorCSharp.Model;
using System;
using System.Collections.Generic;

namespace CalculatorCSharp.Cmds
{
    class TanCommand :CommandBase
    {
        private Data _data;
        private int _pos = 0;
        private IList<string> _journal;
        public TanCommand(Data data, IList<string> journal)
        {
            _data = data;
            _journal = journal;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            _data.FirstNum = double.Parse(_data.Display);
            if (_data.FirstNum % 90 == 0)
            {
                _data.Display = "Введены некорректные данные!";
                _data.IsError = true;
                _data.IsResult = true;
            }
            else
            {
                _data.Display = Math.Tan(Math.PI * _data.FirstNum / 180).ToString();
                _journal.Insert(_pos, $"tan({_data.FirstNum}) = {_data.Display}");
                _data.Hint = $"tan({_data.FirstNum})";
                _data.IsResult = true;
            }
        }
    }
}
