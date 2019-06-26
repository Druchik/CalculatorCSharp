using CalculatorCSharp.Model;

namespace CalculatorCSharp.Cmds
{
    class XInYRootCommand : CommandBase
    {
        private Data _data;
        public XInYRootCommand(Data data)
        {
            _data = data;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            _data.FirstNum = double.Parse(_data.Display);
            _data.Hint = $"{_data.FirstNum} yroot";
            _data.ArithOp = "yroot";
            _data.IsResult = true;
        }
    }
}
