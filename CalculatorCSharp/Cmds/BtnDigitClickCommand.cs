using CalculatorCSharp.Model;
using System.Windows.Controls;

namespace CalculatorCSharp.Cmds
{
    class BtnDigitClickCommand : CommandBase
    {
        private Data _data;
        public BtnDigitClickCommand(Data data)
        {
            _data = data;
        }
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            var btn = parameter as Button;

            if (!_data.IsResult)
            {
                if (_data.Display == "0")
                {
                    _data.Display = btn.Content.ToString();
                }
                else
                {
                    _data.Display += btn.Content.ToString();
                }
            }
            else
            {
                _data.Display = btn.Content.ToString();
                _data.IsResult = false;
            }
        }
    }
}
