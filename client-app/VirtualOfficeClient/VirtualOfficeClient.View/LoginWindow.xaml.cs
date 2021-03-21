﻿using System.Windows;
using VirtualOfficeClient.ViewModel.Auth;


namespace VirtualOfficeClient.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly LoginDataContext viewModel;

        public LoginWindow()
        {
            InitializeComponent();
            this.viewModel = new LoginDataContext();
            this.viewModel.StatusLabel = "Not logged in.";
            this.DataContext = this.viewModel;
        }

    }
}