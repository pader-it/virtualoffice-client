using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VirtualOfficeClient.ViewModel
{
    class LoginDataContext : INotifyPropertyChanged
    {

        private String _statusLabel = "status";
        public String StatusLabel
        {
            get
            {
                return _statusLabel;
            }
            set
            {
                this._statusLabel = value;
                if(PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("statusLabel"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
