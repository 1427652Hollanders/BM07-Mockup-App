using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MockupAlt
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn1_OnClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Dashboard());
        }

        private void Btn2_OnClicked(object sender, EventArgs e)
        {

        }

        private void Btn3_OnClicked(object sender, EventArgs e)
        {

        }

        private void Btn4_OnClicked(object sender, EventArgs e)
        {

        }

        private void Btn5_OnClicked(object sender, EventArgs e)
        {

        }
    }
}
