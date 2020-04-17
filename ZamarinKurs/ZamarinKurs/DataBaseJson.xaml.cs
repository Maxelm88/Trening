using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZamarinKurs
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBaseJson : ContentPage
    {
        //url jsona
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        //nowy obiekt do połączenia
        private HttpClient _client = new HttpClient();
        //utworzenie listy ObservableCollection
        private ObservableCollection<Post> _posts;

        public DataBaseJson()
        {
            InitializeComponent();
        }

        //metoda uruchamia się przy starcie aplikacji
        protected override async void OnAppearing()
        {
            //nawiązanie połączenia
            var content = await _client.GetStringAsync(Url);
            //odczytanie jsona
            var posts = JsonConvert.DeserializeObject<List<Post>>(content);
            //pobranie danych z jsona
            _posts = new ObservableCollection<Post>(posts);
            //pobranie danych do aplikacji
            postsListView.ItemsSource = _posts;

            base.OnAppearing();
        }

        async void OnAdd(object sender, System.EventArgs e)
        {
            //dodanie nowego wpisu w aplikacji
            var post = new Post { Title = "Title" + DateTime.Now.Ticks };
            //dodanie do listy w aplikacji
            _posts.Insert(0, post);
            //przerobienie na jsona
            var content = JsonConvert.SerializeObject(post);
            //wyslanie wpisu na serwer json
            await _client.PostAsync(Url, new StringContent(content));
        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            //wybranie 1 wpisu z góry
            var post = _posts[0];
            //akutalizacja 1 z góry wpisu
            post.Title += " UPDATE";
            //przerobienie na jsona
            var content = JsonConvert.SerializeObject(post);
            //zaktualizowanie wpisu na serwer json
            await _client.PutAsync(Url + "/" + post.Id, new StringContent(content));
        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            //wybranie 1 wpisu z góry
            var post = _posts[0];
            //usunięcie z listy w aplikacji
            _posts.Remove(post);
            //usunięcie wpisu na serwer json
            await _client.DeleteAsync(Url + "/" + post.Id);
        }
    }
}