using BluePillApp.Models;
using BluePillApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace BluePillApp.ViewModels.Tabs
{
    public class TelemedicinePageViewModel : BaseViewModel
    {
        /// <summary>
        /// Collection of RecentDoctorsIfo
        /// </summary>
        public ObservableCollection<RecentDoctorsInfo> RecentDoctors { get; set; } = new ObservableCollection<RecentDoctorsInfo>();

        /// <summary>
        /// To show whether the user has any doctors on his recent list
        /// </summary>
        public bool HasAnyRecents { get; set; }

        public ICommand AddDoctorCommand { get; set; }

        /// <summary>
        /// Main Constructor for the class
        /// </summary>
        public TelemedicinePageViewModel()
        {
            AddDoctorCommand = new RelayCommand(AddDoctor);

            RecentDoctors.Add(new RecentDoctorsInfo()
            {
                DoctorsName = "Steven Strange",
                Specialization = "Sorcerer Supreme",
                Location = "177a Bleecker St. | USA"
            });
        }

        #region METHODS

        public void AddDoctor()
        {
            RecentDoctors.Add(new RecentDoctorsInfo() 
            { 
                DoctorsName = "Steven Strange",
                Specialization = "Sorcerer Supreme",
                Location = "177a Bleecker St. | USA"
            });
        }
        #endregion
    }
}
