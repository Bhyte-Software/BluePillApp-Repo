using BluePillApp.Models;
using BluePillApp.ViewModels.Base;
using BluePillApp.Views;
using BluePillApp.Views.Telemedicine_Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace BluePillApp.ViewModels
{
    public class TelemedSearchPageViewModel : BaseViewModel
    {
        #region PROPERTIES
        /// <summary>
        /// The text input of the SearchBar
        /// </summary>
        private string _searchedText;
        public string SearchedText
        {
            get { return _searchedText; }

            set
            {
                _searchedText = value;
                OnPropertyChanged();
                Search();
            }
        }

        /// <summary>
        /// 
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
        public ObservableCollection<RecentDoctorsInfo> RecentDoctors { get; set; } = new ObservableCollection<RecentDoctorsInfo>();

        /// <summary>
        /// The replicated collection of Doctors Info used as search results
        /// </summary>
        public ObservableCollection<RecentDoctorsInfo> SearchResults { get; set; } = new ObservableCollection<RecentDoctorsInfo>();
        #endregion

        #region COMMANDS
        public ICommand SearchBarCommand { get; set; }
        #endregion

        /// <summary>
        /// Main Constructor
        /// </summary>
        public TelemedSearchPageViewModel()
        {
            //RecentDoctorsList
            RecentDoctors.Add(new RecentDoctorsInfo()
            {
                DoctorsName = "Steven Strange",
                Specialization = "Sorcerer Supreme",
                Location = "177a Bleecker St. | USA"
            });

            RecentDoctors.Add(new RecentDoctorsInfo()
            {
                DoctorsName = "Peter Parker",
                Specialization = "Spiderman",
                Location = "177a Bleecker St. | USA"
            });

            RecentDoctors.Add(new RecentDoctorsInfo()
            {
                DoctorsName = "Bruce Banner",
                Specialization = "The Hulk",
                Location = "177a Bleecker St. | USA"
            });

            RecentDoctors.Add(new RecentDoctorsInfo()
            {
                DoctorsName = "Reed Richards",
                Specialization = "Mr.Fantastic",
                Location = "177a Bleecker St. | USA"
            });  
        }

        #region METHODS
        public void Search()
        {
            if (!string.IsNullOrEmpty(SearchedText))
            {
                //Variable that searches through RecentDoctors
                var results = RecentDoctors.Where(x => x.DoctorsName.ToLower().Contains(SearchedText.ToLower()) || 
                x.Specialization.ToLower().Contains(SearchedText.ToLower()));

                SearchResults.Clear();
                foreach (RecentDoctorsInfo item in results)
                {
                    SearchResults.Add(item);
                }
            }
            else
            {
                //This removes items when you clean the text from the SearchBar
                SearchResults.Clear();
            }
        }

        #endregion
    }
}
