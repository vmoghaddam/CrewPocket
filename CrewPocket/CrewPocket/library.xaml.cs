using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrewPocket
{

    public partial class library : ContentPage
    {
        RestService _restService;


        public new List<Book> Books { get; set; }

        public library()
        {
            InitializeComponent();
            _restService = new RestService();
            tabView.TabItemTapped += itemChanged;
        }

        private void itemChanged(object sender, Syncfusion.XForms.TabView.TabItemTappedEventArgs e)
        {
            Console.WriteLine(e.TabItem.ClassId);
        }

        string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            return requestUri;
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var url = "http://apig.epapocket.ir/odata/employees/library/" + User.Id + "/83";
            Books = await _restService.GetBooksAsync(GenerateRequestUri(url));
            books.ItemsSource = Books;

        }


    }
}