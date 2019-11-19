using System;
using System.Collections.Generic;
using System.Text;

namespace BluePillApp.Models
{
    public class ChatMessageModel
    {
        /// <summary>
        /// The messages text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Name of the user sending the message
        /// </summary>
        public string User { get; set; }
    }
}
