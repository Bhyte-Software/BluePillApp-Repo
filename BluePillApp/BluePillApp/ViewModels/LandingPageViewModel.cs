using BluePillApp.ViewModels.Base;
using BluePillApp.Views;
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
        public ICommand OpenLoginPageCommand { get; set; }
        INavigation Navigation;

        public LandingPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            OpenLoginPageCommand = new RelayCommand(async () => await OpenLoginPage());
        }

        public async Task OpenLoginPage()
        {
            await Navigation.PushAsync(new LoginPage(), true);
        }
    }
}
