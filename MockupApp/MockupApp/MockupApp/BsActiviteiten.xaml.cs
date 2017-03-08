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
    public partial class BsActiviteiten : ContentPage
    {
        
        public BsActiviteiten(string gekozenParticipatie)
        {
            Title = gekozenParticipatie;
            InitializeComponent();
            LvActiviteiten.ItemsSource = new List<string>
            {
                "Klas","Gymles","Buiten spelen"
            };
        }

        private void LvActiviteiten_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedActivity = LvActiviteiten.SelectedItem.ToString();  
            Navigation.PushAsync(new BsCases(selectedActivity));
        }
    }
}
