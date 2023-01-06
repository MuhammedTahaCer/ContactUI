using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace repContactUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Contacts();
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
