using CalculatorCSharp.Model;
using System;
using System.Collections.Generic;

namespace CalculatorCSharp.Cmds
{
    class CosCommand : CommandBase
    {
        private Data _data;
        private int _pos = 0;
        private IList<string> _journal;
        public CosCommand(Data data, IList<string> journal)
        {
            _data = data;
            _journal = journal;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            _data.FirstNum = double.Parse(_data.Display);
            _data.Display = Math.Cos(Math.PI * _data.FirstNum / 180).ToString();
            _journal.Insert(_pos, $"cos({_data.FirstNum}) = {_data.Display}");
            _data.Hint = $"cos({_data.FirstNum})";
            _data.IsResult = true;
        }
    }
}
