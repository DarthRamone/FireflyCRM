using FireflyCRM.ViewModels;
using Xamarin.Forms;

namespace FireflyCRM.Pages
{
  public class BasePage<T> : ContentPage where T : BaseViewModel, new() 
  {
    protected T ViewModel { get; private set; }        

    protected void InitializeViewModel()
    {
      ViewModel = new T();
      BindingContext = ViewModel;
    }

    protected override void OnAppearing()
    {
      base.OnAppearing();
      ViewModel?.OnAppearing();
    }

    protected override void OnDisappearing()
    {
      base.OnDisappearing();
      ViewModel?.OnDisappearing();
    }
  }
}