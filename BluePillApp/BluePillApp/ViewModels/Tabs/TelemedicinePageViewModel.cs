using BluePillApp.Models;
using BluePillApp.ViewModels.Base;
using BluePillApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

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

        /// <summary>
        /// Command for navigating to the search page
        /// </summary>
        public ICommand GoToSearchPageCommand { get; set; }
        #endregion

        /// <summary>
        /// Main Constructor for the class
        /// </summary>
        public TelemedicinePageViewModel()
        {
            AddDoctorCommand = new RelayCommand(AddDoctor);
            GoToSearchPageCommand = new RelayCommand(async () => await GoToSearchPage());

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
            //RecentDoctors.Add(new RecentDoctorsInfo() 
            //{ 
            //    DoctorsName = "Steven Strange",
            //    Specialization = "Sorcerer Supreme",
            //    Location = "177a Bleecker St. | USA"
            //});
        }

        public async Task GoToSearchPage()
        {
            await Shell.Current.Navigation.PushModalAsync(new TelemedSearchPage(), true);
        }
        #endregion
    }
}
