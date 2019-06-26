using System.Windows;
using System.Windows.Controls;

namespace CalculatorCSharp.Cmds
{
    class SimpleCalcCommand : CommandBase
    {
        public override bool CanExecute(object parameter) => (parameter as StackPanel).Visibility == 0;

        public override void Execute(object parameter)
        {
            (parameter as StackPanel).Visibility = Visibility.Collapsed;
        }
    }
}
