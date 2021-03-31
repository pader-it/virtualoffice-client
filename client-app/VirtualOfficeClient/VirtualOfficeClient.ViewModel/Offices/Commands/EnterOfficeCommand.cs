using System;
using System.Windows.Input;
using VirtualOfficeClient.Model.Offices;

namespace VirtualOfficeClient.ViewModel.Offices.Commands
{
    internal class EnterOfficeCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public event EventHandler CurrentOfficeChanged;

        private UserContext _context;

        internal EnterOfficeCommand(UserContext context)
        {
            this._context = context;
        }

        public bool CanExecute(object parameter)
        {
            return !this._context.CurrentOfficeId.HasValue;
        }

        public void Execute(object parameter)
        {
            string officeIdString = parameter as string;

            if(long.TryParse(officeIdString, out var officeId))
            {
                this.EnterOffice(officeId);
            }
        }

        private async void EnterOffice(long officeId)
        {
            var enterOfficeSuccess = await this._context.EnterOffice(officeId);

            if (enterOfficeSuccess)
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
