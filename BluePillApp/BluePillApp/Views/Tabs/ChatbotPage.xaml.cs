using BluePillApp.Controls;
using BluePillApp.Models;
using BluePillApp.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BluePillApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatbotPage : ContentPage
    {
        ChatbotPageViewModel chatbotpageVM = new ChatbotPageViewModel();

        public ChatbotPage()
        {
            InitializeComponent();

            BindingContext = chatbotpageVM;

            //Sets the top tab bar invisible
            Shell.SetTabBarIsVisible(this, false);
        }
    }
}