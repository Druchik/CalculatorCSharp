using CalculatorCSharp.Model;

namespace CalculatorCSharp.Cmds
{
    class BtnBckSpcClickCommand : CommandBase
    {
        private Data _data;
        public BtnBckSpcClickCommand(Data data)
        {
            _data = data;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            _data.Display = _data.Display.Length >= 1 ? _data.Display.Remove(_data.Display.Length - 1, 1) : "0";
            if (_data.Display.Length == 0)
                _data.Display = "0";
        }
    }
}
