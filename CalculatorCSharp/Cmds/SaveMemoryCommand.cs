using CalculatorCSharp.Model;
using System.Collections.Generic;

namespace CalculatorCSharp.Cmds
{
    class SaveMemoryCommand :CommandBase
    {
        private Data _data;

        private IList<string> _memoryList;

        public SaveMemoryCommand(Data data, IList<string> memoryList)
        {
            _data = data;
            _memoryList = memoryList;
        }

        public override bool CanExecute(object parameter) => !_data.IsError;

        public override void Execute(object parameter)
        {
            _data.Memory = double.Parse(_data.Display);
            _memoryList.Insert(_memoryList.Count - _memoryList.Count, $"{_data.Memory}");
            _data.IsResult = true;
        }
    }
}
