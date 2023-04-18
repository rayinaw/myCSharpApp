using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToolKit.Views;

namespace ToolKit.ViewModels 
{
    public class CalculatorViewModel: ViewModelBase
    {
        private bool _isViewVisible = true;
        private string _NumOne;
        private string _NumTwo;
        private int _iNumOne;
        private int _iNumTwo;
        private double _result;

        public string NumOne
        {
            get => _NumOne; set
            {
                _NumOne = value;
                OnPropertyChanged(nameof(NumOne));
            }
        }

        public string NumTwo
        {
            get => _NumTwo; set
            {
                _NumTwo = value;
                OnPropertyChanged(nameof(NumTwo));
            }
        }

        public string Result
        {
            get => _result.ToString(); set
            {
                double.TryParse(value, out _result);
                OnPropertyChanged(nameof(Result));
            }
        }
        public bool IsViewVisible
        {
            get => _isViewVisible; set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }
        public ICommand AddCommand { get; }
        public ICommand SubtractCommand { get; }
        public ICommand MultiplyCommand { get; }
        public ICommand DivideCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand ExitCommand { get; }
        public CalculatorViewModel()
        {
            AddCommand = new ViewModelCommand(ExecuteAddCommand, CanExecuteCommand);
            SubtractCommand = new ViewModelCommand(ExecuteSubtractCommand, CanExecuteCommand);
            MultiplyCommand = new ViewModelCommand(ExecuteMultiplyCommand, CanExecuteCommand);
            DivideCommand = new ViewModelCommand(ExecuteDivideCommand, CanExecuteDivideCommand);
            ClearCommand = new ViewModelCommand(p => ExecuteClearCommand());
            ExitCommand = new ViewModelCommand(p => ExecuteExitCommand());
        }

        private bool CanExecuteDivideCommand(object obj)
        {
            bool validInput = false;
            if (NumTwo != null && NumOne!= null)
            {
                NumTwo = NumTwo.Replace(" ", "");
                NumOne = NumOne.Replace(" ", "");
                if (int.TryParse(NumTwo, out _iNumTwo) && int.TryParse(NumOne, out _iNumOne))
                {
                    validInput = true;
                }
                else
                {
                    validInput = false;
                }
                return validInput;
            }
            else
            {
                return validInput;
            }

        }
        private bool CanExecuteCommand(object obj)
        {
            bool validInput = false;

            if (NumOne != null && NumTwo != null)
            {
                NumOne = NumOne.Replace(" ", "");
                NumTwo = NumTwo.Replace(" ", "");
                if (int.TryParse(NumOne, out _iNumOne) && int.TryParse(NumTwo, out _iNumTwo))
                    validInput = true;
                return validInput;
            }
            else
            {
                return validInput;
            }
        }

        private void ExecuteDivideCommand(object obj)
        {
            if (_iNumTwo == 0)
            {
                MessageBox.Show("The divisor must be Nonzero");
                Result = 0.ToString();
            }
            else
            {
                _result = Convert.ToDouble(_iNumOne) / Convert.ToDouble(_iNumTwo);
                Result = _result.ToString();
            }

        }

        private void ExecuteMultiplyCommand(object obj)
        {
            _result = _iNumOne * _iNumTwo;
            Result = _result.ToString();
        }

        private void ExecuteSubtractCommand(object obj)
        {
            _result = _iNumOne - _iNumTwo;
            Result = _result.ToString();
        }

        private void ExecuteAddCommand(object obj)
        {
            _result = _iNumOne + _iNumTwo;
            Result = _result.ToString();
        }


        

        private void ExecuteExitCommand()
        {
            var dashboard = new Dashboard();
            dashboard.Show();
            IsViewVisible = false;
        }

        private void ExecuteClearCommand()
        {
            Result = "";
            NumTwo = "";
            NumOne = "";
        }

    }
}
