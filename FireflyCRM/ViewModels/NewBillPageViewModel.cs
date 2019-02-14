using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Input;
using FireflyCRM.Pages;
using ModulBank.Models;
using Xamarin.Forms;

namespace FireflyCRM.ViewModels
{
    public class NewBillPageViewModel : BaseViewModel
    {
        private string _id;
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }
        
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
        
        private double _amount;
        public double Amount
        {
            get => _amount;
            set => SetProperty(ref _amount, value);
        }
        
        private ObservableCollection<ReceiptItemViewModel> _receiptItems;
        public ObservableCollection<ReceiptItemViewModel> ReceiptItems
        {
            get => _receiptItems;
            set => SetProperty(ref _receiptItems, value);
        }

        private double _listViewHeight;
        public double ListViewHeight
        {
            get => _listViewHeight;
            set => SetProperty(ref _listViewHeight, value);
        }
        
        public ICommand AddReceiptItemCommand { get; }
        
        public NewBillPageViewModel()
        {
            ReceiptItems = new ObservableCollection<ReceiptItemViewModel>();
            ListViewHeight = 80;
            
            AddReceiptItemCommand = new Command(AddReceiptItemCommandHandler);
        }

        private void AddReceiptItemCommandHandler()
        {
            //TODO: Pass new item
            Navigation.PushModalAsync(new AddReceiptItemPopover(ReceiptItems));
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            ReceiptItems.CollectionChanged += ReceiptItemsCollectionChangedHanlder;
        }

        private void ReceiptItemsCollectionChangedHanlder(object sender, NotifyCollectionChangedEventArgs e)
        {
            Amount = ReceiptItems.Sum(receiptItem => receiptItem.Price);
        }
    }
}