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
    public partial class BoomStructuur : ContentPage
    {
        //Op mijn device (Yannik, LG G5), wanneer een part is geselecteerd, pushed die de bsact page naar de "top of the navigation stack". 
        //Als je dan terug gaat en weer op diezelfde participatie wilt klikken, is dat niet mogelijk.
        public BoomStructuur()
        {
            InitializeComponent();
            LvParticipatie.ItemsSource = new List<string>
            {
                "School","Thuis","Vrije Tijd"
            };
        }
        private void LvParticipatie_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedParticipation = LvParticipatie.SelectedItem.ToString();
            Navigation.PushAsync(new BsActiviteiten(selectedParticipation));
        }
    }
}
