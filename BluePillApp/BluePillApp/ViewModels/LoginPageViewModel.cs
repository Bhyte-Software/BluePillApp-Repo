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
        public ICommand LoginButtonTappedCommand { get; set; }
        INavigation Navigation;

        public LoginPageViewModel()
        {
            //
        }

        public LoginPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            LoginButtonTappedCommand = //new RelayCommand(async () => await LoginButtonTapped());
                                       new RelayCommand(Next);
        }

        public async Task LoginButtonTapped()
        {
            await Navigation.PushAsync(new MainPage());
            //Application.Current.MainPage = new MainPage();
        }

        public void Next()
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}
