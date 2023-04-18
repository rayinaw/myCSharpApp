using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToolKit.Views;

namespace ToolKit.ViewModels
{
    public class BaseConverterViewModel : ViewModelBase
    {
        private string _result;
        private string _UserInput;
        private bool _isViewVisible = true;
        private string _FromBase;
        private string _ToBase;

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
        public string FromBase
        {
            get => _FromBase; set
            {
                _FromBase = value;
                OnPropertyChanged(nameof(FromBase));
            }
        }
        public string ToBase
        {
            get => _ToBase; set
            {
                _ToBase = value;
                OnPropertyChanged(nameof(ToBase));
            }
        }
        public string Result
        {
            get => _result; set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }
        public int SelectedFromIndex { get; set; }
        public int SelectedToIndex { get; set; }


        public ObservableCollection<string> Bases { get; }
        public ICommand ConvertCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand ExitCommand { get; }
        public BaseConverterViewModel() {
            Bases = new ObservableCollection<string> { "Decimal", "Hex", "Binary" };
            ConvertCommand = new ViewModelCommand(p => ExecuteConvertCommand());
            ClearCommand = new ViewModelCommand(p => ExecuteClearCommand());
            ExitCommand = new ViewModelCommand(p => ExecuteExitCommand());
            SelectedFromIndex = 0;
            SelectedToIndex = 2;
            ToBase = Bases[SelectedToIndex];
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

            if (string.IsNullOrEmpty(UserInput))
            {
                Result = "";
                return;
            }

            bool isValidInput = true;
            int inputValue = 0;

            // Validate user input
            switch (FromBase)
            {
                case "Decimal":
                    isValidInput = int.TryParse(UserInput, out inputValue);
                    break;
                case "Hex":
                    isValidInput = int.TryParse(UserInput, System.Globalization.NumberStyles.HexNumber, null, out inputValue);
                    break;
                case "Binary":
                    isValidInput = UserInput.All(c => c == '0' || c == '1');
                    if (isValidInput)
                    {
                        inputValue = Convert.ToInt32(UserInput, 2);
                    }
                    break;
            }

            // Convert the input value to the desired base
            if (isValidInput)
            {
                switch (ToBase)
                {
                    case "Decimal":
                        Result = inputValue.ToString();
                        break;
                    case "Hex":
                        Result = "0x" + inputValue.ToString("X");
                        break;
                    case "Binary":
                        Result = Convert.ToString(inputValue, 2);
                        break;
                }
            }
            else
            {
                // Show an error message if input is invalid
                Result = "Invalid input";
            }

        }
    }
}
