using BluePillApp.Models;
using BluePillApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BluePillApp.ViewModels.Tabs
{
    public class UPPViewModel : BaseViewModel
    {
        /// <summary>
        /// Collection of settings
        /// </summary>
        public ObservableCollection<SettingsOptions> OtherOptions { get; set; }

        /// <summary>
        /// Constructor for the class
        /// </summary>
        public UPPViewModel()
        {
            OtherOptions = new ObservableCollection<SettingsOptions>(); // Instance of OtherOptions

            //Added Items/Options
            OtherOptions.Add(new SettingsOptions("Settings"));
            OtherOptions.Add(new SettingsOptions("Help Center"));
            OtherOptions.Add(new SettingsOptions("About Us"));
            OtherOptions.Add(new SettingsOptions("Privacy Policy"));
            OtherOptions.Add(new SettingsOptions("Send Feedback"));
        }
    }
}
