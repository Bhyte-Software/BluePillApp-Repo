using System;
using System.Collections.Generic;
using System.Text;

namespace BluePillApp.Models
{
    public class SettingsOptions
    {
        public string Option { get; set; }

        public SettingsOptions(string option)
        {
            Option = option;
        }
    }
}
