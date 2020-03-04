using System;
using System.Collections.Generic;
using System.Text;

namespace BluePillApp.Models
{
    public class RecentDoctorsInfo
    {
        /// <summary>
        /// Full name of the doctor
        /// </summary>
        public string DoctorsName { get; set; }

        /// <summary>
        /// The doctors specialization
        /// </summary>
        public string Specialization { get; set; }

        /// <summary>
        /// The location of the doctor or his/her hospital
        /// </summary>
        public string Location { get; set; }
    }
}
