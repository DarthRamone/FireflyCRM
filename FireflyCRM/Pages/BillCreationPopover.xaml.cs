using ModulBank.Models;

namespace FireflyCRM.Pages
{
    public partial class BillCreationPopover
    {
        public BillCreationPopover(BillPayload payload, bool isTesting)
        {
            InitializeComponent();
            InitializeViewModel();
            ViewModel.IsTesting = isTesting;
            ViewModel.BillPayload = payload;
        }
    }
}
