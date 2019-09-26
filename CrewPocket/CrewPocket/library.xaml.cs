using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrewPocket
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class library : ContentPage
    {
        public library()
        {
            InitializeComponent();
            tabView.TabItemTapped += itemChanged;
        }



        private void itemChanged(object sender, Syncfusion.XForms.TabView.TabItemTappedEventArgs e)
        {
            Console.WriteLine(e.TabItem.ClassId);
        }
    }
}