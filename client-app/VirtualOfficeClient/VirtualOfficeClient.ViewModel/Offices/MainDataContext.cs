using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using VirtualOfficeClient.Model.Offices;

namespace VirtualOfficeClient.ViewModel.Offices
{
    public class MainDataContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private UserContext _userContext;

        public MainDataContext(UserContext context)
        {
            this._userContext = context;
        }
    }
}
