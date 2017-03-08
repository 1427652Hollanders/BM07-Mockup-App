using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MockupApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BsCases : ContentPage
    {
        public BsCases(string selectedActivity)
        {
            Title = selectedActivity;
            InitializeComponent();
            LvCases.ItemsSource = new List<string>
            {
                "Tekenen", "Schrijven", "Plakken", "Knippen"
            };
        }

        private void LvCases_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedCase = LvCases.SelectedItem.ToString();
            Navigation.PushAsync(new BsCaseCatNotitie(selectedCase));
        }

    }
}
