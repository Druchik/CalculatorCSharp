using CalculatorCSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCSharp.Cmds
{
    class XInDegreeYCommand : CommandBase
    {
        private Data _data;
        public XInDegreeYCommand(Data data)
        {
            _data = data;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            _data.FirstNum = double.Parse(_data.Display);
            _data.Hint = $"{_data.FirstNum}^";
            _data.ArithOp = "^";
            _data.IsResult = true;
        }
    }
}
