using System.Windows.Input;
using Xamarin.Forms;

namespace FireflyCRM.ViewModels
{
  public class BasePopoverViewModel : BaseViewModel
  {
    public ICommand DismissCommand { get; }

    public BasePopoverViewModel()
    {
      DismissCommand = new Command(DismissCommandHandler);
    }
    
    public void DismissCommandHandler()
    {
      Navigation.PopModalAsync();
    }
  }
}