using CalculatorCSharp.Model;

namespace CalculatorCSharp.Cmds
{
    class BtnCleanClickCommand : CommandBase
    {
        private Data _data;
        private int i = 0;
        public BtnCleanClickCommand(Data data)
        {
            _data = data;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            _data.FirstNum = i;
            _data.SecNum = i;
            _data.Result = i;
            _data.Display = i.ToString();
            _data.Hint = "";
            _data.ArithOp = "";
            _data.IsResult = false;
        }
    }
}
