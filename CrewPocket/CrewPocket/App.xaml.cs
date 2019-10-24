using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrewPocket
{
    public partial class App : Application
    {
        public App()
        {

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTM4MDM0QDMxMzcyZTMyMmUzMGcrZjBJLy9kTTRHUTNWdTZDcUFDcFdzZURPT1RPL3ozK2xpZHA0TFgxTk09");
            InitializeComponent();

            MainPage =  new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            User.Id = 5;
          
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
           
        }
    }
}
