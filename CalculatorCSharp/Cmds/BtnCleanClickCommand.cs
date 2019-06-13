using CalculatorCSharp.Model;

namespace CalculatorCSharp.Cmds
{
    class BtnCleanClickCommand : CommandBase
    {
        private Data _data;
        public BtnCleanClickCommand(Data data)
        {
            _data = data;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            _data.FirstNum = 0;
            _data.SecNum = 0;
            _data.Result = 0;
            _data.Display = "0";
            _data.Hint = "";
            _data.ArithOp = "";
            _data.IsResult = false;
        }
    }
}
