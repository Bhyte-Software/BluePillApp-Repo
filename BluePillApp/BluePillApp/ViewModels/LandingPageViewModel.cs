using BluePillApp.ViewModels.Base;
using BluePillApp.Views;
using BluePillApp.Views.Signup_Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BluePillApp.ViewModels
{
    public class LandingPageViewModel : BaseViewModel
    {
        /// <summary>
        /// Command for opening the Login page
        /// </summary>
        public ICommand OpenLoginPageCommand { get; set; }

        /// <summary>
        /// Command for opening the first Signup page
        /// </summary>
        public ICommand CreateNewAccountCommand { get; set; }

        /// <summary>
        /// Interface for navigation in Xamarin.Forms
        /// </summary>
        INavigation Navigation;

        /// <summary>
        /// Main class constructor
        /// </summary>
        public LandingPageViewModel()
        {
            //
        }

        /// <summary>
        /// Class constructor for navigation
        /// </summary>
        /// <param name="navigation"></param>
        public LandingPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            OpenLoginPageCommand = new RelayCommand(async () => await OpenLoginPage());
            CreateNewAccountCommand = new RelayCommand(async () => await OpenSignupPage());
        }

        // An asyncronous task for opening LoginPage
        public async Task OpenLoginPage()
        {
            await Navigation.PushAsync(new LoginPage(), true);
        }

        // An asyncronous task for opening SignupPage
        public async Task OpenSignupPage()
        {
            await Navigation.PushAsync(new SignupPage(), true);
        }
    }
}
