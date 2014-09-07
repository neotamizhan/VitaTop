using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VitaTop.ServiceModel;
using ServiceStack;

namespace VitaTop.Desktop
{
    /// <summary>
    /// Interaction logic for Ingredients.xaml
    /// </summary>
    public partial class ListAllIngredients : Page
    {
        public List<Ingredient> IngredientList = null;

        public ListAllIngredients()
        {
            var client = new JsonServiceClient("http://localhost/vitatop2013");

            InitializeComponent();
            dataGrid1.ItemsSource = client.Get<List<Ingredient>>("/ingredients/all");
        }
    }
}
