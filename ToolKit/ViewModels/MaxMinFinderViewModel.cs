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
    public class MaxMinFinderViewModel : ViewModelBase
    {
        private bool _isViewVisible = true;
        private string _NumOne;
        private string _NumTwo;
        private string _NumThree;
        private double _Max;
        private double _Min;
        private double _dNumOne, _dNumTwo, _dNumThree;
        public bool IsViewVisible
        {
            get => _isViewVisible; set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }
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
        public string NumThree
        {
            get => _NumThree; set
            {
                _NumThree = value;
                OnPropertyChanged(nameof(NumThree));
            }
        }
        public string Max
        {
            get => _Max.ToString();
            set
            {
                OnPropertyChanged(nameof(Max));
            }
        }
        public string Min
        {
            get => _Min.ToString();
            set
            {
                OnPropertyChanged(nameof(Min));
            }
        }
        public ICommand FindCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand ExitCommand { get; }
        public MaxMinFinderViewModel()
        {
            FindCommand = new ViewModelCommand(p => ExecuteFindCommand());
            ClearCommand = new ViewModelCommand(p => ExecuteClearCommand());
            ExitCommand = new ViewModelCommand(p => ExecuteExitCommand());
        }
        private void ExecuteFindCommand()
        {
            NumOne = NumOne.Replace(" ", "");
            NumTwo = NumTwo.Replace(" ", "");
            NumThree = NumThree.Replace(" ", "");
            if (double.TryParse(NumOne, out _dNumOne) && double.TryParse(NumTwo, out _dNumTwo) && double.TryParse(NumThree, out _dNumThree))
            {
                _Max = Math.Max(_dNumOne, Math.Max(_dNumTwo, _dNumThree));
                _Min = Math.Min(_dNumOne, Math.Min(_dNumTwo, _dNumThree));
                Max = _Max.ToString();
                Min = _Min.ToString();
            }
            else
            {
                MessageBox.Show("Please enter 3 real numbers.");
                Max = "";
                Min = "";
            }
        }

        private void ExecuteExitCommand()
        {
            var dashboard = new Dashboard();
            dashboard.Show();
            IsViewVisible = false;
        }

        private void ExecuteClearCommand()
        {
            Max = "";
            Min = "";
            NumOne = "";
            NumTwo = "";
            NumThree = "";
        }

    }
}
