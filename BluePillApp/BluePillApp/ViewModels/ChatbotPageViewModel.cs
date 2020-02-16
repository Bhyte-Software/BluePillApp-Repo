using BluePillApp.Models;
using BluePillApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Syn.Bot.Siml;
using Syn.Bot.Oscova;
using Syn.Bot.Oscova.Attributes;
using System.Reflection;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BluePillApp.ViewModels
{
    /// <summary>
    /// View model for the ChatbotPage.xaml
    /// </summary>
    public class ChatbotPageViewModel : BaseViewModel
    {
        /// <summary>
        /// A field for TextToSend
        /// </summary>
        private string _texttosend;

        /// <summary>
        /// An Instance of a new SIML Oscova Chatbot
        /// </summary>
        public OscovaBot chatbot;

        /// <summary>
        /// A collection/list of chat message items
        /// </summary>
        public ObservableCollection<ChatMessageModel> Messages { get; set; } = new ObservableCollection<ChatMessageModel>();

        /// <summary>
        /// The text that the user inputs
        /// </summary>
        public string TextToSend
        {
            get
            {
                return _texttosend;
            }

            set
            {
                if (_texttosend != value)
                {
                    _texttosend = value;

                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// A command for sending the users messages
        /// </summary>
        public ICommand SendCommand { get; set; }


        /// <summary>
        /// ChatPageViewModel Constructor
        /// </summary>
        public ChatbotPageViewModel()
        {
            SendCommand = new RelayCommand(Send);

            chatbot = new OscovaBot();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("BluePillApp.Helpers.new.siml");

            chatbot.Import(XDocument.Load(stream));
            chatbot.Trainer.StartTraining();

            //This gets the chatbots response for each message
            chatbot.MainUser.ResponseReceived += async (sender, args) =>
            {
                await Task.Delay(1500);
                Messages.Add(new ChatMessageModel() { Text = args.Response.Text, User = App.ChatBot });
            };
        }

        /// <summary>
        /// This function sends a message
        /// </summary>
        public void Send()
        {
            if (!string.IsNullOrEmpty(TextToSend))
            {
                var msgModel = new ChatMessageModel() { Text = TextToSend, User = App.User };

                //This adds a new message to the messages collection
                Messages.Add(msgModel);
                
                var result = chatbot.Evaluate(TextToSend);
                result.Invoke();

                //Removes the text in the Entry after message is sent
                TextToSend = string.Empty;
            }
        }
    }
}
