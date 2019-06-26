using CalculatorCSharp.Model;

namespace CalculatorCSharp.Cmds
{
    class BtnCleanEntryClickCommand : CommandBase
    {
        private Data _data;
        private int i = 0;
        public BtnCleanEntryClickCommand(Data data)
        {
            _data = data;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            _data.Display = $"{i}";
            if (_data.IsError)
            {
                BtnCleanClickCommand.CleanData(_data, i);
            }
        }
    }
}
