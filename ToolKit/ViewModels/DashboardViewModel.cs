using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToolKit.Views;

namespace ToolKit.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        private bool _isViewVisible = true;

        public bool IsViewVisible
        {
            get => _isViewVisible; set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }
        public ICommand OpenCalculatorCommand { get; }
        public ICommand OpenGradeTrackerCommand { get; }
        public ICommand OpenMaxMinFinderCommand { get; }
        public ICommand OpenNumberToWordConverterCommand { get; }
        public ICommand OpenBaseConverterCommand { get; }
        public DashboardViewModel()
        {
            OpenCalculatorCommand = new ViewModelCommand(p => ExecuteOpenCalculatorCommand());
            OpenGradeTrackerCommand = new ViewModelCommand(p => ExecuteOpenGradeTrackerCommand());
            OpenMaxMinFinderCommand = new ViewModelCommand(p => ExecuteOpenMaxMinFinderCommand());
            OpenNumberToWordConverterCommand = new ViewModelCommand(p => ExecuteOpenNumberToWordConverterCommand());
            OpenBaseConverterCommand = new ViewModelCommand(p => ExecuteOpenBaseConverterCommand());
        }

        private void ExecuteOpenBaseConverterCommand()
        {
            var baseConverter = new BaseConverter();
            baseConverter.Show();
            IsViewVisible = false;
        }

        private void ExecuteOpenNumberToWordConverterCommand()
        {
            var numberToWordConverter = new NumberToWordConverter();
            numberToWordConverter.Show();
            IsViewVisible = false;
        }

        private void ExecuteOpenMaxMinFinderCommand()
        {
            var maxMinFinder = new MaxMinFinder();
            maxMinFinder.Show();
            IsViewVisible = false;
        }

        private void ExecuteOpenGradeTrackerCommand()
        {
            var gradeTracker = new GradeTracker();
            gradeTracker.Show();
            IsViewVisible = false;
        }

        private void ExecuteOpenCalculatorCommand()
        { 
            var calculator = new Calculator();
            calculator.Show();
            IsViewVisible = false;
        }

    }
}
