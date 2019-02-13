using System.Collections.Generic;
using FireflyCRM.ViewModels;

namespace FireflyCRM.Pages
{
    public partial class AddReceiptItemPopover
    {   
        public AddReceiptItemPopover(ReceiptItemViewModel viewModel)
        {
            InitializeComponent();
            InitializeViewModel();
            
            //TODO: Temporary
            ViewModel.ReceiptItemViewModel = viewModel;
        }

        public AddReceiptItemPopover(IList<ReceiptItemViewModel> collection)
        {
            InitializeComponent();
            InitializeViewModel();
            
            ViewModel.ReceiptItemViewModel = new ReceiptItemViewModel();
            ViewModel.ReceiptItemsCollection = collection;
        }
    }
}
