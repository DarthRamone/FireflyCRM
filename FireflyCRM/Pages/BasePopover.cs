using FireflyCRM.ViewModels;

namespace FireflyCRM.Pages
{
  public class BasePopover<T> : BasePage<T> where T : BasePopoverViewModel, new() 
  {
  }
}