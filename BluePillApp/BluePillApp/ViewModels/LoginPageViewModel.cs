using BluePillApp.Helpers;
using BluePillApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BluePillApp.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        /// <summary>
        /// Text for the Password entry
        /// </summary>
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Text for the Password entry
        /// </summary>
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// The command for the login button
        /// </summary>
        public ICommand LoginButtonTappedCommand { get; set; }

        /// <summary>
        /// Interface for Navigating between pages
        /// </summary>
        INavigation Navigation;

        public LoginPageViewModel()
        {
            //
        }

        public LoginPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            LoginButtonTappedCommand = new RelayCommand(Next);
        }

        /* METHODS */
        public async void Next()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Test", "Fill in all fields", "OK");
            }

            else
            {
                //call GetUser function which we define in FirebaseHelper
                var user = await FirebaseHelper.GetUser(Email, Password);
                
                if (user != null)
                    if (Email == user.Email && Password == user.Password)
                    {
                        await App.Current.MainPage.DisplayAlert("Login Success", "", "Ok");
                        Application.Current.MainPage = new MainPage();
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
                    }

                else
                {
                    await App.Current.MainPage.DisplayAlert("Login Fail", "User not found", "OK");
                }
            }
        }
    }
}
