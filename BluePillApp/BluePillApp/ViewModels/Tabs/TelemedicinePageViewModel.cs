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
        #region PROPERTIES
        /// <summary>
        /// Collection of RecentDoctorsInfo
        /// </summary>
        public ObservableCollection<RecentDoctorsInfo> RecentDoctors { get; set; } = new ObservableCollection<RecentDoctorsInfo>();

        /// <summary>
        /// Collection of MyDoctorsInfo
        /// </summary>
        public ObservableCollection<MyDoctorsInfo> MyDoctors { get; set; } = new ObservableCollection<MyDoctorsInfo>();

        /// <summary>
        /// Command for adding new 
        /// </summary>
        public ICommand AddDoctorCommand { get; set; }
        #endregion

        /// <summary>
        /// Main Constructor for the class
        /// </summary>
        public TelemedicinePageViewModel()
        {
            AddDoctorCommand = new RelayCommand(AddDoctor);

            MyDoctors.Add(new MyDoctorsInfo()
            {
                None = "none"
            });
            MyDoctors.Add(new MyDoctorsInfo()
            {
                None = "none"
            });
            MyDoctors.Add(new MyDoctorsInfo()
            {
                None = "none"
            });
            MyDoctors.Add(new MyDoctorsInfo()
            {
                None = "none"
            });
            MyDoctors.Add(new MyDoctorsInfo()
            {
                None = "none"
            });
            MyDoctors.Add(new MyDoctorsInfo()
            {
                None = "none"
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
