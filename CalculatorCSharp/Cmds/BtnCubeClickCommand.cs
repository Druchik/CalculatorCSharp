using CalculatorCSharp.Model;
using System;
using System.Collections.Generic;

namespace CalculatorCSharp.Cmds
{
    class BtnCubeClickCommand : CommandBase
    {
        private Data _data;
        private int _pos = 0;
        private IList<string> _journal;
        public BtnCubeClickCommand(Data data, IList<string> journal)
        {
            _data = data;
            _journal = journal;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            _data.FirstNum = double.Parse(_data.Display);
            _data.Display = Math.Pow(_data.FirstNum, 3).ToString();
            _journal.Insert(_pos, $"cube({_data.FirstNum}) = {_data.Display}");
            _data.Hint = $"cube({_data.FirstNum})";
            _data.IsResult = true;
        }
    }
}
