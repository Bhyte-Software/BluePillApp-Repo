using BluePillApp.ViewModels.Tabs;
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
    public partial class TelemedicineMainPage : ContentPage
    {
        public TelemedicineMainPage()
        {
            InitializeComponent();

            BindingContext = new TelemedicinePageViewModel();
        }
    }
}