using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CrewPocket
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
              
        public MainPage()
        {
            InitializeComponent();
          
            ListView.ItemsSource = Name.APIUri;

            ListView.RefreshCommand = new Command(() => {
                //Do your stuff.
                RefreshData();
                ListView.IsRefreshing = false;
            });
        }

        public void RefreshData()
        {
          ListView.ItemsSource = null;
            DisplayAlert("Alert","Deleted","Ok");
          }


        public void HamburgerButtonClicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        public void LibraryButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new library());
        }

        public void LogOutButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine(User.Id);
        }

    }
}
