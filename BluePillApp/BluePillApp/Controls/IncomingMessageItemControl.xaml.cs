using BluePillApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BluePillApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncomingMessageItemControl : ViewCell
    {
        public IncomingMessageItemControl()
        {
            InitializeComponent();

            BindingContext = new ChatMessageModel();

            _ = ChangeVisibilityAsync();
        }

        public async Task ChangeVisibilityAsync()
        {
            messageBubble.IsVisible = false;
            chatbotMessageIndicator.IsVisible = true;
            await Task.Delay(1000);
            messageBubble.IsVisible = true;
            chatbotMessageIndicator.IsVisible = false;
            chatbotMessageIndicator.IsRunning = false;
        }
    }
}