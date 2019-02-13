using System;

namespace FireflyCRM.Pages
{
    public partial class NewBillPage
    {   
        public NewBillPage()
        {
            InitializeComponent();
        }

        private void AddReceiptButtonClickedHandler(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddReceiptItemPopover());
        }
    }
}