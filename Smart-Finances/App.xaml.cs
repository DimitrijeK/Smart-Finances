using Smart_Finances.Services;
using Smart_Finances.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Smart_Finances
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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
