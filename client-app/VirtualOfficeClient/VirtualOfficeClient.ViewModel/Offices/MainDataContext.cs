using System.ComponentModel;
using System.Windows.Input;
using VirtualOfficeClient.Model.Offices;
using VirtualOfficeClient.ViewModel.Offices.Commands;

namespace VirtualOfficeClient.ViewModel.Offices
{
    public class MainDataContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        internal UserContext UserContext;


        private EnterOfficeCommand _enterOfficeCommand;
        private LeaveOfficeCommand _leaveOfficeCommand;


        public ICommand EnterOfficeCommand => this._enterOfficeCommand;
        public ICommand LeaveOfficeCommand => this._leaveOfficeCommand;

        public bool UserIsInOffice => this.UserContext.CurrentOfficeId.HasValue;


        private string _officeIdInputString = "";
        public string OfficeIdInputString
        {
            get
            {
                return _officeIdInputString;
            }
            set
            {
                _officeIdInputString = value;
                RaisePropertyChanged(nameof(OfficeIdInputString));
            }
        }

        public long? OfficeIdInputValue { get; private set; }

        public string CurrentOfficeName
        {
            get
            {
                if (this.UserContext.CurrentOfficeId.HasValue)
                    return this.UserContext.CurrentOfficeId.ToString();
                else
                    return "None";
            }   
        }

        public MainDataContext(UserContext context)
        {
            this.UserContext = context;
            this._enterOfficeCommand = new EnterOfficeCommand(context);
            this._enterOfficeCommand.CurrentOfficeChanged += CurrentOfficeChanged;
            this._leaveOfficeCommand = new LeaveOfficeCommand(context);
            this._leaveOfficeCommand.CurrentOfficeChanged += CurrentOfficeChanged;
        }

        private void CurrentOfficeChanged(object sender, System.EventArgs e)
        {
            this._enterOfficeCommand.RaiseCanExecuteChanged();
            this._leaveOfficeCommand.RaiseCanExecuteChanged();
            this.RaisePropertyChanged(nameof(UserIsInOffice));
            this.RaisePropertyChanged(nameof(CurrentOfficeName));
        }

        private void RaisePropertyChanged(string propertyName) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
