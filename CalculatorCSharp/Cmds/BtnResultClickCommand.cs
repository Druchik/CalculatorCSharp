using CalculatorCSharp.Model;
using System;
using System.Collections.Generic;

namespace CalculatorCSharp.Cmds
{
    class BtnResultClickCommand : CommandBase
    {
        private Data _data;
        private int _pos = 0;
        private IList<string> _journal;

        public BtnResultClickCommand(Data data, IList<string> journal)
        {
            _data = data;
            _journal = journal;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

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
            else if (_data.ArithOp == "^")
                Pow();
            else if (_data.ArithOp == "yroot")
                Root();
        }

        private void Sum()
        {
            _data.Result = _data.FirstNum + _data.SecNum;
            _data.Display = _data.Result.ToString();
            _data.Hint = "";
            _journal.Insert(_pos, $"{_data.FirstNum} {_data.ArithOp} {_data.SecNum} = {_data.Result}");
            _data.FirstNum = _data.Result;
            _data.IsResult = true;
        }

        private void Sub()
        {
            _data.Result = _data.FirstNum - _data.SecNum;
            _data.Display = _data.Result.ToString();
            _data.Hint = "";
            _journal.Insert(_pos, $"{_data.FirstNum} {_data.ArithOp} {_data.SecNum} = {_data.Result}");
            _data.FirstNum = _data.Result;
            _data.IsResult = true;
        }

        private void Mul()
        {
            _data.Result = _data.FirstNum * _data.SecNum;
            _data.Display = _data.Result.ToString();
            _data.Hint = "";
            _journal.Insert(_pos, $"{_data.FirstNum} {_data.ArithOp} {_data.SecNum} = {_data.Result}");
            _data.FirstNum = _data.Result;
            _data.IsResult = true;
        }

        private void Div()
        {
            if (_data.Display == "0")
            {
                //MessageBox.Show("Деление на ноль!!!");
                _data.Display = "Деление на ноль!";
                _data.IsError = true;
                _data.IsResult = true;
            }
            else
            {
                _data.Result = _data.FirstNum / _data.SecNum;
                _data.Display = _data.Result.ToString();
                _data.Hint = "";
                _journal.Insert(_pos, $"{_data.FirstNum} {_data.ArithOp} {_data.SecNum} = {_data.Result}");
                _data.FirstNum = _data.Result;
                _data.IsResult = true;
            }
        }

        private void Pow()
        {
            _data.Result = Math.Pow(_data.FirstNum, _data.SecNum);
            _data.Display = _data.Result.ToString();
            _data.Hint = "";
            _journal.Insert(_pos, $"{_data.FirstNum} {_data.ArithOp} {_data.SecNum} = {_data.Result}");
            _data.FirstNum = _data.Result;
            _data.IsResult = true;
        }

        private void Root()
        {
            if (_data.FirstNum < 0)
            {
                _data.Display = "Введены некорректные данные!";
                _data.IsError = true;
                _data.IsResult = true;
            }
            else
            {
                _data.Result = Math.Pow(_data.FirstNum, 1 / _data.SecNum);
                _data.Display = _data.Result.ToString();
                _data.Hint = "";
                _journal.Insert(_pos, $"{_data.FirstNum} {_data.ArithOp} {_data.SecNum} = {_data.Result}");
                _data.FirstNum = _data.Result;
                _data.IsResult = true;
            }
        }
    }
}
