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
	public partial class CarouselPage1 : CarouselPage
	{
        ObservableCollection<Coffee> coffees = new ObservableCollection<Coffee>();
        public ObservableCollection<Coffee> Coffees { get { return coffees; } }
        public CarouselPage1()
        {
            InitializeComponent();
            CoffeeView.ItemsSource = coffees;

            coffees.Add(new Coffee { CoffeeName = "Pure Matcha Latte", CoffeeDetails = "Price: 180 Php", Image = "matcha_coffee.jpg" });
            coffees.Add(new Coffee { CoffeeName = "Strawberry Frappuccino", CoffeeDetails = "Price: 185 Php", Image = "strawberry_coffee.jpg" });
            coffees.Add(new Coffee { CoffeeName = "Chai Tea Latte", CoffeeDetails = "Price: 175 Php", Image = "chai_coffee.jpg" });
        }

        private void MenuDelete(object sender, EventArgs e)
        {
            DisplayAlert("Delete", "You pressed delete", "OK");
        }
    }
}