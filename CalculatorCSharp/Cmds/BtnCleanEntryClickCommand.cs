using CalculatorCSharp.Model;

namespace CalculatorCSharp.Cmds
{
    class BtnCleanEntryClickCommand : CommandBase
    {
        private Data _data;
        public BtnCleanEntryClickCommand(Data data)
        {
            _data = data;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            _data.Display = "0";
        }
    }
}
