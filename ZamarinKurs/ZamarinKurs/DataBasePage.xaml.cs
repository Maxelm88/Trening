using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZamarinKurs.Persistence;

namespace ZamarinKurs
{
    public class Recipe : INotifyPropertyChanged
    {
        //potrzebne do akutalizonia ObserverCollection
        public event PropertyChangedEventHandler PropertyChanged;

        //definicja kolumny Id
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        //definicja kolumny Name
        private string _name;
        [MaxLength(255)]
        public string Name { 
            get { return _name;  }
            set
            {
                if (_name == value)
                    return;
                _name = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // jeżeli PropertyChanged jest null to nic nie rób, inaczej wykonaj (Invoke)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBasePage : ContentPage
    {
        //połączenie z bazą
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipes;
        public DataBasePage()
        {
            InitializeComponent();

            //nawiązanie połaczenia
           _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

        }

        //przy powstaniu aplikacji:
        protected override async void OnAppearing()
        {
            //stwórz tabele jeżeli nie istnieje
            await _connection.CreateTableAsync<Recipe>();

            //pobierz tabele jako lista
            var recipes = await _connection.Table<Recipe>().ToListAsync();
            //utwórz nowy observableCollection z listy powyżej
            _recipes = new ObservableCollection<Recipe>(recipes);
            //pokazanie listy w aplikacji
            recipesListView.ItemsSource = _recipes;

            base.OnAppearing();
        }

        async void OnAdd(object sender, EventArgs e)
        {
            //stworz nowy wpis recipe
            var recipe = new Recipe { Name = "Recipe " + DateTime.Now.Ticks };
            //dodaj do bazdy danych
            await _connection.InsertAsync(recipe);
            //dodaj do listy observableCollection
            _recipes.Add(recipe);
        }

        async void OnUpdate(object sender, EventArgs e)
        {
            //zaktualizuj 1 wpis
            var recipe = _recipes[0];
            recipe.Name += " UPDATE";

            //zaktualizuj wpis w tabeli
           await _connection.UpdateAsync(recipe);
        }

        async void OnDelete(object sender, EventArgs e)
        {
            //skasuj 1 wpis
            var recipe = _recipes[0];
            //skasuj z listy observableCollection
            _recipes.Remove(recipe);
            //skasuj w tabeli
            await _connection.DeleteAsync(recipe);

        }
    }
}