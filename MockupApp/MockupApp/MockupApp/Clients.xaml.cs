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
            //Op mijn device (Yannik, LG G5), wanneer een client is geselecteerd, pushed die de client1 page naar de "top of the navigation stack". 
            //Als je dan terug gaat en weer op diezelfde client wilt klikken, is dat niet mogelijk.
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
