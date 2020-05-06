using Lab06;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        public ObservableCollection<GroupedSuperHeroModel> grouped { get; set;  }
        public ListViewSource()
        {
            InitializeComponent();
            grouped = new ObservableCollection<GroupedSuperHeroModel>();
            var marvelHeroes = new GroupedSuperHeroModel() { Comic = "Marvel" };
            marvelHeroes.Add(new SuperHeroModel() { Name = "Iron Man", AlterEgo = "Tony Stark" });
            marvelHeroes.Add(new SuperHeroModel() { Name = "Captain America", AlterEgo = "Steve Rogers" });
            marvelHeroes.Add(new SuperHeroModel() { Name = "Thor God of Thunder", AlterEgo = "Thor Odinson" });
            var dcHeroes = new GroupedSuperHeroModel() { Comic = "DC" };
            dcHeroes.Add(new SuperHeroModel() { Name = "Batman", AlterEgo = "Bruce Wayne" });
            dcHeroes.Add(new SuperHeroModel() { Name = "Superman", AlterEgo = "Kal-El" });
            dcHeroes.Add(new SuperHeroModel() { Name = "Wonder Woman", AlterEgo = "Princess Diana" });
            grouped.Add(marvelHeroes);
            grouped.Add(dcHeroes);
            lstView.ItemsSource = grouped;
        }
    }
}