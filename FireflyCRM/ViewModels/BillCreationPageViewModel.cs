using System;
using System.Diagnostics;
using System.Windows.Input;
using FireflyCRM.Services.KeystoreProvider;
using ModulBank;
using ModulBank.Models;
using Xamarin.Forms;

namespace FireflyCRM.ViewModels
{
  public class BillCreationPageViewModel : BasePopoverViewModel
  {
    public BillPayload BillPayload;
    
    private string _url;
    public string Url
    {
      get => _url;
      set => SetProperty(ref _url, value);
    }
    
    public ICommand CopyUrlCommand { get; }

    public BillCreationPageViewModel()
    {
      IsBusy = true;
      CopyUrlCommand = new Command(CopyUrlCommandHandler);
    }

    private void CopyUrlCommandHandler()
    {
      Plugin.Clipboard.CrossClipboard.Current.SetText(Url);
      //TODO: Show toast
    }
    
    public override async void OnAppearing()
    {
      base.OnAppearing();
      var keystore = new KeystoreProvider();
      var modulBankClient = new ModulBankClient(keystore.SecretKey);
      
      try
      {
        var bill = await modulBankClient.CreateBill(BillPayload);
        Url = bill.Url;
      }
      catch(Exception ex)
      {
        Debug.WriteLine(ex.Message);
      }

      IsBusy = false;
    } 
  }
}