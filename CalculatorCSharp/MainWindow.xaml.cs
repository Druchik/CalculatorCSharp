using CalculatorCSharp.ViewModel;
using System.Windows;

namespace CalculatorCSharp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Calc.DataContext = new MainVM();
        }
    }
}
