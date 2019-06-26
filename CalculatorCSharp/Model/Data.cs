using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CalculatorCSharp.Model
{
    class Data : INotifyPropertyChanged
    {
        string _display = "0";
        double _firstNum;
        double _secNum;
        double _result;
        double _memory = 0;
        string _arithOp;
        string _hint;
        bool _isResult = false;
        bool _isError = false;

        public double FirstNum
        {
            get => _firstNum;

            set
            {
                _firstNum = value;
                OnPropertyChanged("FirstNum");
            }
        }
        public double SecNum
        {
            get => _secNum;

            set
            {
                _secNum = value;
                OnPropertyChanged("SecNum");
            }
        }
        public double Result
        {
            get => _result;

            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }
        public string ArithOp
        {
            get => _arithOp;

            set
            {
                _arithOp = value;
                OnPropertyChanged("ArithOp");
            }
        }
        public bool IsResult
        {
            get => _isResult;

            set
            {
                _isResult = value;
                OnPropertyChanged("IsResult");
            }
        }

        public bool IsError
        {
            get => _isError;

            set
            {
                _isError = value;
                OnPropertyChanged("IsError");
            }
        }

        public string Display
        {
            get => _display;

            set
            {
                _display = value;
                OnPropertyChanged("Display");
            }
        }

        public string Hint
        {
            get => _hint;

            set
            {
                _hint = value;
                OnPropertyChanged("Hint");
            }
        }

        public double Memory
        {
            get => _memory;

            set
            {
                _memory = value;
                OnPropertyChanged("Memory");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
