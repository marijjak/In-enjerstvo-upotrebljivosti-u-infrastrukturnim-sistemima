using app_project.Models;
using app_project.Services;
using app_project.Views;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace app_project.Views
{
    public partial class LoginWindow : Window
    {
        private List<User> _users;
        private readonly string _usersFilePath =
            Path.Combine("Data", "users.xml");

        public LoginWindow()
        {
            InitializeComponent();
            _users = XmlService.LoadUsers(_usersFilePath);

           
            UsernameError.Visibility = Visibility.Collapsed;
            PasswordError.Visibility = Visibility.Collapsed;
            CredentialsError.Visibility = Visibility.Collapsed;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            UsernameError.Visibility = Visibility.Collapsed;
            PasswordError.Visibility = Visibility.Collapsed;
            CredentialsError.Visibility = Visibility.Collapsed;

            string username = UsernameTextBox.Text.Trim();
            string password = PasswordBox.Password;

            bool valid = true;

            if (string.IsNullOrEmpty(username))
            {
                UsernameError.Text = "Username is required.";
                UsernameError.Visibility = Visibility.Visible;
                valid = false;
            }

            if (string.IsNullOrEmpty(password))
            {
                PasswordError.Text = "Password is required.";
                PasswordError.Visibility = Visibility.Visible;
                valid = false;
            }

            if (!valid) return;

            User found = _users.Find(u =>
                u.Username == username && u.Password == password);

            if (found == null)
            {
                CredentialsError.Text = "Incorrect username or password.";
                CredentialsError.Visibility = Visibility.Visible;
                return;
            }

            AppSession.CurrentUser = found;
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TitleBar_MouseLeftButtonDown(object sender,
            System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void WindowCloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        
        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(UsernameTextBox.Text))
                UsernameError.Visibility = Visibility.Collapsed;
            CredentialsError.Visibility = Visibility.Collapsed;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(PasswordBox.Password))
                PasswordError.Visibility = Visibility.Collapsed;
            CredentialsError.Visibility = Visibility.Collapsed;
        }
    }
}
