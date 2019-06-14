using CalculatorCSharp.Model;

namespace CalculatorCSharp.Cmds
{
    class BtnPercentClickCommand : CommandBase
    {
        private Data _data;
        public BtnPercentClickCommand(Data data)
        {
            _data = data;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            var percent = double.Parse(_data.Display);
            _data.Display = (percent / 100).ToString();
            _data.IsResult = true;
        }
    }
}
