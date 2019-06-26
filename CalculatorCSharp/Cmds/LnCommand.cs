using CalculatorCSharp.Model;
using System;
using System.Collections.Generic;

namespace CalculatorCSharp.Cmds
{
    class LnCommand : CommandBase
    {
        private Data _data;
        private int _pos = 0;
        private IList<string> _journal;
        public LnCommand(Data data, IList<string> journal)
        {
            _data = data;
            _journal = journal;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            _data.FirstNum = double.Parse(_data.Display);
            if (_data.FirstNum <= 0)
            {
                _data.Display = "Введены некорректные данные!";
                _data.IsError = true;
                _data.IsResult = true;
            }
            else
            {
                _data.Display = Math.Log(_data.FirstNum).ToString();
                _journal.Insert(_pos, $"ln({_data.FirstNum}) = {_data.Display}");
                _data.Hint = $"ln({_data.FirstNum})";
                _data.IsResult = true;
            }
        }
    }
}
