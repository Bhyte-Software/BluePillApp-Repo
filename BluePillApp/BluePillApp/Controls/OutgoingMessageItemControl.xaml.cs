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
    public partial class OutgoingMessageItemControl : ViewCell
    {
        public OutgoingMessageItemControl()
        {
            InitializeComponent();

            BindingContext = new ChatMessageModel();
        }
    }
}