using FireflyCRM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FireflyCRM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentsPage : ContentPage
    {
        public PaymentsPage()
        {
            InitializeComponent();

            BindingContext = new PaymentLinksPageViewModel();
        }
    }
}