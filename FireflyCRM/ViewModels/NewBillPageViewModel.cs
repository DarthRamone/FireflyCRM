using System.Collections.ObjectModel;
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
        
        public Command AddNewReceiptItemCommand { get; }

        private double _listViewHeight;
        public double ListViewHeight
        {
            get => _listViewHeight;
            set => SetProperty(ref _listViewHeight, value);
        }
        
        public NewBillPageViewModel()
        {
            ReceiptItems = new ObservableCollection<ReceiptItemViewModel> {new ReceiptItemViewModel()};
            AddNewReceiptItemCommand = new Command(AddNewReceiptItem);
            ListViewHeight = 80;
        }

        private void AddNewReceiptItem()
        {
            ReceiptItems.Add(new ReceiptItemViewModel());
            ListViewHeight = ReceiptItems.Count * 80;
        }
    }
}