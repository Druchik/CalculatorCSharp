using CalculatorCSharp.Model;

namespace CalculatorCSharp.Cmds
{
    class BtnNegativeClickCommand : CommandBase
    {
        private Data _data;
        public BtnNegativeClickCommand(Data data)
        {
            _data = data;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            if (_data.Display != "0")
            {
                if (!_data.Display.Contains("-"))
                {
                    _data.Display = $"-{_data.Display}";
                }
                else
                {
                    _data.Display = _data.Display.Remove(0, 1);
                }
            }
        }
    }
}
