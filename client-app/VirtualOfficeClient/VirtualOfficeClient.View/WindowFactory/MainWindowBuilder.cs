using System.Windows;
using VirtualOfficeClient.ViewModel.Windows;

namespace VirtualOfficeClient.View.WindowFactory
{
    internal class MainWindowBuilder : INextWindowBuilder
    {

        private readonly Window _currentWindow;

        internal MainWindowBuilder(LoginWindow CurrentWindow)
        {
            _currentWindow = CurrentWindow;
        }

        public void ShowNextWindow(object DataContext)
        {
            var mainWindow = new MainWindow();
            mainWindow.DataContext = DataContext;
            mainWindow.Show();

            this._currentWindow.Close();
        }
    }
}
