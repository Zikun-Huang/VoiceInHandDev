using System;
using System.Collections.Generic;
using VoiceInHandDev.ViewModels;
using VoiceInHandDev.Views;
using Xamarin.Forms;

namespace VoiceInHandDev
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
