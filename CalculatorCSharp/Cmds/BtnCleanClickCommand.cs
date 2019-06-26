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

        public override void Execute(object parameter) => CleanData(_data, i);

        public static void CleanData(Data data, int i)
        {
            data.FirstNum = i;
            data.SecNum = i;
            data.Result = i;
            data.Display = i.ToString();
            data.Hint = "";
            data.ArithOp = "";
            data.IsResult = false;
            data.IsError = false;
        }
    }
}
