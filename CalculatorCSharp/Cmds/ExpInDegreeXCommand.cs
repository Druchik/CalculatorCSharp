using CalculatorCSharp.Model;
using System;
using System.Collections.Generic;

namespace CalculatorCSharp.Cmds
{
    class ExpInDegreeXCommand : CommandBase
    {
        private Data _data;
        private int _pos = 0;
        private IList<string> _journal;
        public ExpInDegreeXCommand(Data data, IList<string> journal)
        {
            _data = data;
            _journal = journal;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            _data.FirstNum = double.Parse(_data.Display);
            _data.Display = Math.Pow(Math.E, _data.FirstNum).ToString();
            _journal.Insert(_pos, $"exp^({_data.FirstNum}) = {_data.Display}");
            _data.Hint = $"exp^({_data.FirstNum})";
            _data.IsResult = true;
        }
    }
}
