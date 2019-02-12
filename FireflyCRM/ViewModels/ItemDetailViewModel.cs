using System;

using FireflyCRM.Models;
using ModulBank.Models;

namespace FireflyCRM.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public ReceiptItem ReceiptItem { get; set; }
        public ItemDetailViewModel(ReceiptItem receiptItem = null)
        {
            Title = "44";//receiptItem?.Quantity?.ToString();
            ReceiptItem = receiptItem;
        }
    }
}
