using CalculatorCSharp.Model;
using System;
using System.Collections.Generic;

namespace CalculatorCSharp.Cmds
{
    class BtnSqrClickCommand : CommandBase
    {
        private Data _data;
        private int _pos = 0;
        private IList<string> _journal;
        public BtnSqrClickCommand(Data data, IList<string> journal)
        {
            _data = data;
            _journal = journal;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            _data.FirstNum = double.Parse(_data.Display);
            _data.Display = Math.Pow(_data.FirstNum, 2).ToString();
            _journal.Insert(_pos, $"sqr({_data.FirstNum}) = {_data.Display}");
            _data.Hint = $"sqr({_data.FirstNum})";
            _data.IsResult = true;
        }
    }
}
