using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using FireflyCRM.Models;
using ModulBank;
using ModulBank.Repositories;

namespace FireflyCRM.ViewModels
{
    public class PaymentLinksPageViewModel : BaseViewModel
    {
        private ObservableCollection<NewBillPageViewModel> _paymentLinks;
        public ObservableCollection<NewBillPageViewModel> PaymentLinks
        {
            get => _paymentLinks;
            set => SetProperty(ref _paymentLinks, value);
        }
        
        public PaymentLinksPageViewModel()
        {
            Title = "About";
            LoadPaymentLinks();
        }

        private async void LoadPaymentLinks()
        {
            IsBusy = true;
            
            /*var links = await BankApi.GetPaymentLinks();
            PaymentLinks = new ObservableCollection<PaymentLinkViewModel>(links.Select(l => new PaymentLinkViewModel(l)));*/


            IsBusy = false;
        }
    }
}