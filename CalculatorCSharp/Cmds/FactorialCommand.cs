using CalculatorCSharp.Model;
using System.Collections.Generic;

namespace CalculatorCSharp.Cmds
{
    class FactorialCommand : CommandBase
    {
        private Data _data;
        private int _pos = 0;
        private IList<string> _journal;
        public FactorialCommand(Data data, IList<string> journal)
        {
            _data = data;
            _journal = journal;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            _data.FirstNum = double.Parse(_data.Display);
            if (_data.FirstNum < 0)
            {
                _data.Display = "Некорректные данные!";
                _data.IsError = true;
                _data.IsResult = true;
            }
            else
            {
                _data.Display = Factorial(_data.FirstNum).ToString();
                _journal.Insert(_pos, $"fact({_data.FirstNum}) = {_data.Display}");
                _data.Hint = $"fact({_data.FirstNum})";
                _data.IsResult = true;
            }
        }

        private double Factorial(double num)
        {
            if (num == 0)
                return 1;
            else if (num > 1)
                num *= Factorial(num - 1);
            return num;
        }
    }
}
