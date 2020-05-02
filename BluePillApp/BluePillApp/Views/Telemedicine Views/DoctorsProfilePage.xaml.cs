using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BluePillApp.Views.Telemedicine_Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DoctorsProfilePage : ContentPage
    {
        public DoctorsProfilePage()
        {
            InitializeComponent();

            //Shell.SetTabBarIsVisible(this, false);
        }
    }
}