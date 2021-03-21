using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VirtualOffice.RestApiClient.Api;
using VirtualOffice.RestApiClient.Client;
using VirtualOfficeClient.ViewModel;

namespace VirtualOfficeClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly IUserManagementApi userApi;
        private readonly LoginDataContext viewModel;


        public MainWindow()
        {
            InitializeComponent();
            this.viewModel = new LoginDataContext();
            this.viewModel.StatusLabel = "Not logged in.";
            this.DataContext = this.viewModel;

            this.userApi = new UserManagementApi();
            this.userApi.Configuration.BasePath = "http://localhost:8080/";
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel.StatusLabel = "Attempting Login...";
            
            this.userApi.Configuration.Username = this.Input_UserName.Text;
            this.userApi.Configuration.Password = this.Input_Password.Text;
            var task = this.userApi.LoginAsyncWithHttpInfo();
            this.handleLoginTask(task);
        }

        private async void handleLoginTask(Task<VirtualOffice.RestApiClient.Client.ApiResponse<object>> task)
        {
            try
            {
                await task;
                if (task.IsCompletedSuccessfully)
                {
                    this.viewModel.StatusLabel = "Successful Login!";
                }
                else
                {
                    this.viewModel.StatusLabel = "Login not succesfull!";
                }
            }
            catch (ApiException apiX)
            {
                switch (apiX.ErrorCode)
                {
                    case 401:
                        this.viewModel.StatusLabel = "Login failed, invalid credentials supplied (401)";
                        break;
                    case 500:
                        this.viewModel.StatusLabel = $"Serverfehler: {apiX.Message}";
                        break;
                    default:
                        this.viewModel.StatusLabel = $"Unknown HTTP Error Code {apiX.ErrorCode}: {apiX.Message}";
                        break;
                }
            }
            
        }
    }
}
