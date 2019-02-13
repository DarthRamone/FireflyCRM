using System;
using FireflyCRM.ViewModels;

namespace FireflyCRM.Pages
{
    public partial class AddReceiptItemPopover
    {   
        public AddReceiptItemPopover()
        {
            InitializeComponent();
            InitializeViewModel();
            
            //TODO: Temporary
            ViewModel.ReceiptItemViewModel = new ReceiptItemViewModel();
        }
    }
}
