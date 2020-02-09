﻿using BluePillApp.CustomRenderers;
using BluePillApp.Helpers;
using BottomBar.XamarinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BluePillApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : DropshadowShell
    {
        public MainPage()
        {
            InitializeComponent();

            //Remove the navigation bar from NavigationPage
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
