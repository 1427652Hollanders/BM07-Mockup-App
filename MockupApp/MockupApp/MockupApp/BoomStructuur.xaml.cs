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
        public BoomStructuur()
        {
            InitializeComponent();
            PartitiepatiePicker.Title = "Participatie";
            PartitiepatiePicker.Items.Add("School");
            PartitiepatiePicker.Items.Add("Thuis");
            PartitiepatiePicker.Items.Add("Vrije tijd");

            ActiviteitenPicker.Title = "Activiteit";
            ActiviteitenPicker.Items.Add("Bx2018");
            ActiviteitenPicker.Items.Add("Bx2011");
            ActiviteitenPicker.Items.Add("Bx202");
            
            CasePicker.Title = "Cases";
            CasePicker.Items.Add("Tekenen");
            CasePicker.Items.Add("Schrijven");
            CasePicker.Items.Add("Plakken");
            CasePicker.Items.Add("Knippen");
        }
        private void BtnAdd_OnClicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new BsParticipatie(clientname));
        }
    }
}
