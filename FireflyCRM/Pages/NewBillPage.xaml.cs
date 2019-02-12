using System;
using FireflyCRM.ViewModels;
using Xamarin.Forms;

namespace FireflyCRM.Pages
{
    public partial class NewBillPage
    {
        private readonly NewBillPageViewModel _viewModel;
        
        public NewBillPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new NewBillPageViewModel();
        }
    }
}