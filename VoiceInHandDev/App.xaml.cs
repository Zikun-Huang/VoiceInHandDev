using System;
using VoiceInHandDev.Services;
using VoiceInHandDev.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace VoiceInHandDev
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=f630f53e-86ec-4c48-853a-00d5de96201f;" +
                  "ios=b0de3ea8-d031-48f6-97ec-503f424f2e0a",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
