using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        ObservableCollection<Coffee> coffees = new ObservableCollection<Coffee>();
        public ObservableCollection<Coffee> Coffees { get { return coffees; } }
        public TabbedPage1 ()
        {
            InitializeComponent();
            CoffeeView.ItemsSource = coffees;

            coffees.Add(new Coffee { CoffeeName = "Americano", CoffeeDetails = "Price: 160 Php", Image = "americano_coffee.jpg" });
            coffees.Add(new Coffee { CoffeeName = "Iced Coffee", CoffeeDetails = "Price: 190 Php", Image = "iced_coffee.jpg" });
            coffees.Add(new Coffee { CoffeeName = "Macchiato Coffee", CoffeeDetails = "Price: 170 Php", Image = "macchiato_coffee.jpg" });
        }

        private void MenuDelete(object sender, EventArgs e)
        {
            DisplayAlert("Delete", "You pressed delete", "OK");
        }

        private async void Menu_Open(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}