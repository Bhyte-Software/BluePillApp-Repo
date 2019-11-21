﻿using BluePillApp.Models;
using BluePillApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BluePillApp.ViewModels
{
    /// <summary>
    /// View model for the ChatbotPage.xaml
    /// </summary>
    public class ChatbotPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// A collection.list of chat message items
        /// </summary>
        public ObservableCollection<ChatMessageModel> Messages { get; set; } = new ObservableCollection<ChatMessageModel>();

        /// <summary>
        /// The text that the user inputs
        /// </summary>
        public string TextToSend { get; set; }

        /// <summary>
        /// A command for sending the users messages
        /// </summary>
        public ICommand SendCommand { get; set; }


        /// <summary>
        /// ChatPageViewModel Constructor
        /// </summary>
        public ChatbotPageViewModel()
        {
            Messages.Add(new ChatMessageModel() { Text = "Hi" });
            Messages.Add(new ChatMessageModel() { Text = "How are you?" });

            SendCommand = new RelayCommand(Send);
        }

        /// <summary>
        /// This function sends a message
        /// </summary>
        private void Send()
        {
            if (!string.IsNullOrEmpty(TextToSend))
            {
                //This adds the following to the messages collection
                Messages.Add(new ChatMessageModel() { Text = TextToSend, User = App.User});

                if(TextToSend == "Hey")
                {
                    Messages.Add(new ChatMessageModel() { Text = "Hey yourself"});
                }
            }
        }
    }
}
