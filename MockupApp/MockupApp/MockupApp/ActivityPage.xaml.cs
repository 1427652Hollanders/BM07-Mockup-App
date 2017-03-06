using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MockupApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityPage : TabbedPage
    {
        public ActivityPage()
        {
            Children.Add(new Dashboard());
            Children.Add(new Clients());
            Children.Add(new BoomStructuur());
            Children.Add(new Kennisbank());
            Children.Add(new Groep());
            InitializeComponent();
        }
    }
}