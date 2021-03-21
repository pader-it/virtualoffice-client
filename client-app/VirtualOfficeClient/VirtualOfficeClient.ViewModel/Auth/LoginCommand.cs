using System;
using System.Windows.Input;

namespace VirtualOfficeClient.ViewModel.Auth
{
    class LoginCommand : ICommand
    {
        private LoginDataContext _viewModel;

        public LoginCommand(LoginDataContext viewModel)
        {
            this._viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._viewModel.DoLogin();
        }
    }
}
