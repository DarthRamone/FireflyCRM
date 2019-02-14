using FireflyCRM.iOS.Renderers;
using FireflyCRM.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(FireflyEntry), typeof(FireflyEntryRenderer_iOS))]
namespace FireflyCRM.iOS.Renderers
{
  public class FireflyEntryRenderer_iOS : EntryRenderer
  {
    protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
    {
      base.OnElementChanged(e);
      if (e.NewElement != null)
      {
        Control.BorderStyle = UITextBorderStyle.None;
      }
    }
  }
}