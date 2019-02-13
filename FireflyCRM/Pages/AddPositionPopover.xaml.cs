using System;

namespace FireflyCRM.Pages
{
    public partial class AddReceiptItemPopover
    {
        public AddReceiptItemPopover()
        {
            InitializeComponent();
        }
        
        private void CloseButtonHandler(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
