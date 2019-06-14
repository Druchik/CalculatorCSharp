using CalculatorCSharp.Model;
using System.Collections.Generic;
using System.Windows;

namespace CalculatorCSharp.Cmds
{
    class BtnDivXClickCommand : CommandBase
    {
        private Data _data;
        private int _pos = 0;
        private IList<string> _journal;
        public BtnDivXClickCommand(Data data, IList<string> journal)
        {
            _data = data;
            _journal = journal;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            if (_data.Display == "0")
            {
                MessageBox.Show("Деление на ноль!!!");
            }
            else
            {
                _data.FirstNum = double.Parse(_data.Display);
                _data.Display = (1 / _data.FirstNum).ToString();
                _journal.Insert(_pos, $"1/{_data.FirstNum} = {_data.Display}");
                _data.Hint = $"1/{_data.FirstNum}";
                _data.IsResult = true;
            }
        }
    }
}
