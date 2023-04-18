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
    public class NumberToWordConverterViewModel : ViewModelBase
    {

        static string NumberToText(int number)
        {
            if (number == 0) return "Không";

            string[] ones =
            {
            "", "Một", "Hai", "Ba", "Bốn", "Năm",
            "Sáu", "Bảy", "Tám", "Chín", "Mười",
        };

            string[] thousands =
            {
            "", "Nghìn", "Triệu", "Tỷ"
        };

            int[] groups = new int[4];
            for (int i = 0; i < 4 && number > 0; i++)
            {
                groups[i] = number % 1000;
                number /= 1000;
            }

            string text = "";
            for (int i = 3; i >= 0; i--)
            {
                int group = groups[i];
                if (group == 0) continue;

                int hundreds = group / 100;
                int tens = group % 100 / 10;
                int onesDigit = group % 10;

                if (hundreds > 0)
                {
                    text += ones[hundreds] + " Trăm ";
                }

                if (tens == 0 && onesDigit > 0)
                {
                    text += "" + ones[onesDigit] + " ";
                }
                else if (tens == 1)
                {
                    text += "Mười " + ones[onesDigit] + " ";
                }
                else if (tens > 1)
                {
                    text += ones[tens] + " Mươi ";
                    if (onesDigit > 0)
                    {
                        text += ones[onesDigit] + " ";
                    }
                }

                text += thousands[i] + " ";
            }

            return text.Trim();
        }
        private string _result;
        private string _UserInput;
        private int _iUserInput;
        private bool _isViewVisible = true;
        public string UserInput
        {
            get => _UserInput; set
            {
                _UserInput = value;
                OnPropertyChanged(nameof(UserInput));
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
        public string Result
        {
            get => _result; set
            {
                OnPropertyChanged(nameof(Result));
            }
        }
        public ICommand ConvertCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand ExitCommand { get; }
        public NumberToWordConverterViewModel()
        {
            ConvertCommand = new ViewModelCommand(p => ExecuteConvertCommand());
            ClearCommand = new ViewModelCommand(p => ExecuteClearCommand());
            ExitCommand = new ViewModelCommand(p => ExecuteExitCommand());
        }

        private void ExecuteExitCommand()
        {
            var dashboard = new Dashboard();
            dashboard.Show();
            IsViewVisible = false;
        }

        private void ExecuteClearCommand()
        {
            UserInput = "";
            Result = "";
        }

        private void ExecuteConvertCommand()
        {
            UserInput = UserInput.Replace(" ", "");
            if (int.TryParse(UserInput, out _iUserInput))
            {

                _result = NumberToText(_iUserInput);
                Result = _result;
            }
            else
            {
                MessageBox.Show("Please enter an Integer.");
            }
        }
    }
}
