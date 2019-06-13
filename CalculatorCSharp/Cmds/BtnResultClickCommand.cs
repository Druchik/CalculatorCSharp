using CalculatorCSharp.Model;
using System.Collections.Generic;
using System.Windows;

namespace CalculatorCSharp.Cmds
{
    class BtnResultClickCommand : CommandBase
    {
        private Data _data;

        private IList<string> _journal;

        public BtnResultClickCommand(Data data, IList<string> journal)
        {
            _data = data;
            _journal = journal;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            if (!_data.IsResult)
                _data.SecNum = double.Parse(_data.Display);
            if (_data.ArithOp == "+")
                Sum();
            else if (_data.ArithOp == "-")
                Sub();
            else if (_data.ArithOp == "*")
                Mul();
            else if (_data.ArithOp == "/")
                Div();
        }

        private void Sum()
        {
            _data.Result = _data.FirstNum + _data.SecNum;
            _data.Display = _data.Result.ToString();
            _data.Hint = "";
            _journal.Add($"{_data.FirstNum} {_data.ArithOp} {_data.SecNum} = {_data.Result}");
            _data.FirstNum = _data.Result;
            _data.IsResult = true;

        }

        private void Sub()
        {
            _data.Result = _data.FirstNum - _data.SecNum;
            _data.Display = _data.Result.ToString();
            _data.Hint = "";
            _journal.Add($"{_data.FirstNum} {_data.ArithOp} {_data.SecNum} = {_data.Result}");
            _data.FirstNum = _data.Result;
            _data.IsResult = true;
        }

        private void Mul()
        {
            _data.Result = _data.FirstNum * _data.SecNum;
            _data.Display = _data.Result.ToString();
            _data.Hint = "";
            _journal.Add($"{_data.FirstNum} {_data.ArithOp} {_data.SecNum} = {_data.Result}");
            _data.FirstNum = _data.Result;
            _data.IsResult = true;

        }

        private void Div()
        {
            if (_data.Display == "0")
            {
                MessageBox.Show("Деление на ноль!!!");
            }
            else
            {
                _data.Result = _data.FirstNum / _data.SecNum;
                _data.Display = _data.Result.ToString();
                _data.Hint = "";
                _journal.Add($"{_data.FirstNum} {_data.ArithOp} {_data.SecNum} = {_data.Result}");
                _data.FirstNum = _data.Result;
                _data.IsResult = true;
            }
        }
    }
}
