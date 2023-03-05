using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Input;
using System.Xml.Linq;
using appCV.Models;

namespace appCV.ViewModels
{
    public class ValidationViewModel: ViewModelBase
    {
        private string _userAnswer;
        private int _iUserAnswer;
        private int _result;
        private string _error;
        private string _errorMessage;
        private bool _isViewVisible = true;
        private string _txtQuestion;
        QuestionModel questionModel;

        public string UserAnswer { 
            get => _userAnswer; set
            {
                _userAnswer = value;
                OnPropertyChanged(nameof(UserAnswer));
            }
        }

        public string TxtQuestion
        {
            get => _txtQuestion; set
            {
                _txtQuestion = value;
                OnPropertyChanged(nameof(TxtQuestion));
            }
        }
        public string Error { get => _error; set
            {
                _error = value;
                OnPropertyChanged(nameof(Error));
            }
        }
        public string ErrorMessage { get => _errorMessage; set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public bool IsViewVisible { get => _isViewVisible; set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }
        //-> Commands
        public ICommand CheckResultCommand { get; }
        public ICommand ShowCalculatorCommand { get; }

        public ValidationViewModel()
        {
            CheckResultCommand = new ViewModelCommand(ExcecuteCheckResultCommand, CanExecuteCheckResultCommand);
            ShowCalculatorCommand = new ViewModelCommand(p => ExecuteShowCalculatorCommand());
            questionModel = new QuestionModel();
            questionModel.TwoDigitCalculation();
            _txtQuestion = questionModel.TxtQuestion;
            _result=questionModel.Result;
        }
        private bool CanExecuteCheckResultCommand(object obj)
        {
            bool validInput=false;

            if (_userAnswer != null)
            {
                _userAnswer = _userAnswer.Replace(" ", "");
                if (int.TryParse(_userAnswer, out _iUserAnswer))
                    validInput = true;
                else
                    validInput = false;
                return validInput;
            }
            else
            {
                return validInput;
            }
            
        }

        private async void ExcecuteCheckResultCommand(object obj)
        {
            if(_iUserAnswer == _result)
            {
                ErrorMessage = "Congratulations! Please wait for some information about me...<3";
                await Task.Delay(2000);
                ErrorMessage = "";
                IsViewVisible = false;
            }
            else
            {
                ErrorMessage = "Please verify you're not a robot :<";
                await Task.Delay(2000);
                ErrorMessage = "";
            }
        }

        private void ExecuteShowCalculatorCommand()
        {
            Process.Start("calc.exe");
        }

    }

}
