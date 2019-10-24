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
        public new List<Video> Videos { get; set; }
        public new List<Paper> Papers { get; set; }
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
            var book = "http://apig.epapocket.ir/odata/employees/library/" + User.Id + "/83";
            Books = await _restService.GetBooksAsync(GenerateRequestUri(book));
            books.ItemsSource = Books;
            var video = "http://apig.epapocket.ir/odata/employees/library/" + User.Id + "/85";
            Videos = await _restService.GetVideosAsync(GenerateRequestUri(video));
            videos.ItemsSource = Videos;
            var paper = "http://apig.epapocket.ir/odata/employees/library/" + User.Id + "/84";
            Papers = await _restService.GetPapersAsync(GenerateRequestUri(paper));
            papers.ItemsSource = Papers;
        }


    }
}