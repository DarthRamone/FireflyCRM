using ModulBank.Models;

namespace FireflyCRM.ViewModels
{
    public class ReceiptItemViewModel : BaseViewModel
    {           
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
        
        private string _name;
        public string Name
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
        
        private double _price;
        public double Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }
        
        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }

        private TaxSystem _sno;
        public TaxSystem Sno
        {
            get => _sno;
            set => SetProperty(ref _sno, value);
        }

        private PaymentObject _paymentObject;
        public PaymentObject PaymentObject
        {
            get => _paymentObject;
            set => SetProperty(ref _paymentObject, value);
        }

        private PaymentMethod _paymentMethod;
        public PaymentMethod PaymentMethod
        {
            get => _paymentMethod;
            set => SetProperty(ref _paymentMethod, value);
        }

        private VAT _vat;
        public VAT Vat
        {
            get => _vat;
            set => SetProperty(ref _vat, value);
        }

        public ReceiptItemViewModel(ReceiptItem receiptItem)
        {
            Description = receiptItem.Description;
            Name = receiptItem.Name;
            Price = receiptItem.Price;
            Quantity = receiptItem.Quantity;
            Sno = receiptItem.Sno;
            PaymentObject = receiptItem.PaymentObject;
            PaymentMethod = receiptItem.PaymentMethod;
            Vat = receiptItem.Vat;
        }

        public ReceiptItemViewModel()
        {
        }
    }
}