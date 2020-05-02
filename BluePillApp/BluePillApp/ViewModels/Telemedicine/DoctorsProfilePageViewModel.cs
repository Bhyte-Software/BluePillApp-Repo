using BluePillApp.Models;
using BluePillApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BluePillApp.ViewModels.Telemedicine
{
    public class DoctorsProfilePageViewModel : BaseViewModel
    {
        /// <summary>
        /// This gets the selected/tapped on Doctor
        /// </summary>
        private RecentDoctorsInfo _selectedDoctor;
        public RecentDoctorsInfo SelectedDoctor
        {
            get { return _selectedDoctor; }

            set
            {
                _selectedDoctor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// The original collection of Doctors Info
        /// </summary>
        ObservableCollection<RecentDoctorsInfo> _recentDoctors;
        public ObservableCollection<RecentDoctorsInfo> RecentDoctors
        {
            get { return _recentDoctors; }

            set
            {
                _recentDoctors = value;
                OnPropertyChanged();
            }
        }
    }
}
