using System;
using System.Windows.Input;
using VirtualOfficeClient.Model.Offices;

namespace VirtualOfficeClient.ViewModel.Offices.Commands
{
    internal class LeaveOfficeCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public event EventHandler CurrentOfficeChanged;

        private UserContext _context;

        internal LeaveOfficeCommand(UserContext context)
        {
            this._context = context;
        }

        public bool CanExecute(object parameter)
        {
            return this._context.CurrentOfficeId.HasValue;
        }

        public void Execute(object parameter)
        {
            this.LeaveOffice();
        }

        private async void LeaveOffice()
        {
            var leaveOfficeSuccess = await this._context.LeaveCurrentOffice();

            if (leaveOfficeSuccess)
            {
                this.RaiseCanExecuteChanged();
                this.RaiseOfficeChanged();
            }
                
        }

        internal void RaiseCanExecuteChanged() =>
            this.CanExecuteChanged?.Invoke(this, new EventArgs());

        private void RaiseOfficeChanged() =>
            this.CurrentOfficeChanged?.Invoke(this, new EventArgs());
    }
}
