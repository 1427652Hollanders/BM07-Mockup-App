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
        public List<string> Cases { get; set; }
        public int AddButtonIndex { get; set; }

        public Clients_1(string clientname)
        {
            
            Title = clientname;
            AddButtonIndex = 0;

            InitializeComponent();
            EntryCaseName.IsVisible = false;

            GenerateInfo(clientname);
            GenerateCases();

        }

        private void GenerateCases()
        {
            //LvCases.ItemsSource = new List<string>
            //{
            //    "Case 1","Case 2","Case 3","Case 4","Case 5","Case 6"
            //};

            Cases = new List<string>();
            Cases.Add("Case 1");
            LvCases.ItemsSource = Cases;

        }

        private void GenerateInfo(string clientname)
        {
            var random = new Random();
            var achternamen = new List<string> { "Plant", "van Dillen", "Philippen", "van Ballegooij", "van Stein", "Schroevers", "Devilee" };
            int index = random.Next(achternamen.Count);
            Fullname = clientname + " " + achternamen[index];
            Lbinfo.Text = "Volledige naam: " + Fullname;
            Lbinfo2.Text = "Overige informatie: Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
        }

        private void BtnAdd_OnClicked(object sender, EventArgs e)
        {
            if (AddButtonIndex == 0)
            {
                EntryCaseName.IsVisible = true;
                AddButtonIndex = 1;
            }
            else
            {
                EntryCaseName.IsVisible = false;
                AddButtonIndex = 0;
            }
        }
    }
}
