using BluePillApp.Controls;
using BluePillApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BluePillApp.Helpers
{
    class TemplateSelector : DataTemplateSelector
    {
        DataTemplate incomingDataTemplate;
        DataTemplate outgoingDataTemplate;

        public TemplateSelector()
        {
            this.incomingDataTemplate = new DataTemplate(typeof(IncomingMessageItemControl));
            this.outgoingDataTemplate = new DataTemplate(typeof(OutgoingMessageItemControl));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVM = item as ChatMessageModel;
            if(messageVM == null)
            {
                return null;
            }

            return (messageVM.User == App.User) ? outgoingDataTemplate : incomingDataTemplate;
        }
    }
}
