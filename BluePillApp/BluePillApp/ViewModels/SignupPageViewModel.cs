using BluePillApp.Helpers;
using BluePillApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BluePillApp.ViewModels
{
    /// <summary>
    /// Viewmodel for SignupPage.xaml
    /// </summary>
    public class SignupPageViewModel : BaseViewModel
    {
        /// <summary>
        /// Text for the First Name entry
        /// </summary>
        private string _firstname;
        public string FirstName
        {
            get
            {
                return _firstname;
            }

            set
            {
                _firstname = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Text for the Last Name entry
        /// </summary>
        private string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }

            set
            {
                _lastname = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Text for the Email entry
        /// </summary>
        private string email;
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Text for the Password entry
        /// </summary>
        private string password;
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Command for signing up a user
        /// </summary>
        public ICommand SignUpCommand { get; set; }

        /// <summary>
        /// Interface for Navigating through pages
        /// </summary>
        public INavigation Navigation { get; set; }

        /// <summary>
        /// Main Constructor
        /// </summary>
        public SignupPageViewModel()
        {
            SignUpCommand = new RelayCommand(SignUp);
        }

        public SignupPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

        /* METHODS */
        private async void SignUp()
        {
            // If the fields are empty
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
            {
                await App.Current.MainPage.DisplayAlert("Empty Values", "Please make sure to fill in all the spaces", "OK");
            }

            else
            {
                var user = await FirebaseHelper.AddUser(FirstName, LastName, Email, Password);

                if (user)
                {
                    await App.Current.MainPage.DisplayAlert("SignUp Success", "", "Ok");

                    //Navigate to MainPage    
                    Application.Current.MainPage = new MainPage(); // Make this asynchronous

                    Email = string.Empty;
                    Password = string.Empty;
                    FirstName = string.Empty;
                    LastName = string.Empty;
                }

                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "We ran into an error whiles signing up, please check your network", "OK");
                }
            }
        }
    }
}
