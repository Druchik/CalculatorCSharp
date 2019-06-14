using CalculatorCSharp.Cmds;
using CalculatorCSharp.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CalculatorCSharp.ViewModel
{
    class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public IList<string> Journal { get; set; }

        public IList<string> MemoryList { get; set; }

        private Data _data = new Data();

        public Data Data
        {
            get => _data;
            set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }

        public MainVM()
        {
            Journal = new ObservableCollection<string>();
            MemoryList = new ObservableCollection<string>();
        }

        private ICommand _btnDigitClickCommand = null;
        public ICommand BtnDigitClickCmd => _btnDigitClickCommand ?? (_btnDigitClickCommand = new BtnDigitClickCommand(Data));

        private ICommand _btnArithOpClickCommand = null;
        public ICommand BtnArithOpClickCmd => _btnArithOpClickCommand ?? (_btnArithOpClickCommand = new BtnArithOpClickCommand(Data));

        private ICommand _btnResultClickCommand = null;
        public ICommand BtnResultClickCmd => _btnResultClickCommand ?? (_btnResultClickCommand = new BtnResultClickCommand(Data, Journal));

        private ICommand _btnBckSpcClickCommand = null;
        public ICommand BtnBckSpcClickCmd => _btnBckSpcClickCommand ?? (_btnBckSpcClickCommand = new BtnBckSpcClickCommand(Data));

        private ICommand _btnCleanClickCommand = null;
        public ICommand BtnCleanClickCmd => _btnCleanClickCommand ?? (_btnCleanClickCommand = new BtnCleanClickCommand(Data));

        private ICommand _btnCleanEntryClickCommand = null;
        public ICommand BtnCleanEntryClickCmd => _btnCleanEntryClickCommand ?? (_btnCleanEntryClickCommand = new BtnCleanEntryClickCommand(Data));

        private ICommand _btnDotClickCommand = null;
        public ICommand BtnDotClickCmd => _btnDotClickCommand ?? (_btnDotClickCommand = new BtnDotClickCommand(Data));

        private ICommand _btnNegativeClickCommand = null;
        public ICommand BtnNegativeClickCmd => _btnNegativeClickCommand ?? (_btnNegativeClickCommand = new BtnNegativeClickCommand(Data));

        private ICommand _btnSqrtClickCommand = null;
        public ICommand BtnSqrtClickCmd => _btnSqrtClickCommand ?? (_btnSqrtClickCommand = new BtnSqrtClickCommand(Data, Journal));

        private ICommand _btnSqrClickCommand = null;
        public ICommand BtnSqrClickCmd => _btnSqrClickCommand ?? (_btnSqrClickCommand = new BtnSqrClickCommand(Data, Journal));

        private ICommand _btnCubeClickCommand = null;
        public ICommand BtnCubeClickCmd => _btnCubeClickCommand ?? (_btnCubeClickCommand = new BtnCubeClickCommand(Data, Journal));

        private ICommand _btnDivXClickCommand = null;
        public ICommand BtnDivXClickCmd => _btnDivXClickCommand ?? (_btnDivXClickCommand = new BtnDivXClickCommand(Data, Journal));

        private ICommand _btnPercentClickCommand = null;
        public ICommand BtnPercentClickCmd => _btnPercentClickCommand ?? (_btnPercentClickCommand = new BtnPercentClickCommand(Data));

        private ICommand _addMemoryCommand = null;
        public ICommand AddMemoryCmd => _addMemoryCommand ?? (_addMemoryCommand = new AddMemoryCommand(Data, MemoryList));

        private ICommand _clearMemoryCommand = null;
        public ICommand ClearMemoryCmd => _clearMemoryCommand ?? (_clearMemoryCommand = new ClearMemoryCommand(Data, MemoryList));

        private ICommand _readMemoryCommand = null;
        public ICommand ReadMemoryCmd => _readMemoryCommand ?? (_readMemoryCommand = new ReadMemoryCommand(Data, MemoryList));

        private ICommand _subMemoryCommand = null;
        public ICommand SubMemoryCmd => _subMemoryCommand ?? (_subMemoryCommand = new SubMemoryCommand(Data, MemoryList));

        private ICommand _saveMemoryCommand = null;
        public ICommand SaveMemoryCmd => _saveMemoryCommand ?? (_saveMemoryCommand = new SaveMemoryCommand(Data, MemoryList));

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
