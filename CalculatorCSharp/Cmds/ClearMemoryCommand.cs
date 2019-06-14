using CalculatorCSharp.Model;
using System.Collections.Generic;

namespace CalculatorCSharp.Cmds
{
    class ClearMemoryCommand : CommandBase
    {
        private Data _data;

        private IList<string> _memoryList;

        public ClearMemoryCommand(Data data, IList<string> memoryList)
        {
            _data = data;
            _memoryList = memoryList;
        }

        public override bool CanExecute(object parameter) => _memoryList.Count > 0;

        public override void Execute(object parameter)
        {
            _data.Memory = 0;
            _memoryList.Clear();
        }
    }
}