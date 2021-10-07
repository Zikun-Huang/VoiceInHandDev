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
            Routing.RegisterRoute(nameof(SignToWordPage), typeof(SignToWordPage));
            Routing.RegisterRoute(nameof(VoiceToSignPage), typeof(VoiceToSignPage));
        }

    }
}
