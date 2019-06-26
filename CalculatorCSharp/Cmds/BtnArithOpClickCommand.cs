using CalculatorCSharp.Model;
using System.Windows.Controls;

namespace CalculatorCSharp.Cmds
{
    class BtnArithOpClickCommand : CommandBase
    {
        private Data _data;
        public BtnArithOpClickCommand(Data data)
        {
            _data = data;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            var btn = parameter as Button;
            _data.FirstNum = double.Parse(_data.Display);
            _data.Hint = _data.Display + btn.Content.ToString();
            _data.ArithOp = btn.Content.ToString();
            _data.IsResult = true;
        }
    }
}
