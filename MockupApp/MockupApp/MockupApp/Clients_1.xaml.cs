using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MockupApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Clients_1 : ContentPage
    {
        public string Fullname { get; set; }
        public string clientname { get; set; }
        public List<string> Cases { get; set; }
        public int AddButtonIndex { get; set; }

        public Clients_1(string clientname)
        {
            
            Title = clientname;
            AddButtonIndex = 0;

            InitializeComponent();
            //EntryCaseName.IsVisible = false;

            GenerateInfo(clientname);
           // GenerateCases();

        }

       // private void GenerateCases()
       // {
            //LvCases.ItemsSource = new List<string>
            //{
            //    "Case 1","Case 2","Case 3","Case 4","Case 5","Case 6"
            //};

       //     Cases = new List<string>();
       //     Cases.Add("Case 1");
       //     LvCases.ItemsSource = Cases;

      //  }

        private void GenerateInfo(string clientname)
        {
            var random = new Random();
            var achternamen = new List<string> { "Plant", "van Dillen", "Philippen", "van Ballegooij", "van Stein", "Schroevers", "Devilee" };
            int index = random.Next(achternamen.Count);
            Fullname = clientname + " " + achternamen[index];
            Lbinfo.Text = "Volledige naam: " + Fullname;
            Lbinfo2.Text = "Testtext waarin clientgegevens staan.";
        }

        private void BtnAdd_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BsParticipatie(clientname));
            //if (AddButtonIndex == 0)
            //{
            //    EntryCaseName.IsVisible = true;
            //    AddButtonIndex = 1;
            //}
            //else
            //{
            //    EntryCaseName.IsVisible = false;
            //    AddButtonIndex = 0;
            //}
        }
    }
}
