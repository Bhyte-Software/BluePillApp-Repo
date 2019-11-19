using BluePillApp.ViewModels;
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

            BindingContext = new ChatbotPageViewModel();

            //Sets the top tab bar invisible
            Shell.SetTabBarIsVisible(this, false);
        }

        private void BacktoMain_Button(object sender, EventArgs e)
        {
            TabBar bar = Shell.Current.Items[0] as TabBar;

            //Select the first Tab
            bar.CurrentItem = bar.Items[0];
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
        }
    }
}