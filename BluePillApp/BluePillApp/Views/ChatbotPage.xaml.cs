using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BluePillApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatbotPage : ContentPage
    {
        public ChatbotPage()
        {
            InitializeComponent();

            Shell.SetTabBarIsVisible(this, false);
        }

        private async void BacktoMain_Button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}