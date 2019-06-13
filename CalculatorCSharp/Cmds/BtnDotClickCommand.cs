using CalculatorCSharp.Model;

namespace CalculatorCSharp.Cmds
{
    class BtnDotClickCommand : CommandBase
    {
        private Data _data;
        public BtnDotClickCommand(Data data)
        {
            _data = data;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            if (!_data.Display.Contains(","))
            {
                _data.Display = $"{_data.Display},";
            }
        }
    }
}
