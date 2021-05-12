using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ExcelDataHandler.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            FirstCommand = new RelayCommand(FirstCommandMethod);
            SecondCommand = new RelayCommand(SecondCommandMethod);
        }

        #region Commands
        public ICommand FirstCommand { get; private set; }
        public ICommand SecondCommand { get; private set; }
        #endregion Commands

        private void FirstCommandMethod()
        {
            SomeString = "First button is clicked!";
        }

        private void SecondCommandMethod()
        {
            SomeString = "Second button is clicked!";
        }

        private string _someString = "This is sample of the string";
        public string SomeString 
        { 
            get => _someString;
            set
            {
                _someString = value;
                RaisePropertyChanged(() => SomeString);
            }
        }
    }
}
