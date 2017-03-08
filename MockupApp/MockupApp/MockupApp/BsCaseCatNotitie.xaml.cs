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
    public partial class BsCaseCatNotitie : ContentPage
    {
        public BsCaseCatNotitie(string selectedCase)
        {
            Title = selectedCase;
            InitializeComponent();
            CaseCat1Picker.Title = "Categorie 1";
            CaseCat1Picker.Items.Add("Bx2018");
            CaseCat1Picker.Items.Add("Bx2011");
            CaseCat1Picker.Items.Add("Bx202");
            CaseCat1Picker.Items.Add("Bx201");
            Cat1Notitie.HeightRequest = 125;

            CaseCat2Picker.Title = "Categorie 2";
            CaseCat2Picker.Items.Add("Ax2018");
            CaseCat2Picker.Items.Add("Ax2011");
            CaseCat2Picker.Items.Add("Ax202");
            CaseCat2Picker.Items.Add("Ax201");
            Cat2Notitie.HeightRequest = 125;


        }
    }
}
