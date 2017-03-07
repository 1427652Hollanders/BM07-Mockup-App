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
    public partial class Clients : ContentPage
    {
        public Clients()
        {

            InitializeComponent();
            LvClient.ItemsSource = new List<string>
            {
                "Ad","Bert","Chris","Dirk","Erik","Frederik"
            };

        }

        private void LvClient_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedclient = LvClient.SelectedItem.ToString();
            Navigation.PushAsync(new Clients_1(selectedclient));
        }
    }
}
