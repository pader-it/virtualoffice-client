using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualOfficeClient.ViewModel.Windows
{
    public interface INextWindowBuilder
    {
        public void ShowNextWindow(object DataContext);
    }
}
