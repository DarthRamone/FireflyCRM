using ModulBank.Models;

namespace FireflyCRM.Pages
{
    public partial class BillCreationPopover
    {
        public BillCreationPopover(BillPayload payload)
        {
            InitializeComponent();
            InitializeViewModel();
            ViewModel.BillPayload = payload;
        }
    }
}
