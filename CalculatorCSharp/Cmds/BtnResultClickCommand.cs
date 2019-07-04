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
            if(_data.SecNum == 0)
                _data.IsResult = false;
            if (!_data.IsResult && !string.IsNullOrEmpty(_data.ArithOp))
                _data.SecNum = double.Parse(_data.Display);
            else
                _data.FirstNum = double.Parse(_data.Display);
            Result();
        }

        private void Result()
        {
            if (_data.ArithOp == "+")
                _data.Result = _data.FirstNum + _data.SecNum;
            else if (_data.ArithOp == "-")
                _data.Result = _data.FirstNum - _data.SecNum;
            else if (_data.ArithOp == "*")
                _data.Result = _data.FirstNum * _data.SecNum;
            else if (_data.ArithOp == "/")
            {
                if (_data.Display == "0")
                {
                    _data.Display = "Деление на ноль!";
                    _data.IsError = true;
                    _data.IsResult = true;
                    return;
                }
                else
                    _data.Result = _data.FirstNum / _data.SecNum;
            }
            else if (_data.ArithOp == "^")
                _data.Result = Math.Pow(_data.FirstNum, _data.SecNum);
            else if (_data.ArithOp == "yroot")
            {
                if (_data.FirstNum < 0)
                {
                    _data.Display = "Введены некорректные данные!";
                    _data.IsError = true;
                    _data.IsResult = true;
                    return;
                }
                else
                    _data.Result = Math.Pow(_data.FirstNum, 1 / _data.SecNum);
            }
            else
            {
                _data.Result = _data.FirstNum;
            }
            _data.Display = _data.Result.ToString();
            _data.Hint = "";
            if(!string.IsNullOrEmpty(_data.ArithOp))
                _journal.Insert(_pos, $"{_data.FirstNum} {_data.ArithOp} {_data.SecNum} = {_data.Result}");
            else
                _journal.Insert(_pos, $"{_data.FirstNum} = {_data.Result}");
            _data.FirstNum = _data.Result;
            _data.IsResult = true;
        }
    }
}