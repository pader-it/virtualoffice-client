using System.ComponentModel;
using System.Windows.Input;
using VirtualOfficeClient.Model.Auth;
using VirtualOfficeClient.Model.Offices;
using VirtualOfficeClient.ViewModel.Offices;

namespace VirtualOfficeClient.ViewModel.Auth
{
    public class LoginDataContext : INotifyPropertyChanged
    {
        private int _lastResponseCode = -1;

        private string _statusLabel = "Not logged in.";
        public string StatusLabel
        {
            get
            {
                return _statusLabel;
            }
            set
            {
                this._statusLabel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StatusLabel"));
            }
        }

        private ICommand _loginCommand = null;
        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                    _loginCommand = new LoginCommand(this);

                return _loginCommand;
            }
        }


        public string Username { get; set; }

        public string Password { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public async void DoLogin()
        {
            this.StatusLabel = "Performing Login Operation...";
            this._lastResponseCode = await LoginHelper.PerformLogin(this.Username, this.Password);
            this.UpdateStatusLabel();

            if(this._lastResponseCode == 200)
            {
                HandleLoginSuccess();
            }
        }

        private void HandleLoginSuccess()
        {
            var userContext = new UserContext();
            var mainDataContext = new MainDataContext(userContext);
            //TODO: Open new Window
        }

        private void UpdateStatusLabel()
        {
            this.StatusLabel = this._lastResponseCode switch
            {
                -1 => "Not logged in.",
                0 => "Server unreachable.",
                200 => "Login successful!",
                401 => "Invalid credentials supplied.",
                500 => "Unexpected server error.",
                _ => $"An unknown error occurred during login, error code {this._lastResponseCode}",
            };
        }
    }
}
