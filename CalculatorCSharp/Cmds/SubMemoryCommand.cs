using CalculatorCSharp.Model;
using System.Collections.Generic;

namespace CalculatorCSharp.Cmds
{
    class SubMemoryCommand : CommandBase
    {
        private Data _data;

        private IList<string> _memoryList;

        public SubMemoryCommand(Data data, IList<string> memoryList)
        {
            _data = data;
            _memoryList = memoryList;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            int i = 0;
            _data.Memory -= double.Parse(_data.Display);
            if (_memoryList.Count == 0)
                _memoryList.Add($"{_data.Memory}");
            else
                _memoryList[i] = _data.Memory.ToString();
            _data.IsResult = true;
        }
    }
}
